using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SplitByte
{
    public partial class frmEmail : SplitByte.CustomForm
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            frmEmailAccount f = new frmEmailAccount();
            if (f.ShowDialog() == DialogResult.OK)
            {
                cmbAccountName.Items.Clear(); 
                ReadEmailAccounts();
                if (cmbAccountName.Items.Count > 0)
                {
                    cmbAccountName.SelectedIndex = cmbAccountName.Items.Count - 1;
                }

            }
        }

        private void ReadEmailAccounts()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\4dots Software\Split Byte\Email Accounts");

            if (key == null)
            {
                Module.ShowMessage("Error could not read from Registry !");
                return;
            }

            string[] sub=key.GetSubKeyNames();

            for (int k = 0; k < sub.Length; k++)
            {
                RegistryKey key2 = key.OpenSubKey(sub[k]);
                string an=key2.GetValue("Account Name").ToString();
                cmbAccountName.Items.Add(an);
                key2.Close();
            }
        }

        private void frmEmail_Load(object sender, EventArgs e)
        {
            RegistryHelper.FillComboBoxWithValues(ref cmbTo, "Email To");

            progressBar1.Maximum = SplitHelper.LastSplitFiles.Count;
            progressBar1.Value = 0;

        }

        int CurrentFile = 0;
        string err = "";

        private void bwSend_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> file = new List<string>();



            for (CurrentFile = 0; CurrentFile < SplitHelper.LastSplitFiles.Count; CurrentFile++)
            {
                if (bwSend.CancellationPending)
                {
                    err = "Cancel";
                    return;
                }

                file.Clear();
                file.Add(SplitHelper.LastSplitFiles[CurrentFile]);

                try
                {
                    MailHelper.SendEmail(from, to, body, TranslateHelper.Translate("File") + " : " + SplitHelper.LastSplitFiles[CurrentFile]
                    , server, username, password, port, ssl, false, file);

                    bwSend.ReportProgress(0);

                    System.Threading.Thread.Sleep(interval * 1000);
                }
                catch (Exception ex)
                {
                    err += ex.ToString();
                    return;
                }
            }
        }

        private void bwSend_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = CurrentFile;
            }
            catch { }
        }

        private void bwSend_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (err == String.Empty)
            {
                Module.ShowMessage("Emails were successfully sent !");
                return;
            }
            else if (err == "Cancel")
            {
                Module.ShowMessage("Submission was cancelled !");
                return;
            }
            else
            {
                Module.ShowError(err);
            }
        }

        private string to="";
        private string body="";
        private string from = "";
        private string server = "";
        private int port = 0;
        private string username = "";
        private string password = "";
        private bool ssl = false;
        private int interval = 1;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbAccountName.SelectedIndex<0)
            {
                Module.ShowMessage("Please specify an Email Account to use");
                return;
            }

            if (cmbTo.Text.Trim()==String.Empty)
            {
                Module.ShowMessage("Please specify a Recipient Email Address");
                return;
            }

            err = "";

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\4dots Software\Split Byte\Email Accounts");



            if (key == null)
            {
                Module.ShowMessage("Error could not read from Registry !");
                return;
            }

            string[] sub = key.GetSubKeyNames();

            RegistryKey key2 = key.OpenSubKey(sub[cmbAccountName.SelectedIndex]);
            server = key2.GetValue("Server").ToString();
            username = key2.GetValue("Username").ToString();
            password = EncryptHelper.DecryptString(key2.GetValue("Password").ToString(),"hellooo");
            from = key2.GetValue("Email").ToString();
            ssl = bool.Parse(key2.GetValue("SSL").ToString());
            port = int.Parse(key2.GetValue("Port").ToString());
            try
            {
                interval = int.Parse(key2.GetValue("Interval").ToString());
            }
            catch
            {
                interval = 1;
            }

            to=cmbTo.Text;
            body=txtBody.Text;

            key.Close();
            key2.Close();

            bwSend.RunWorkerAsync();
            System.Threading.Thread.Sleep(300);
            bwRefresh.RunWorkerAsync();
            
        }

        private void bwRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            while (bwSend.IsBusy)
            {
                bwRefresh.ReportProgress(0);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void bwRefresh_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Application.DoEvents();
        }

        private void frmEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                try
                {
                    bwSend.CancelAsync();
                }
                catch { }
            }
        }
    }
}

