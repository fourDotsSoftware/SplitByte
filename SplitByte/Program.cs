using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace SplitByte
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();

        const int ATTACH_PARENT_PROCESS = -1;
        const int ERROR_ACCESS_DENIED = 5;

        [STAThread]
        static void Main(string[] args)
        {
            for (int k = 0; k < args.Length; k++)
            {
                //Module.ShowMessage(args[k]);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Module.Portable)
            {
                RegistryHelper.FixRegistry();
                frmLanguage.SetLanguages();
                frmLanguage.SetLanguage();
            }

            if (args.Length > 0 && args[0].StartsWith("/uninstall"))
            {
                Module.DeleteApplicationSettingsFile();
                /*
                frmUninstallQuestionnaire fq = new frmUninstallQuestionnaire();
                fq.ShowDialog();
                */

                System.Diagnostics.Process.Start("https://www.4dots-software.com/support/bugfeature.php?uninstall=true&app=" + System.Web.HttpUtility.UrlEncode(Module.ShortApplicationTitle));

                return;
                Environment.Exit(0);
            }

            ExceptionHandlersHelper.AddUnhandledExceptionHandlers();

            if (args.Length > 0)
            {
                //System.Threading.Thread.Sleep(2000);
            }            

            Module.args = args;
            
            if (ArgsHelper.IsCommandLine())
            {                
                try
                {
                    if (!AttachConsole(ATTACH_PARENT_PROCESS) && Marshal.GetLastWin32Error() == ERROR_ACCESS_DENIED)
                    {
                        AllocConsole();
                    }

                    if (ArgsHelper.ExamineArgs(Module.args))
                    {
                        ArgsHelper.ExecuteCommandLine();
                    }

                }
                finally
                {
                    Environment.Exit(0);
                }
            }
            else if (Module.args != null && Module.args.Length == 1 && System.IO.File.Exists(Module.args[0]))
            {
                Module.IsFromOpenWith = true;
            }
            else if (!Module.IsExtensionJoin)
            {
                ArgsHelper.ExamineArgs(args);
            }            

            if (frmMain.Instance == null)
            {
                Application.Run(new frmMain());
            }
            else
            {
                if (!frmMain.Instance.IsDisposed)
                {
                    Application.Run(frmMain.Instance);
                }
            }            

            Environment.Exit(0);
        }        
    }
}