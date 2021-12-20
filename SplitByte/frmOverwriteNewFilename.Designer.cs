namespace SplitByte
{
    partial class frmOverwriteNewFilename
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOverwriteNewFilename));
            this.label1 = new SplitByte.LabelToolTip();
            this.lblOldFilename = new SplitByte.LabelToolTip();
            this.label2 = new SplitByte.LabelToolTip();
            this.txtNewFilename = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Name = "label1";
            // 
            // lblOldFilename
            // 
            resources.ApplyResources(this.lblOldFilename, "lblOldFilename");
            this.lblOldFilename.BackColor = System.Drawing.Color.Transparent;
            this.lblOldFilename.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOldFilename.Name = "lblOldFilename";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Name = "label2";
            // 
            // txtNewFilename
            // 
            resources.ApplyResources(this.txtNewFilename, "txtNewFilename");
            this.txtNewFilename.Name = "txtNewFilename";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Image = global::SplitByte.Properties.Resources.view;
            resources.ApplyResources(this.btnBrowseFile, "btnBrowseFile");
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::SplitByte.Properties.Resources.exit;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::SplitByte.Properties.Resources.check;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmOverwriteNewFilename
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtNewFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOldFilename);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOverwriteNewFilename";
            this.Load += new System.EventHandler(this.frmOverwriteNewFilename_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelToolTip label1;
        private LabelToolTip lblOldFilename;
        private LabelToolTip label2;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox txtNewFilename;
    }
}
