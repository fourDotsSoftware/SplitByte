using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplitByte
{
    public enum OverwriteOption
    {
        Overwrite,
        Rename,
        Skip,
        Ask
    }

    public partial class frmOverwrite : SplitByte.CustomForm
    {
        public OverwriteOption OverwriteOption = OverwriteOption.Overwrite;

        public static OverwriteOption DefaultOverwriteOption = OverwriteOption.Ask;

        public string OverNewFilepath = "";

        public frmOverwrite(string filepath)
        {
            InitializeComponent();

            lblFile.Text = filepath;
        }

        private void frmOverwrite_Load(object sender, EventArgs e)
        {

        }

        private void btnOverwrite_Click(object sender, EventArgs e)
        {
            OverwriteOption = OverwriteOption.Overwrite;

            if (chkDoForAll.Checked)
            {
                DefaultOverwriteOption = OverwriteOption.Overwrite;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            frmOverwriteNewFilename f = new frmOverwriteNewFilename(lblFile.Text);
            if (f.ShowDialog() == DialogResult.OK)
            {
                OverwriteOption = OverwriteOption.Rename;
                OverNewFilepath = f.txtNewFilename.Text;

                if (chkDoForAll.Checked)
                {
                    DefaultOverwriteOption = OverwriteOption.Rename;
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            OverwriteOption = OverwriteOption.Skip;

            if (chkDoForAll.Checked)
            {
                DefaultOverwriteOption = OverwriteOption.Skip;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}

