using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplitByte
{
    public partial class frmShutdown : SplitByte.CustomForm
    {
        public frmShutdown()
        {
            InitializeComponent();
        }

        private int Seconds = 30;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Seconds--;
            if (Seconds == 0)
            {
                System.Diagnostics.Process.Start("shutdown.exe", " -s -t 01");
            }

            lblSeconds.Text = Seconds.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            this.DialogResult = DialogResult.Cancel;
        }
    }
}

