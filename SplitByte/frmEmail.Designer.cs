namespace SplitByte
{
    partial class frmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmail));
            this.cmbAccountName = new System.Windows.Forms.ComboBox();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.label1 = new SplitByte.LabelToolTip();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label2 = new SplitByte.LabelToolTip();
            this.label3 = new SplitByte.LabelToolTip();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bwSend = new System.ComponentModel.BackgroundWorker();
            this.bwRefresh = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // cmbAccountName
            // 
            this.cmbAccountName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbAccountName, "cmbAccountName");
            this.cmbAccountName.FormattingEnabled = true;
            this.cmbAccountName.Name = "cmbAccountName";
            // 
            // btnNewAccount
            // 
            resources.ApplyResources(this.btnNewAccount, "btnNewAccount");
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Name = "label1";
            // 
            // cmbTo
            // 
            resources.ApplyResources(this.cmbTo, "cmbTo");
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Name = "cmbTo";
            // 
            // txtBody
            // 
            resources.ApplyResources(this.txtBody, "txtBody");
            this.txtBody.Name = "txtBody";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Name = "label3";
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
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // bwSend
            // 
            this.bwSend.WorkerReportsProgress = true;
            this.bwSend.WorkerSupportsCancellation = true;
            this.bwSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSend_DoWork);
            this.bwSend.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwSend_ProgressChanged);
            this.bwSend.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSend_RunWorkerCompleted);
            // 
            // bwRefresh
            // 
            this.bwRefresh.WorkerReportsProgress = true;
            this.bwRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRefresh_DoWork);
            this.bwRefresh.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwRefresh_ProgressChanged);
            // 
            // frmEmail
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.cmbAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmail";
            this.Load += new System.EventHandler(this.frmEmail_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmEmail_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAccountName;
        private System.Windows.Forms.Button btnNewAccount;
        private LabelToolTip label1;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.TextBox txtBody;
        private LabelToolTip label2;
        private LabelToolTip label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bwSend;
        private System.ComponentModel.BackgroundWorker bwRefresh;
    }
}
