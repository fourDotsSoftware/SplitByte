namespace SplitByte
{
    partial class frmSpecifyFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecifyFiles));
            this.txtSpecificFiles = new System.Windows.Forms.RichTextBox();
            this.label1 = new SplitByte.LabelToolTip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnJoinFirstPartBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSpecificFiles
            // 
            resources.ApplyResources(this.txtSpecificFiles, "txtSpecificFiles");
            this.txtSpecificFiles.Name = "txtSpecificFiles";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Name = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnJoinFirstPartBrowse
            // 
            resources.ApplyResources(this.btnJoinFirstPartBrowse, "btnJoinFirstPartBrowse");
            this.btnJoinFirstPartBrowse.Image = global::SplitByte.Properties.Resources.view;
            this.btnJoinFirstPartBrowse.Name = "btnJoinFirstPartBrowse";
            this.btnJoinFirstPartBrowse.UseVisualStyleBackColor = true;
            this.btnJoinFirstPartBrowse.Click += new System.EventHandler(this.btnJoinFirstPartBrowse_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Image = global::SplitByte.Properties.Resources.exit;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK2
            // 
            resources.ApplyResources(this.btnOK2, "btnOK2");
            this.btnOK2.Image = global::SplitByte.Properties.Resources.check;
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.UseVisualStyleBackColor = true;
            this.btnOK2.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSpecifyFiles
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.btnJoinFirstPartBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpecificFiles);
            this.Name = "frmSpecifyFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelToolTip label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnJoinFirstPartBrowse;
        public System.Windows.Forms.RichTextBox txtSpecificFiles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK2;
    }
}
