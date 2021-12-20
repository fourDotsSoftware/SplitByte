using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using Microsoft.Win32;

namespace SplitByte
{
    public partial class frmDownloadUpdate : SplitByte.CustomForm
    {
        private string _DownloadFile = "";

        public string DownloadFile
        {
            get
            {
                if (_DownloadFile == string.Empty)
                {
                    int spos = DownloadURL.LastIndexOf("/");
                    string file = DownloadURL.Substring(spos + 1);

                    string tempdir = System.IO.Path.GetTempFileName() + "setup";

                    System.IO.Directory.CreateDirectory(tempdir);

                    _DownloadFile =System.IO.Path.Combine(tempdir, file);
                }
                                
                return _DownloadFile;
                
            }
        }
        public string DownloadURL
        {
            get
            {
                return GetEXEDownloadURL();
            }
        }

        public WebClient client = null;
        public bool Cancelled = false;

        public frmDownloadUpdate()
        {
            InitializeComponent();
            
            pgBar.Value = 0;
            pgBar.Maximum = 100;
        }

        private void frmDownloadUpdate_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(DownloadFile))
            {
                System.IO.File.Delete(DownloadFile);
            }

            bool autodetect = true;
            string host = "";
            int port = -1;

            try
            {
                using (RegistryKey key4dots = Registry.LocalMachine.OpenSubKey("Software\\4dots Software"))
                {
                    if (key4dots != null)
                    {
                        object o = key4dots.GetValue("ProxyHost");

                        if (o != null)
                        {
                            host = o.ToString();
                        }

                        o = key4dots.GetValue("ProxyAutodetect");

                        if (o != null)
                        {
                            autodetect = bool.Parse(o.ToString());
                        }

                        o = key4dots.GetValue("ProxyPort");

                        if (o != null)
                        {
                            port = int.Parse(o.ToString());
                        }
                    }
                }
            }
            catch { }

            client = new WebClient();

            if (autodetect)
            {
                client.Proxy = System.Net.WebRequest.GetSystemWebProxy();
            }
            else
            {
                client.Proxy = new System.Net.WebProxy(host, port);
            }

            client.UseDefaultCredentials = true;
            client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            
            client.DownloadProgressChanged +=client_DownloadProgressChanged;
            client.DownloadFileCompleted +=client_DownloadFileCompleted;

            string sDownloadURL = "http://www.4dots-software.com/aetup.exe";

            client.DownloadFileAsync(new Uri(sDownloadURL), DownloadFile);
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!Cancelled)
            {                
                try
                {
                    if (!System.IO.File.Exists(DownloadFile))
                    {
                        DialogResult dres=Module.ShowQuestionDialogYesFocus(TranslateHelper.Translate("Error. Setup File was not downloaded correctly !") + "\n\n" + TranslateHelper.Translate("Would you like to download it directly from your Webbrowser ?"), TranslateHelper.Translate("Download from Webbrowser ?"));

                        if (dres == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(Module.DownloadURL);
                        }
                        
                        this.Close();
                        return;
                    }
                    else
                    {
                        System.IO.FileInfo fi = new System.IO.FileInfo(DownloadFile);

                        if (fi.Length == 0)
                        {
                            DialogResult dres = Module.ShowQuestionDialogYesFocus(TranslateHelper.Translate("Error. Setup File was not downloaded correctly !") + "\n\n" + TranslateHelper.Translate("Would you like to download it directly from your Webbrowser ?"), TranslateHelper.Translate("Download from Webbrowser ?"));

                            if (dres == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start(Module.DownloadURL);
                            }

                            this.Close();
                            return;
                        }
                        else
                        {
                            System.Diagnostics.Process.Start(DownloadFile);
                        }
                    }

                    Module.ShowMessage("The application will now exit and run the updated setup file");

                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    Module.ShowError("Error. Could not run new Setup File !", ex);

                    this.DialogResult = DialogResult.Cancel;

                    Environment.Exit(0);
                }
            }
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pgBar.Value = e.ProgressPercentage;
            pgBar.SetText(e.ProgressPercentage.ToString() + " %");
            
            decimal ukb=(decimal)e.TotalBytesToReceive/(decimal)1024;
            decimal umb=ukb/(decimal)1024;

            lblTotalSize.Text = umb.ToString("#0.0") + " MB";
        }

        public string GetEXEDownloadURL()
        {
            string durl = Module.DownloadURL;

            if (!durl.ToLower().EndsWith(".exe"))
            {
                if (durl.EndsWith("/"))
                {
                    durl = durl.Substring(0, durl.Length - 1);
                }
                int spos = durl.LastIndexOf("/", durl.Length - 1);

                string program = durl.Substring(spos + 1);

                return "http://www.4dots-software.com/downloads/" + program + "Setup.exe";
            }
            else
            {
                return durl;
            }
        }

        private void btnCancelDownload_Click(object sender, EventArgs e)
        {
            Cancelled = true;

            client.CancelAsync();

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
