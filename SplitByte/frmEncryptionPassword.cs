using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplitByte
{
    public partial class frmEncryptionPassword : SplitByte.CustomForm
    {
        public frmEncryptionPassword()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == String.Empty)
            {
                Module.ShowMessage("Please insert an Encryption Password !");
                return;
            }
            
            this.DialogResult = DialogResult.OK;

        }
    }
}

