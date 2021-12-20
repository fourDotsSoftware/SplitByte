using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SplitByte
{ 
    class ArgsHelper
    {
        public static bool FromWindowsExplorer = false;

        public static bool IsCommandLine()
        {
            if (Module.args == null || Module.args.Length == 0)
            {
                return false;
            }

            // new
                if (Module.args!=null && Module.args.Length>0 && ((Module.args.Length > 1 && Module.args[1].ToLower().Trim().Contains("-tempfile:"))
                    || (System.IO.File.Exists(Module.args[0]) || System.IO.Directory.Exists(Module.args[0]))))
            {                
                return false;
            }

            if (Module.args[0].ToLower().Trim() == "-extjoin")
            {
                Module.IsExtensionJoin = true;
                return false;
            }

            Module.IsCommandLine = true;
            return true;
        }


        public static bool ExamineArgs(string[] args)
        {
            if (args.Length == 0) return true;

            //MessageBox.Show(args[0]);
            //MessageBox.Show(args[1]);

            try
            {
                if (args.Length > 1)
                {
                    if (args[1].ToLower().StartsWith("-tempfile:"))
                    {
                        if (args[0].Trim().ToLower() == "-join")
                        {
                            ArgsHelper.Join = true;
                        }
                        else if (args[0].Trim().ToLower() == "-split")
                        {
                            ArgsHelper.Split = true;
                        }

                        FromWindowsExplorer = true;

                        string tempfile = GetParameter(args[1]);

                        //MessageBox.Show(tempfile);

                        using (StreamReader sr = new StreamReader(tempfile, Encoding.Unicode))
                        {
                            string scont = sr.ReadToEnd();

                            //args = scont.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                            args = SplitArguments(scont);
                            Module.args = args;
                            //MessageBox.Show("EXARGS IN LOOP"+scont);

                            return true;
                            
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Module.ShowError("Error could not parse Arguments !", ex);
                return false;
            }

            frmMain.Instance = new frmMain();

            try
            {
                //string commandline = "";

                //for (int k = 0; k < Module.args.Length; k++)
                //{
                //    commandline += Module.args[k] + " ";
                //}


                //Module.args = SplitArguments(commandline);

                for (int k = 0; k < Module.args.Length; k++)
                {
                    if (!Module.FilePathIsValid(Module.args[0], false))
                    {
                        Module.ShowMessage("Please specify a valid split and join file !");
                        return false;
                    }
                    else
                    {
                        SplitJoinFile = Module.args[0];
                    }

                    string argv = Module.args[k].ToLower().Trim();

                    if (Module.args[k].ToLower().Trim() == "/split" || Module.args[k].ToLower().Trim() == "-split" 
                        || Module.args[k].ToLower().Trim() == "-s" || Module.args[k].ToLower().Trim() == "/s")
                    {
                        Split = true;
                    }
                    else if (Module.args[k].ToLower().Trim() == "/join" || Module.args[k].ToLower().Trim() == "-join"
                        || Module.args[k].ToLower().Trim() == "-j" || Module.args[k].ToLower().Trim() == "/j")
                    {
                        Join = true;
                    }
                    else if (argv == "/compress" || argv == "-compress")
                    {
                        Compress = true;
                    }
                    else if (argv == "/keep_timestamp" || argv == "-keep_timestamp")
                    {
                        KeepTimestamp = true;
                    }
                    else if (argv == "/encrypt" || argv == "-encrypt")
                    {
                        Encrypt = true;
                        EncryptionPassword = Module.args[k + 1];
                        k++;
                    }
                    else if (argv == "/decrypt" || argv == "-decrypt")
                    {                        
                        EncryptionPassword = Module.args[k + 1];
                        k++;
                    }
                    else if (argv == "/delete" || argv == "-delete")
                    {
                        Delete = true;
                    }
                    else if (argv == "/splitsize" || argv == "-splitsize")
                    {
                        Splitsize = long.Parse(Module.args[k + 1]);
                        k++;
                    }
                    else if (argv == "/splitsizekb" || argv == "-splitsizekb")
                    {
                        Splitsize = long.Parse(Module.args[k + 1]) * 1024;
                        k++;
                    }
                    else if (argv == "/splitsizemb" || argv == "-splitsizemb")
                    {
                        Splitsize = long.Parse(Module.args[k + 1]) * 1024 * 1024;
                        k++;
                    }
                    else if (argv == "/splitsizegb" || argv == "-splitsizegb")
                    {
                        Splitsize = long.Parse(Module.args[k + 1]) * 1024 * 1024 * 1024;
                        k++;
                    }
                    else if (argv == "/splitnum" || argv == "-splitnum")
                    {
                        SplitNum = int.Parse(Module.args[k + 1]);
                        k++;
                    }
                    else if (argv == "/split_filename_pattern" || argv == "-split_filename_pattern")
                    {
                        SplitFilenamePattern = int.Parse(Module.args[k + 1]);
                        k++;
                    }
                    else if (argv == "/delete" || argv == "-delete")
                    {
                        Delete = true;
                    }
                    else if (argv == "/delete" || argv == "-delete")
                    {
                        Delete = true;
                    }
                    else if (argv == "/overwrite" || argv == "-overwrite")
                    {
                        Overwrite = true;
                    }
                    else if (Module.args[k].ToLower().Trim() == "/outfolder" || Module.args[k].ToLower().Trim() == "-outfolder")
                    {
                        OutputFolder  = Module.args[k + 1];
                        k++;
                    }
                    else if (Module.args[k].ToLower().Trim() == "/outfile" || Module.args[k].ToLower().Trim() == "-outfile")
                    {
                        OutputFilename = Module.args[k + 1];
                        k++;
                    }
                    else if (Module.args[k] == "/?" || Module.args[k] == "-?")
                    {
                        ShowCommandUsage();
                        return false;
                    }
                    else if (Module.args[k] == "/test")
                    {
                        List<string> files=new List<string>();
                        //files.Add(@"h:\a.bak");
                        //files.Add(@"h:\b.bak");

                        //JoinHelper.JoinFiles(files,true,@"h:\c.bak",false,false,"");

                        for (int m = 0; m < 100; m++)
                        {
                            files.Clear();
                            files.Add(@"h:\allc.bak");
                            files.Add(@"h:\all.bak");

                            JoinHelper.JoinFiles(files, true, @"h:\alld.bak", false, false, "");

                            //files.Clear();
                            //files.Add(@"h:\b.bak");
                            //files.Add(@"h:\allb.bak");

                            //JoinHelper.JoinFiles(files, true, @"h:\all.bak", false, false, "");

                        }
                        return false;
                    }
                }

                if (Split && !System.IO.File.Exists(SplitJoinFile))
                {
                    Module.ShowMessage("Please specify an existing File to Split !");
                    return false;
                }

                if (Split && OutputFolder == String.Empty)
                {
                    OutputFolder = System.IO.Path.GetDirectoryName(args[0]);

                    //Module.ShowMessage("Please specify a split parts output folder !");
                    //return false;
                }

                if (Join && OutputFilename == String.Empty)
                {                    
                    int epos = args[0].LastIndexOf(".");

                    if (epos > 0)
                    {
                        OutputFilename = args[0].Substring(0, epos);
                    }
                    else
                    {
                        Module.ShowMessage("Please specify a Join Output Filename !");
                        return false;
                    }
                }

                if (Split && (Splitsize == 0 && SplitNum == 0))
                {
                    Module.ShowMessage("Please specify a desired file size of the split parts, or the number of parts the file should be splitted.\n");
                    return false;
                }

                if (!Split && !Join)
                {
                    Module.ShowMessage("Please specify whether to split or join the file !");
                    return false;
                }

                SplitJoinFile = System.IO.Path.GetFullPath(SplitJoinFile);
                if (OutputFilename != String.Empty)
                {
                    OutputFilename = System.IO.Path.GetFullPath(OutputFilename);
                }

                if (OutputFolder != String.Empty)
                {
                    OutputFolder = System.IO.Path.GetFullPath(OutputFolder);
                }

            }
            catch (Exception ex)
            {
                Module.ShowError("Error could not parse Arguments !", ex);
                return false;
            }

            
            return true;
        }

        public static bool Split = false;
        public static bool Join = false;
        public static long Splitsize = 0;
        public static int SplitNum = 0;
        public static string OutputFolder = "";
        public static string OutputFilename = "";
        public static bool Compress = false;
        public static bool Encrypt = false;
        public static string EncryptionPassword = "";
        public static bool Delete = false;
        public static bool KeepTimestamp = false;
        public static int SplitFilenamePattern = 0;
        public static string SplitJoinFile = "";
        public static bool Overwrite = false;

        public static bool ExecuteCommandLine()
        {
            if (Split)
            {
                try
                {
                DateTime split_dtcreated=DateTime.Now;
                DateTime split_dtupdated=DateTime.Now;

                if (KeepTimestamp)
                {
                System.IO.FileInfo fi = new System.IO.FileInfo(SplitJoinFile);
                split_dtcreated = fi.CreationTime;
                split_dtupdated = fi.LastWriteTime;
                }
                    
                
                    SplitHelper.SplitFile(SplitJoinFile, Splitsize, (Splitsize == 0), SplitNum, OutputFolder,
                        SplitFilenamePattern, Delete, KeepTimestamp, split_dtcreated, split_dtupdated, Compress, Encrypt, EncryptionPassword);

                }
                catch (Exception ex)
                {
                    Module.ShowError(ex);
                    return false;
                }

                //Module.ShowMessage("Operation completed successfully !");
                
            }
            else if (Join)
            {
                try
                {
                    List<string> join_files = new List<string>();
                    join_files.Add(SplitJoinFile);
                    //Module.ShowMessage(join_files[0]);
                    //Module.ShowMessage("OUPTUT:" + OutputFilename);

                    JoinHelper.JoinFiles(join_files, false, OutputFilename, Delete, KeepTimestamp,EncryptionPassword);
                }
                catch (Exception ex)
                {
                    Module.ShowError(ex.ToString());
                    return false;
                }

                //Module.ShowMessage("Operation completed successfully !");
            }

            return true;
        }

        private static string GetParameter(string arg)
        {
            int spos = arg.IndexOf(":");
            if (spos == arg.Length - 1) return "";
            else
            {
                string str=arg.Substring(spos + 1);

                if ((str.StartsWith("\"") && str.EndsWith("\"")) ||
                    (str.StartsWith("'") && str.EndsWith("'")))
                {
                    if (str.Length > 2)
                    {
                        str = str.Substring(1, str.Length - 2);
                    }
                    else
                    {
                        str = "";
                    }
                }

                return str;
            }
        }

        public static string[] SplitArguments(string commandLine)
        {
            char[] parmChars = commandLine.ToCharArray();
            bool inSingleQuote = false;
            bool inDoubleQuote = false;
            for (int index = 0; index < parmChars.Length; index++)
            {
                if (parmChars[index] == '"' && !inSingleQuote)
                {
                    inDoubleQuote = !inDoubleQuote;
                    parmChars[index] = '\n';
                }
                if (parmChars[index] == '\'' && !inDoubleQuote)
                {
                    inSingleQuote = !inSingleQuote;
                    parmChars[index] = '\n';
                }
                if (!inSingleQuote && !inDoubleQuote && parmChars[index] == ' ')
                    parmChars[index] = '\n';
            }
            return (new string(parmChars)).Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        public static void ShowCommandUsage()
        {
            string msg = GetCommandUsage();
                
            Module.ShowMessage(msg);

            Environment.Exit(0);
        }
        public static string GetCommandUsage()
        {
            string msg = "SplitByte - Split and Join Files.\n\n" +
            "e.g. For Splitting : SplitByte.exe c:\\test\\document.txt /s /splitnum 3\n"+
            "     For Joining : SplitByte.exe c:\\test\\document.txt.part0 /j \n\n"+
            "SplitByte.exe FILE\n" +
            "[/split] \n" +
            "[/join]\n" +
            "[/splitsize SIZE_IN_BYTES],[/splitsizekb SIZE_IN_KBYTES],[/splitsizemb SIZE_IN_MBYTES],[/splitsizegb SIZE_IN_GBYTES]\n" +
            "[/splitnum NUMBER_OF_EQUAL_SPLIT_PARTS] \n" +
            "[outfolder OUTPUT_FOLDER_VALUE] \n" +
            "[outfile OUTPUT_FILE_VALUE] \n" +
            "[/compress]\n" +
            "[/encrypt ENCRYPTION_PASSWORD]\n" +
            "[/decrypt ENCRYPTION_PASSWORD]\n" +
            "[/delete]\n" +
            "[/overwrite]\n"+
            "[/keep_timestamp]\n" +
            "[/split_filename_pattern SPLIT_FILENAME_PATTERN_ID]\n" +
            "[/?]\n\n\n" +
            "FILE : the file to split or the first split part file to join.\n" +
            "/split or /s : split file\n" +
            "/join or /j : join files\n" +
            "/splitsize : the desired split part size in bytes, /splitsizekb : the desired split part size in kilobytes, /splitsizemb : the desired split part size in megabytes, /splitsizegb : the desired split part size in gigabytes\n" +
            "/splitnum : split the file in specified number of equal size parts\n" +
            "/outfolder : output folder of split parts\n" +
            "/outfile : output file of join\n" +
            "/compress : compress split parts\n" +
            "/encrypt : encrypt split parts with password\n" +
            "/decrypt : decrypt split parts with password\n" +
            "/delete : delete source file(s)\n" +
            "/overwrite : overwrite output files, if necessary\n"+
            "/keep_timestamp : keep the same timestamp as the source files\n" +
            "/split_filename_pattern : 0 for .part[d],1 for .[d],2 for .[ddd],3 for .part[a],4 for .[a],5 for .[aaa]\n"+
            "/? : show help\n";

            return msg;
        }
              

        
                
                
    }

    public class ReadListsResult
    {
        public bool Success = true;
        public string err = "";
    }
}
