using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplitByte
{
    public partial class frmOverwriteNewFilename : SplitByte.CustomForm
    {
        public frmOverwriteNewFilename(string oldfilepath)
        {
            InitializeComponent();
            lblOldFilename.Text = oldfilepath;
            txtNewFilename.Text = oldfilepath;
        }


        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if (txtNewFilename.Text == String.Empty)
            {
                openFileDialog1.FileName = lblOldFilename.Text;
            }
            else
            {
                try
                {
                    openFileDialog1.FileName = txtNewFilename.Text;
                }
                catch
                {
                    openFileDialog1.FileName = lblOldFilename.Text;
                }
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNewFilename.Text = openFileDialog1.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Module.FilePathIsValid(txtNewFilename.Text,false))
            {
                Module.ShowMessage("Please insert a valid New File Path !");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmOverwriteNewFilename_Load(object sender, EventArgs e)
        {

        }
    }
}

