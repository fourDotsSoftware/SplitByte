using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplitByte
{
    public partial class frmSpecifyFiles : SplitByte.CustomForm
    {
        public frmSpecifyFiles()
        {
            InitializeComponent();
        }

        private void btnJoinFirstPartBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int k = 0; k < openFileDialog1.FileNames.Length; k++)
                {
                    if (txtSpecificFiles.Text == String.Empty)
                    {
                        txtSpecificFiles.Text += openFileDialog1.FileNames[k];
                    }
                    else
                    {
                        txtSpecificFiles.Text += "\r\n" + openFileDialog1.FileNames[k];
                    }

                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSpecificFiles.Text == String.Empty)
            {
                Module.ShowMessage("Please specify Files to Join !");
                return;
            }

            for (int k = 0; k < txtSpecificFiles.Lines.Length; k++)
            {
                if (txtSpecificFiles.Lines[k].Trim() != String.Empty)
                {
                    if (!System.IO.File.Exists(txtSpecificFiles.Lines[k]))
                    {
                        Module.ShowMessage(TranslateHelper.Translate("File does not exist !") + " : " + txtSpecificFiles.Lines[k]);
                        return;
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}

