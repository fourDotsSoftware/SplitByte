using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace SplitByte
{
    class SplitHelper
    {
        public static string FirstSplitPartFilePath = "";

        public static List<string> LastSplitFiles = new List<string>();

        public static void SplitFile(string inputFile, long chunkSize, bool split_equal_parts,int equal_parts_num,string path,int patternind,bool delete_after_split,bool keep_timestamp,DateTime timestamp_created,DateTime timestamp_lastupdated,bool compress,bool encrypt,string encryption_password)
        {
            const int BUFFER_SIZE = 20 * 1024;
            byte[] buffer = new byte[BUFFER_SIZE];

            bool first_encrypted_write = false;

            byte[] byteenc = new byte[5];
            byteenc[0] = (byte)120;
            byteenc[1] = (byte)121;
            byteenc[2] = (byte)122;
            byteenc[3] = (byte)123;
            byteenc[4] = (byte)124;
            
            FirstSplitPartFilePath = "";
            
            List<int> last_time = new List<int>();

            LastSplitFiles = new List<string>();

            using (Stream input = File.OpenRead(inputFile))
            {
                if (split_equal_parts)
                {
                    long filen=input.Length;
                    chunkSize = (long)Math.Ceiling((decimal)(input.Length / (decimal)equal_parts_num));
                }
                                

                int index = 0;
                
                long chunknum =(long)(input.Length / (long)BUFFER_SIZE);

                long chunkdiv = 1;
                while (chunknum > 10000)
                {
                    chunknum /= 10;
                    chunkdiv *= 10;
                }                

                int chunkcnt = 0;

                frmMain.Instance.bwSplit.ReportProgress(0,(int)chunknum);

                while (input.Position < input.Length)
                {
                    if (frmMain.Instance.bwSplit.CancellationPending)
                    {
                        return;
                    }

                    GetSplitFilepathResult res=GetSplitFilepath(patternind, inputFile,path, index);

                    string filepath = "";

                    if (res.Skip)
                    {
                        //input.Position = Math.Min(input.Position + chunkSize, input.Length);
                        //index++;
                        frmMain.Instance.bwSplit.CancelAsync();
                        //continue;
                        return;
                    }
                    else
                    {
                        filepath = res.SplitFilepath;
                    }
                    
                    using (Stream output = File.Create(filepath))
                    {
                        if (FirstSplitPartFilePath == String.Empty)
                        {
                            FirstSplitPartFilePath = filepath;
                        }

                        LastSplitFiles.Add(filepath);

                        using (GZipStream gzstream = new GZipStream(output, CompressionMode.Compress, false))
                        {
                            Stopwatch stopWatch = new Stopwatch();
                            stopWatch.Start();

                            int bytesRead = 1;
                            long remaining = (long)Math.Min(input.Length, (long)chunkSize);

                            
                            while (remaining > 0 && bytesRead > 0)
                            {
                                System.Windows.Forms.Application.DoEvents();

                                if (frmMain.Instance.bwSplit.CancellationPending)
                                {
                                    return;
                                }

                                bytesRead = input.Read(buffer, 0, (int)Math.Min(remaining, (long)BUFFER_SIZE));

                                MemoryStream ms = new MemoryStream();
                                
                                if (compress)
                                {
                                    //if (encrypt)
                                    //{
                                        //gzstream.Write(buffer, 0, buffer.Length);
                                    //}
                                    //else
                                    //{
                                        gzstream.Write(buffer, 0, bytesRead);
                                    //}
                                }
                                else
                                {
                                    output.Write(buffer, 0, bytesRead);
                                }

                                remaining -= bytesRead;
                                chunkcnt++;

                                if (chunkcnt % chunkdiv == 0)
                                {                                    
                                    stopWatch.Stop();
                                    // Get the elapsed time as a TimeSpan value.
                                    
                                    frmMain.Instance.bwSplit.ReportProgress(0, new ProgressChange((int)(chunkcnt / chunkdiv),stopWatch.Elapsed));
                                                                        
                                    stopWatch.Start();
                                }
                            }
                        }
                    }

                    if (encrypt)
                    {
                        byte[] bytes_to_encrypt = File.ReadAllBytes(filepath);
                        byte[] bytes_encrypted=EncryptHelper.EncryptBytes(bytes_to_encrypt, encryption_password);

                        using (Stream output = File.Create(filepath))
                        {                       
                           output.Write(byteenc, 0, byteenc.Length);
                           output.Write(bytes_encrypted, 0, bytes_encrypted.Length);                         
                        }
                    }

                    if (keep_timestamp)
                    {
                        //Module.ShowMessage(filepath);

                        FileInfo fi = new FileInfo(filepath);

                        //Module.ShowMessage(timestamp_created.ToString());                        

                        fi.CreationTime = timestamp_created;
                        fi.LastWriteTime = timestamp_lastupdated;                       
                    }

                    index++;
                }              
            }

            if (delete_after_split)
            {
                System.IO.File.Delete(inputFile);
            }

        }

        public static GetSplitFilepathResult GetSplitFilepath(int patternind,string inputFile,string path,int index)
        {
            string filepath="";

            char ic = 'a';
            int ica = (int)ic;

            if (patternind == 0)
            {
                filepath = System.IO.Path.Combine(
                    path, System.IO.Path.GetFileName(inputFile)) + ".part" + index.ToString();
            }
            else if (patternind == 1)
            {
                filepath = System.IO.Path.Combine(
                    path, System.IO.Path.GetFileName(inputFile)) + "." + index.ToString();
            }
            else if (patternind == 2)
            {
                filepath = System.IO.Path.Combine(
                    path, System.IO.Path.GetFileName(inputFile)) + "." + index.ToString("D3");
            }
            else if (patternind == 3)
            {
                string cs = "";

                int imod = index % 26;
                int idiv = index / 26;

                for (int k = 0; k < idiv; k++)
                {
                    cs += "z";
                }

                int icn = ica + imod;
                char ccn = (char)icn;
                cs = ccn.ToString() + cs;


                filepath = System.IO.Path.Combine(
                    path, System.IO.Path.GetFileName(inputFile)) + ".part" + cs;
            }
            else if (patternind == 4)
            {
                string cs = "";

                int imod = index % 26;
                int idiv = index / 26;

                for (int k = 0; k < idiv; k++)
                {
                    cs += "z";
                }

                int icn = ica + imod;
                char ccn = (char)icn;
                cs = ccn.ToString() + cs;

                filepath = System.IO.Path.Combine(
                    path, System.IO.Path.GetFileName(inputFile)) + "." + cs;
            }
            else if (patternind == 5)
            {
                string cs = "";

                int imod = index % 26;
                int idiv = index / 26;

                for (int k = 0; k < idiv; k++)
                {
                    cs += "z";
                }

                int icn = ica + imod;
                char ccn = (char)icn;
                cs = ccn.ToString() + cs;

                int cslen = cs.Length;
                for (int k = 3; k > cslen; k--)
                {
                    cs = "_" + cs;
                }

                filepath = System.IO.Path.Combine(
                    path, System.IO.Path.GetFileName(inputFile)) + "." + cs;
            }

            GetSplitFilepathResult res = new GetSplitFilepathResult();

            if (System.IO.File.Exists(filepath) && !ArgsHelper.Overwrite && !(frmOverwrite.DefaultOverwriteOption==OverwriteOption.Overwrite))
            {
                if (frmOverwrite.DefaultOverwriteOption == OverwriteOption.Ask)
                {
                    frmOverwrite f = new frmOverwrite(filepath);
                    f.ShowDialog();


                    res.Skip = (f.OverwriteOption == OverwriteOption.Skip);

                    if (f.OverwriteOption == OverwriteOption.Overwrite)
                    {
                        res.SplitFilepath = filepath;
                    }
                    else if (f.OverwriteOption == OverwriteOption.Rename)
                    {
                        res.SplitFilepath = f.OverNewFilepath;
                    }                   
                }
                else if (frmOverwrite.DefaultOverwriteOption==OverwriteOption.Skip)
                {
                    res.Skip = true;
                }
                else if (frmOverwrite.DefaultOverwriteOption == OverwriteOption.Rename)
                {
                    frmOverwriteNewFilename fr = new frmOverwriteNewFilename(filepath);
                    if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        res.SplitFilepath=fr.txtNewFilename.Text;
                        res.Skip = false;
                    }
                }

                return res;
            }
            else
            {
                res.SplitFilepath = filepath;
                res.Skip = false;

                return res;
            }
        }
    }

    class ProgressChange
    {
        public int ChunkNum = 0;
        public TimeSpan Elapsed;

        public ProgressChange(int chunknum, TimeSpan elapsed)
        {
            ChunkNum = chunknum;
            Elapsed = elapsed;
        }
    }
        
    class GetSplitFilepathResult
    {
        public bool Skip = false;
        public string SplitFilepath = "";
    }
}
