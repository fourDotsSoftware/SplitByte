namespace SplitByte
{
    partial class frmOverwrite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOverwrite));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new SplitByte.LabelToolTip();
            this.lblFile = new SplitByte.LabelToolTip();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnOverwrite = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.chkDoForAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SplitByte.Properties.Resources.information1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Name = "label1";
            // 
            // lblFile
            // 
            resources.ApplyResources(this.lblFile, "lblFile");
            this.lblFile.BackColor = System.Drawing.Color.Transparent;
            this.lblFile.Name = "lblFile";
            // 
            // btnRename
            // 
            resources.ApplyResources(this.btnRename, "btnRename");
            this.btnRename.Image = global::SplitByte.Properties.Resources.bullet_ball_glass_blue;
            this.btnRename.Name = "btnRename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnOverwrite
            // 
            resources.ApplyResources(this.btnOverwrite, "btnOverwrite");
            this.btnOverwrite.Image = global::SplitByte.Properties.Resources.bullet_ball_glass_red;
            this.btnOverwrite.Name = "btnOverwrite";
            this.btnOverwrite.UseVisualStyleBackColor = true;
            this.btnOverwrite.Click += new System.EventHandler(this.btnOverwrite_Click);
            // 
            // btnSkip
            // 
            resources.ApplyResources(this.btnSkip, "btnSkip");
            this.btnSkip.Image = global::SplitByte.Properties.Resources.delete;
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // chkDoForAll
            // 
            resources.ApplyResources(this.chkDoForAll, "chkDoForAll");
            this.chkDoForAll.BackColor = System.Drawing.Color.Transparent;
            this.chkDoForAll.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkDoForAll.Name = "chkDoForAll";
            this.chkDoForAll.UseVisualStyleBackColor = false;
            // 
            // frmOverwrite
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.chkDoForAll);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnOverwrite);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOverwrite";
            this.Load += new System.EventHandler(this.frmOverwrite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private LabelToolTip label1;
        private LabelToolTip lblFile;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnOverwrite;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.CheckBox chkDoForAll;
    }
}
