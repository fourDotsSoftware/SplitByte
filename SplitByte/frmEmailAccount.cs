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
    public partial class frmEmailAccount : SplitByte.CustomForm
    {
        public frmEmailAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text.Trim() == String.Empty)
            {
                Module.ShowMessage("Please specify an Account Name !");
                return;
            }

            if (txtServer.Text.Trim() == String.Empty)
            {
                Module.ShowMessage("Please specify an Outgoing Server !");
                return;
            }

            if (txtAddress.Text.Trim() == String.Empty)
            {
                Module.ShowMessage("Please specify an Email Address !");
                return;
            }

            if (txtPort.Text.Trim() == String.Empty)
            {
                Module.ShowMessage("Please specify a Port Number !");
                return;
            }

            int port;
            try
            {
                port=int.Parse(txtPort.Text);
            }
            catch
            {
                Module.ShowMessage("Please specify a valid Server Port !");
                return;
            }

            int interv;

            if (!int.TryParse(txtInterval.Text, out interv))
            {
                Module.ShowMessage("Please specify an Interval in Seconds between Emails");
                return;
            }
            if (txtUsername.Text.Trim() == String.Empty)
            {
                Module.ShowMessage("Please specify a Username !");
                return;
            }

            if (txtPassword.Text.Trim() == String.Empty)
            {
                Module.ShowMessage("Please specify a Password !");
                return;
            }

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\4dots Software\Split Byte\Email Accounts",true);

            if (key == null)
            {
                Module.ShowMessage("Error could not write to Registry !");
                return;
            }

            string[] sub=key.GetSubKeyNames();

            int iv = sub.Length + 1;

            RegistryKey key2=key.CreateSubKey("Account #" + iv.ToString());
            key2.SetValue("Account Name", txtAccountName.Text);
            key2.SetValue("Server", txtServer.Text);
            key2.SetValue("Port", txtPort.Text);
            key2.SetValue("Interval", txtInterval.Text);
            key2.SetValue("SSL", chkSSL.Checked.ToString());
            key2.SetValue("Email", txtAddress.Text);
            key2.SetValue("Username", txtUsername.Text);
            key2.SetValue("Password", EncryptHelper.EncryptString(txtPassword.Text,"hellooo"));

            key.Close();
            key2.Close();

            this.DialogResult = DialogResult.OK;
        }

    }
}

