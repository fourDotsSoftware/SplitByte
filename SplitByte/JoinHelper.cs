using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace SplitByte
{
    class JoinHelper
    {
        public static string Password = "";
        public static string JoinOutputFile = "";

        public static List<string> GetListOfParts(string inputFile)
        {
            inputFile = inputFile.ToLower();
                        
            List<string> joinfiles = new List<string>();

            joinfiles.Add(inputFile);

            string[] filez = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(inputFile));

            Regex rex0c = new Regex(@".part\d\d\d$", RegexOptions.IgnoreCase);
            Regex rex0b = new Regex(@".part\d\d$", RegexOptions.IgnoreCase);
            Regex rex0=new Regex(@".part\d+$",RegexOptions.IgnoreCase);
            Regex rex1 = new Regex(@".\d\d\d$");
            Regex rex1b = new Regex(@".\d\d$");
            Regex rex2 = new Regex(@".\d+$");
            Regex rex3 = new Regex(@".part[a-z]+$",RegexOptions.IgnoreCase);
            Regex rex4 = new Regex(@".[a-z_][a-z_][a-z_]+$", RegexOptions.IgnoreCase);
            Regex rex5 = new Regex(@".[a-z_]+$", RegexOptions.IgnoreCase);


            if (rex0c.IsMatch(inputFile))
            {
                Match ma = rex0c.Match(inputFile);

                int epos = ma.Index;

                string first_part = inputFile.Substring(0, epos);
                string ind_part = inputFile.Substring(epos +"part".Length + 1);
                int ind = int.Parse(ind_part);

                while (true)
                {
                    ind++;

                    bool found = false;

                    for (int k = 0; k < filez.Length; k++)
                    {
                        if (filez[k].ToLower() == first_part + ".part" + ind.ToString("D3"))
                        {
                            joinfiles.Add(filez[k]);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        break;
                    }
                }
            }
            else if (rex0b.IsMatch(inputFile))
            {
                Match ma = rex0b.Match(inputFile);

                int epos = ma.Index;

                string first_part = inputFile.Substring(0, epos);
                string ind_part = inputFile.Substring(epos+ "part".Length+ 1);
                int ind = int.Parse(ind_part);

                while (true)
                {
                    ind++;

                    bool found = false;

                    for (int k = 0; k < filez.Length; k++)
                    {
                        if (filez[k].ToLower() == first_part + ".part" + ind.ToString("D2"))
                        {
                            joinfiles.Add(filez[k]);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        break;
                    }
                }
            }
            else if (rex0.IsMatch(inputFile))
            {
                int epos = inputFile.LastIndexOf(".part");

                string first_part = inputFile.Substring(0, epos);
                //joinfiles.Insert(0,first_part);

                string ind_part = inputFile.Substring(epos + ".part".Length);
                int ind = int.Parse(ind_part);

                while (true)
                {
                    ind++;

                    bool found = false;

                    for (int k = 0; k < filez.Length; k++)
                    {
                        if (filez[k].ToLower() == first_part + ".part" + ind.ToString())
                        {
                            joinfiles.Add(filez[k]);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        break;
                    }
                }
            }
            else if (rex1.IsMatch(inputFile))
            {
                Match ma = rex1.Match(inputFile);

                int epos = ma.Index;

                string first_part = inputFile.Substring(0, epos);
                string ind_part = inputFile.Substring(epos + 1);
                int ind = int.Parse(ind_part);

                //joinfiles.Insert(0,first_part);

                while (true)
                {
                    ind++;

                    bool found = false;

                    for (int k = 0; k < filez.Length; k++)
                    {
                        if (filez[k].ToLower() == first_part.ToLower() + "." + ind.ToString("D3"))
                        {
                            joinfiles.Add(filez[k]);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        break;
                    }
                }
            }
            else if (rex1b.IsMatch(inputFile))
            {
                Match ma = rex1b.Match(inputFile);

                int epos = ma.Index;

                string first_part = inputFile.Substring(0, epos);
                string ind_part = inputFile.Substring(epos + 1);
                int ind = int.Parse(ind_part);

                //joinfiles.Insert(0,first_part);

                while (true)
                {
                    ind++;

                    bool found = false;

                    for (int k = 0; k < filez.Length; k++)
                    {
                        if (filez[k].ToLower() == first_part.ToLower() + "." + ind.ToString("D2"))
                        {
                            joinfiles.Add(filez[k]);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        break;
                    }
                }
            }
            else if (rex2.IsMatch(inputFile))
            {
                Match ma = rex2.Match(inputFile);

                int epos = ma.Index;

                string first_part = inputFile.Substring(0, epos);
                string ind_part = inputFile.Substring(epos + 1);
                int ind = int.Parse(ind_part);

                // joinfiles.Insert(0,first_part);

                while (true)
                {
                    ind++;

                    bool found = false;

                    for (int k = 0; k < filez.Length; k++)
                    {
                        if (filez[k].ToLower() == first_part + "." + ind.ToString())
                        {
                            joinfiles.Add(filez[k]);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        break;
                    }
                }
            }
            else if (rex3.IsMatch(inputFile))
            {
                int epos = inputFile.LastIndexOf(".part");

                string first_part = inputFile.Substring(0, epos);
                string ind_part = inputFile.Substring(epos + ".part".Length);

                //joinfiles.Insert(0,first_part);

                while (true)
                {
                    ind_part = FindNextA(ind_part);

                    bool found = false;

                    for (int k = 0; k < filez.Length; k++)
                    {
                        if (filez[k].ToLower() == first_part + ".part" + ind_part.ToString())
                        {
                            joinfiles.Add(filez[k]);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        break;
                    }
                }
            }
            else if (rex4.IsMatch(inputFile))
            {
                Match ma = rex4.Match(inputFile);

                int epos = ma.Index;

                string first_part = inputFile.Substring(0, epos);
                string ind_part = inputFile.Substring(epos + 1);

                //joinfiles.Insert(0,first_part);

                while (true)
                {
                    ind_part = FindNextAAA(ind_part);

                    bool found = false;

                    for (int k = 0; k < filez.Length; k++)
                    {
                        if (filez[k].ToLower() == first_part + "." + ind_part)
                        {
                            joinfiles.Add(filez[k]);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        break;
                    }
                }
            }
            else if (rex5.IsMatch(inputFile))
            {
                Match ma = rex5.Match(inputFile);

                int epos = ma.Index;

                string first_part = inputFile.Substring(0, epos);
                string ind_part = inputFile.Substring(epos + 1);

                //joinfiles.Insert(0,first_part);

                while (true)
                {
                    ind_part = FindNextA(ind_part);

                    bool found = false;

                    for (int k = 0; k < filez.Length; k++)
                    {
                        if (filez[k].ToLower() == first_part + "." + ind_part)
                        {
                            joinfiles.Add(filez[k]);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        break;
                    }
                }
            }

            return joinfiles;
        }

        private static string FindNextAAA(string ind_part)
        {
            int m = 0;
            if (ind_part[0] == '_' && ind_part[1]!='z')
            {
                m++;
            }

            if (ind_part[1] == '_' && ind_part[2]!='z')
            {
                m++;
            }

            if (ind_part[m] != 'z')
            {
                if (ind_part[m] == '_')
                {
                    if (m == 0)
                    {
                        return "a" + ind_part[1].ToString() + ind_part[2].ToString();
                    }
                    else if (m == 1)
                    {
                        return ind_part[0].ToString() + "a" + ind_part[2].ToString();
                    }
                    else if (m == 2)
                    {
                        return ind_part[0].ToString() + ind_part[1].ToString() + "a";
                    }
                }
                else
                {
                    int ica = (int)ind_part[m];
                    ica++;
                    char ics = (char)ica;

                    if (m == 0)
                    {
                        return ics.ToString() + ind_part[1].ToString() + ind_part[2].ToString();
                    }
                    else if (m == 1)
                    {
                        return ind_part[0].ToString() + ics.ToString() + ind_part[2].ToString();
                    }
                    else if (m == 2)
                    {
                        return ind_part[0].ToString() + ind_part[1].ToString() + ics.ToString();
                    }
                }
            }

            return ind_part;
        }

        private static string FindNextA(string ind_part)
        {
            if (ind_part[0] == 'z')
            {
                return "a" + ind_part;
            }
            else
            {
                int ica = (int)ind_part[0];
                ica++;
                char ics = (char)ica;

                if (ind_part.Length == 1)
                {
                    return ics.ToString();
                }
                else
                {
                    return ics.ToString() + ind_part.Substring(1);
                }
            }

        }

        public static void JoinFiles(List<string> files, bool files_explicit, string output_file, bool delete_after_join, bool keep_timestamp,string password)
        {
            if (!files_explicit)
            {
                files = GetListOfParts(files[0]);
            }

            // first file in files list is the output file
            //string filepath = System.IO.Path.Combine(path, System.IO.Path.GetFileName(files[0]));

            string filepath = output_file;
            int BUFFER_SIZE = 20 * 1024;
            int BUFFER_SIZE_ENC = 20488;
            Password = password;

            JoinOutputFile = output_file;

            FileInfo fifirst = new FileInfo(files[0]);
            int filen = (int)(fifirst.Length/BUFFER_SIZE);
            
            DateTime dtcreated = fifirst.CreationTime;
            DateTime dtupdated = fifirst.LastWriteTime;

            for (int k = 1; k < files.Count; k++)
            {
                FileInfo fik = new FileInfo(files[k]);
                filen += (int)(fik.Length / BUFFER_SIZE);
            }

            byte[] buffer = new byte[BUFFER_SIZE];
            byte[] bufenc = new byte[BUFFER_SIZE_ENC];

            frmMain.Instance.bwJoin.ReportProgress(0, filen);
            int chunkcnt = 0;
            int current_chunk_sum = 0;


            if (!ArgsHelper.Overwrite && System.IO.File.Exists(filepath))
            {
                frmOverwrite fo = new frmOverwrite(filepath);
                fo.ShowDialog();

                if (fo.OverwriteOption == OverwriteOption.Skip)
                {
                    frmMain.Instance.bwJoin.CancelAsync();
                    return;
                }
                else if (fo.OverwriteOption == OverwriteOption.Rename)
                {
                    filepath = fo.OverNewFilepath;
                    JoinOutputFile = filepath;
                }
            }

            using (Stream output = File.Create(filepath))
            {
                for (int k = 0; k < files.Count; k++)
                {
                    if (frmMain.Instance.bwJoin.CancellationPending)
                    {
                        return;
                    }

                    int bytesRead = 0;

                    bool checked_gzip = false;
                    bool is_gzip = false;
                    bool is_encrypted = false;
                    bool read_first_5_bytes = false;

                    byte[] encrypted_contents = null;
                    byte[] decrypted_contents = null;

                    using (Stream input = File.OpenRead(files[k]))
                    {
                        if (input.Length >= 5)
                        {
                            byte[] bufferenc = new byte[5];
                            bytesRead = input.Read(bufferenc, 0, 5);

                            if (bytesRead == 5)
                            {
                                is_encrypted = true;

                                for (int m = 0; m < bufferenc.Length; m++)
                                {
                                    if (bufferenc[m] != 120 + m)
                                    {
                                        is_encrypted = false;
                                    }
                                }

                                if (is_encrypted && Password==String.Empty)
                                {
                                    frmEncryptionPassword fe = new frmEncryptionPassword();

                                    if (fe.ShowDialog() == DialogResult.OK)
                                    {
                                        Password = fe.txtPassword.Text;
                                    }
                                }
                                
                            }

                            if (is_encrypted)
                            {
                                encrypted_contents = new byte[(int)input.Length - 5];
                                input.Read(encrypted_contents, 0,(int)input.Length - 5);
                                decrypted_contents = EncryptHelper.DecryptBytes(encrypted_contents, Password);
                            }                                                       
                        }
                    }

                    if (is_encrypted)
                    {
                        using (Stream outpute = File.Create(files[k]))
                        {
                            outpute.Write(decrypted_contents, 0, decrypted_contents.Length);
                        }
                    }
                    
                    using (Stream input = File.OpenRead(files[k]))
                    {
                        byte[] bufferzip = new byte[3];
                        bytesRead = input.Read(bufferzip, 0, 3);

                        checked_gzip = true;

                        if (bytesRead >= 3)
                        {
                            byte[] sig = new byte[3];
                            sig[0] = bufferzip[0];
                            sig[1] = bufferzip[1];
                            sig[2] = bufferzip[2];

                            if (BitConverter.ToString(sig) == "1F-8B-08")
                            {
                                is_gzip = true;
                            }
                        }
                    }

                    using (Stream input = File.OpenRead(files[k]))
                    {

                        int chunknum =(int)(input.Length / BUFFER_SIZE);

                        using (GZipStream gzipstream = new GZipStream(input, CompressionMode.Decompress, false))
                        {
                            bytesRead = 1;

                        while (bytesRead>0)
                        {
                            if (frmMain.Instance.bwJoin.CancellationPending)
                            {
                                return;
                            }
                          
                            if (!is_gzip)
                            {
                                bytesRead = input.Read(buffer, 0, BUFFER_SIZE);
                            }
                            else
                            {
                                bytesRead = gzipstream.Read(buffer, 0, BUFFER_SIZE);
                            }
                                                                                   

                            /*
                                    if (encrypt)
                                    {
                                        buffer = EncryptHelper.DecryptBytes(buffer, encryption_password);
                                    }
                            */

                            if (bytesRead > 0)
                            {
                                output.Write(buffer, 0, bytesRead);

                                int chunkf = (int)(input.Position / BUFFER_SIZE);

                                frmMain.Instance.bwJoin.ReportProgress(0, current_chunk_sum + chunkf);
                            }

                            
                        }

                        }

                        current_chunk_sum += chunknum;
                    }

                    
                    if (delete_after_join)
                    {
                        System.IO.File.Delete(files[k]);
                    }

                  

                }
            }

            if (keep_timestamp)
            {
                FileInfo fi = new FileInfo(output_file);
                fi.CreationTime = dtcreated;
                fi.LastWriteTime = dtupdated;
            }


        }

        static byte[] Decompress(byte[] gzip)
        {
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }
    }
}
