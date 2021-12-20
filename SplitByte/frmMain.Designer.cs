namespace SplitByte
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudEqualParts = new System.Windows.Forms.NumericUpDown();
            this.chkSplitSize = new SplitByte.RadioButtonToolTip();
            this.chkSpitNumberParts = new SplitByte.RadioButtonToolTip();
            this.label4 = new SplitByte.LabelToolTip();
            this.label9 = new SplitByte.LabelToolTip();
            this.cmbSplitFnPattern = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbSplitSizeType = new System.Windows.Forms.ComboBox();
            this.cmbSplitInputFile = new System.Windows.Forms.ComboBox();
            this.cmbSplitSize = new System.Windows.Forms.ComboBox();
            this.cmbSplitOutputFolder = new System.Windows.Forms.ComboBox();
            this.label3 = new SplitByte.LabelToolTip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSplitWhenDone = new System.Windows.Forms.ComboBox();
            this.chkSplitEmail = new SplitByte.CheckBoxToolTip();
            this.chkSplitShutdown = new SplitByte.CheckBoxToolTip();
            this.chkSplitExplore = new SplitByte.CheckBoxToolTip();
            this.chkSplitTimestamp = new SplitByte.CheckBoxToolTip();
            this.chkSplitCompress = new SplitByte.CheckBoxToolTip();
            this.chkSplitEncrypt = new SplitByte.CheckBoxToolTip();
            this.chkSplitDelete = new SplitByte.CheckBoxToolTip();
            this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
            this.label2 = new SplitByte.LabelToolTip();
            this.btnBrowseSplitFile = new System.Windows.Forms.Button();
            this.label1 = new SplitByte.LabelToolTip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new SplitByte.LabelToolTip();
            this.cmbJoinFirstPart = new System.Windows.Forms.ComboBox();
            this.cmbJoinOutputFile = new System.Windows.Forms.ComboBox();
            this.label5 = new SplitByte.LabelToolTip();
            this.label6 = new SplitByte.LabelToolTip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbJoinWhenDone = new System.Windows.Forms.ComboBox();
            this.chkJoinShutdown = new SplitByte.CheckBoxToolTip();
            this.chkJoinExplore = new SplitByte.CheckBoxToolTip();
            this.chkJoinSpecifyFiles = new SplitByte.CheckBoxToolTip();
            this.chkJoinTimeStamp = new SplitByte.CheckBoxToolTip();
            this.chkJoinDelete = new SplitByte.CheckBoxToolTip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnJoinBrowseOutputFile = new System.Windows.Forms.Button();
            this.btnJoinFirstPartBrowse = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new SplitByte.LabelToolTip();
            this.btnMD5ComparisonCopy = new System.Windows.Forms.Button();
            this.cmbMD5ComparisonSignature = new System.Windows.Forms.ComboBox();
            this.label11 = new SplitByte.LabelToolTip();
            this.cmbMD5ComparisonFile = new System.Windows.Forms.ComboBox();
            this.label12 = new SplitByte.LabelToolTip();
            this.btnMD5ComparisonBrowse = new System.Windows.Forms.Button();
            this.btnMD5Copy = new System.Windows.Forms.Button();
            this.cmbMD5Signature = new System.Windows.Forms.ComboBox();
            this.label8 = new SplitByte.LabelToolTip();
            this.cmbMD5InputFile = new System.Windows.Forms.ComboBox();
            this.label7 = new SplitByte.LabelToolTip();
            this.btnMD5InputFileBrowse = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new SplitByte.CustomProgressBar();
            this.bwSplit = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMessageOnSucessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languages1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languages2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadLatestVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUpdateProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForNewVersionEachWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visit4dotsSoftwareWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followUsOnTwitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bwJoin = new System.ComponentModel.BackgroundWorker();
            this.bwMD5 = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTimeElapsedDesc = new SplitByte.LabelToolTip();
            this.lblTimeElapsed = new SplitByte.LabelToolTip();
            this.lblTimeRemaining = new SplitByte.LabelToolTip();
            this.lblTimeRemainingDesc = new SplitByte.LabelToolTip();
            this.timElapsed = new System.Windows.Forms.Timer(this.components);
            this.commandLineArgumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEqualParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragDrop);
            this.tabControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragEnter);
            this.tabControl1.DragOver += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragOver);
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.nudEqualParts);
            this.tabPage1.Controls.Add(this.chkSplitSize);
            this.tabPage1.Controls.Add(this.chkSpitNumberParts);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cmbSplitFnPattern);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.cmbSplitSizeType);
            this.tabPage1.Controls.Add(this.cmbSplitInputFile);
            this.tabPage1.Controls.Add(this.cmbSplitSize);
            this.tabPage1.Controls.Add(this.cmbSplitOutputFolder);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnBrowseOutputFolder);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnBrowseSplitFile);
            this.tabPage1.Controls.Add(this.label1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragDrop);
            this.tabPage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragEnter);
            this.tabPage1.DragOver += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragOver);
            // 
            // nudEqualParts
            // 
            resources.ApplyResources(this.nudEqualParts, "nudEqualParts");
            this.nudEqualParts.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudEqualParts.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudEqualParts.Name = "nudEqualParts";
            this.nudEqualParts.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudEqualParts.ValueChanged += new System.EventHandler(this.nudEqualParts_ValueChanged);
            // 
            // chkSplitSize
            // 
            resources.ApplyResources(this.chkSplitSize, "chkSplitSize");
            this.chkSplitSize.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkSplitSize.Name = "chkSplitSize";
            this.chkSplitSize.UseVisualStyleBackColor = true;
            // 
            // chkSpitNumberParts
            // 
            resources.ApplyResources(this.chkSpitNumberParts, "chkSpitNumberParts");
            this.chkSpitNumberParts.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkSpitNumberParts.Name = "chkSpitNumberParts";
            this.chkSpitNumberParts.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Name = "label4";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Name = "label9";
            // 
            // cmbSplitFnPattern
            // 
            this.cmbSplitFnPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSplitFnPattern.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSplitFnPattern, "cmbSplitFnPattern");
            this.cmbSplitFnPattern.Name = "cmbSplitFnPattern";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SplitByte.Properties.Resources.split_file_48;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // cmbSplitSizeType
            // 
            this.cmbSplitSizeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbSplitSizeType, "cmbSplitSizeType");
            this.cmbSplitSizeType.FormattingEnabled = true;
            this.cmbSplitSizeType.Name = "cmbSplitSizeType";
            this.cmbSplitSizeType.SelectedIndexChanged += new System.EventHandler(this.cmbSplitSizeType_SelectedIndexChanged);
            // 
            // cmbSplitInputFile
            // 
            this.cmbSplitInputFile.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSplitInputFile, "cmbSplitInputFile");
            this.cmbSplitInputFile.Name = "cmbSplitInputFile";
            this.cmbSplitInputFile.SelectedIndexChanged += new System.EventHandler(this.cmbSplitInputFile_SelectedIndexChanged);
            this.cmbSplitInputFile.TextChanged += new System.EventHandler(this.cmbSplitInputFile_TextChanged);
            this.cmbSplitInputFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbSplitInputFile_KeyUp);
            // 
            // cmbSplitSize
            // 
            resources.ApplyResources(this.cmbSplitSize, "cmbSplitSize");
            this.cmbSplitSize.FormattingEnabled = true;
            this.cmbSplitSize.Name = "cmbSplitSize";
            this.cmbSplitSize.SelectedIndexChanged += new System.EventHandler(this.cmbSplitSize_SelectedIndexChanged);
            this.cmbSplitSize.TextChanged += new System.EventHandler(this.cmbSplitSize_TextChanged);
            // 
            // cmbSplitOutputFolder
            // 
            this.cmbSplitOutputFolder.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSplitOutputFolder, "cmbSplitOutputFolder");
            this.cmbSplitOutputFolder.Name = "cmbSplitOutputFolder";
            this.cmbSplitOutputFolder.SelectedIndexChanged += new System.EventHandler(this.cmbSplitOutputFolder_SelectedIndexChanged);
            this.cmbSplitOutputFolder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbSplitOutputFolder_KeyUp);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Name = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSplitWhenDone);
            this.groupBox1.Controls.Add(this.chkSplitEmail);
            this.groupBox1.Controls.Add(this.chkSplitShutdown);
            this.groupBox1.Controls.Add(this.chkSplitExplore);
            this.groupBox1.Controls.Add(this.chkSplitTimestamp);
            this.groupBox1.Controls.Add(this.chkSplitCompress);
            this.groupBox1.Controls.Add(this.chkSplitEncrypt);
            this.groupBox1.Controls.Add(this.chkSplitDelete);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cmbSplitWhenDone
            // 
            this.cmbSplitWhenDone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbSplitWhenDone, "cmbSplitWhenDone");
            this.cmbSplitWhenDone.FormattingEnabled = true;
            this.cmbSplitWhenDone.Name = "cmbSplitWhenDone";
            // 
            // chkSplitEmail
            // 
            resources.ApplyResources(this.chkSplitEmail, "chkSplitEmail");
            this.chkSplitEmail.Name = "chkSplitEmail";
            this.chkSplitEmail.UseVisualStyleBackColor = true;
            // 
            // chkSplitShutdown
            // 
            resources.ApplyResources(this.chkSplitShutdown, "chkSplitShutdown");
            this.chkSplitShutdown.Name = "chkSplitShutdown";
            this.chkSplitShutdown.UseVisualStyleBackColor = true;
            // 
            // chkSplitExplore
            // 
            resources.ApplyResources(this.chkSplitExplore, "chkSplitExplore");
            this.chkSplitExplore.Checked = true;
            this.chkSplitExplore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSplitExplore.Name = "chkSplitExplore";
            this.chkSplitExplore.UseVisualStyleBackColor = true;
            // 
            // chkSplitTimestamp
            // 
            resources.ApplyResources(this.chkSplitTimestamp, "chkSplitTimestamp");
            this.chkSplitTimestamp.Name = "chkSplitTimestamp";
            this.chkSplitTimestamp.UseVisualStyleBackColor = true;
            // 
            // chkSplitCompress
            // 
            resources.ApplyResources(this.chkSplitCompress, "chkSplitCompress");
            this.chkSplitCompress.Name = "chkSplitCompress";
            this.chkSplitCompress.UseVisualStyleBackColor = true;
            // 
            // chkSplitEncrypt
            // 
            resources.ApplyResources(this.chkSplitEncrypt, "chkSplitEncrypt");
            this.chkSplitEncrypt.Name = "chkSplitEncrypt";
            this.chkSplitEncrypt.UseVisualStyleBackColor = true;
            // 
            // chkSplitDelete
            // 
            resources.ApplyResources(this.chkSplitDelete, "chkSplitDelete");
            this.chkSplitDelete.Name = "chkSplitDelete";
            this.chkSplitDelete.UseVisualStyleBackColor = true;
            // 
            // btnBrowseOutputFolder
            // 
            this.btnBrowseOutputFolder.Image = global::SplitByte.Properties.Resources.folder;
            resources.ApplyResources(this.btnBrowseOutputFolder, "btnBrowseOutputFolder");
            this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Name = "label2";
            // 
            // btnBrowseSplitFile
            // 
            this.btnBrowseSplitFile.Image = global::SplitByte.Properties.Resources.view;
            resources.ApplyResources(this.btnBrowseSplitFile, "btnBrowseSplitFile");
            this.btnBrowseSplitFile.Name = "btnBrowseSplitFile";
            this.btnBrowseSplitFile.UseVisualStyleBackColor = true;
            this.btnBrowseSplitFile.Click += new System.EventHandler(this.btnBrowseSplitFile_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Name = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cmbJoinFirstPart);
            this.tabPage2.Controls.Add(this.cmbJoinOutputFile);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btnJoinBrowseOutputFile);
            this.tabPage2.Controls.Add(this.btnJoinFirstPartBrowse);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage2_DragDrop);
            this.tabPage2.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage2_DragEnter);
            this.tabPage2.DragOver += new System.Windows.Forms.DragEventHandler(this.tabPage2_DragOver);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Name = "label10";
            // 
            // cmbJoinFirstPart
            // 
            this.cmbJoinFirstPart.FormattingEnabled = true;
            resources.ApplyResources(this.cmbJoinFirstPart, "cmbJoinFirstPart");
            this.cmbJoinFirstPart.Name = "cmbJoinFirstPart";
            this.cmbJoinFirstPart.SelectedIndexChanged += new System.EventHandler(this.cmbJoinFirstPart_SelectedIndexChanged);
            this.cmbJoinFirstPart.TextChanged += new System.EventHandler(this.cmbJoinFirstPart_TextChanged);
            // 
            // cmbJoinOutputFile
            // 
            this.cmbJoinOutputFile.FormattingEnabled = true;
            resources.ApplyResources(this.cmbJoinOutputFile, "cmbJoinOutputFile");
            this.cmbJoinOutputFile.Name = "cmbJoinOutputFile";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Name = "label6";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbJoinWhenDone);
            this.groupBox3.Controls.Add(this.chkJoinShutdown);
            this.groupBox3.Controls.Add(this.chkJoinExplore);
            this.groupBox3.Controls.Add(this.chkJoinSpecifyFiles);
            this.groupBox3.Controls.Add(this.chkJoinTimeStamp);
            this.groupBox3.Controls.Add(this.chkJoinDelete);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cmbJoinWhenDone
            // 
            this.cmbJoinWhenDone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbJoinWhenDone, "cmbJoinWhenDone");
            this.cmbJoinWhenDone.FormattingEnabled = true;
            this.cmbJoinWhenDone.Name = "cmbJoinWhenDone";
            // 
            // chkJoinShutdown
            // 
            resources.ApplyResources(this.chkJoinShutdown, "chkJoinShutdown");
            this.chkJoinShutdown.Name = "chkJoinShutdown";
            this.chkJoinShutdown.UseVisualStyleBackColor = true;
            // 
            // chkJoinExplore
            // 
            resources.ApplyResources(this.chkJoinExplore, "chkJoinExplore");
            this.chkJoinExplore.Checked = true;
            this.chkJoinExplore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJoinExplore.Name = "chkJoinExplore";
            this.chkJoinExplore.UseVisualStyleBackColor = true;
            // 
            // chkJoinSpecifyFiles
            // 
            resources.ApplyResources(this.chkJoinSpecifyFiles, "chkJoinSpecifyFiles");
            this.chkJoinSpecifyFiles.Name = "chkJoinSpecifyFiles";
            this.chkJoinSpecifyFiles.UseVisualStyleBackColor = true;
            // 
            // chkJoinTimeStamp
            // 
            resources.ApplyResources(this.chkJoinTimeStamp, "chkJoinTimeStamp");
            this.chkJoinTimeStamp.Name = "chkJoinTimeStamp";
            this.chkJoinTimeStamp.UseVisualStyleBackColor = true;
            // 
            // chkJoinDelete
            // 
            resources.ApplyResources(this.chkJoinDelete, "chkJoinDelete");
            this.chkJoinDelete.Name = "chkJoinDelete";
            this.chkJoinDelete.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SplitByte.Properties.Resources.join_file_48;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnJoinBrowseOutputFile
            // 
            this.btnJoinBrowseOutputFile.Image = global::SplitByte.Properties.Resources.disk_blue;
            resources.ApplyResources(this.btnJoinBrowseOutputFile, "btnJoinBrowseOutputFile");
            this.btnJoinBrowseOutputFile.Name = "btnJoinBrowseOutputFile";
            this.btnJoinBrowseOutputFile.UseVisualStyleBackColor = true;
            this.btnJoinBrowseOutputFile.Click += new System.EventHandler(this.btnJoinBrowseOutputFile_Click);
            // 
            // btnJoinFirstPartBrowse
            // 
            this.btnJoinFirstPartBrowse.Image = global::SplitByte.Properties.Resources.view;
            resources.ApplyResources(this.btnJoinFirstPartBrowse, "btnJoinFirstPartBrowse");
            this.btnJoinFirstPartBrowse.Name = "btnJoinFirstPartBrowse";
            this.btnJoinFirstPartBrowse.UseVisualStyleBackColor = true;
            this.btnJoinFirstPartBrowse.Click += new System.EventHandler(this.btnJoinFirstPartBrowse_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btnMD5ComparisonCopy);
            this.tabPage3.Controls.Add(this.cmbMD5ComparisonSignature);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cmbMD5ComparisonFile);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnMD5ComparisonBrowse);
            this.tabPage3.Controls.Add(this.btnMD5Copy);
            this.tabPage3.Controls.Add(this.cmbMD5Signature);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cmbMD5InputFile);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnMD5InputFileBrowse);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage3_DragDrop);
            this.tabPage3.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage3_DragEnter);
            this.tabPage3.DragOver += new System.Windows.Forms.DragEventHandler(this.tabPage3_DragOver);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Name = "label13";
            // 
            // btnMD5ComparisonCopy
            // 
            this.btnMD5ComparisonCopy.Image = global::SplitByte.Properties.Resources.copy;
            resources.ApplyResources(this.btnMD5ComparisonCopy, "btnMD5ComparisonCopy");
            this.btnMD5ComparisonCopy.Name = "btnMD5ComparisonCopy";
            this.btnMD5ComparisonCopy.UseVisualStyleBackColor = true;
            this.btnMD5ComparisonCopy.Click += new System.EventHandler(this.btnMD5ComparisonCopy_Click);
            // 
            // cmbMD5ComparisonSignature
            // 
            this.cmbMD5ComparisonSignature.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMD5ComparisonSignature, "cmbMD5ComparisonSignature");
            this.cmbMD5ComparisonSignature.Name = "cmbMD5ComparisonSignature";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Name = "label11";
            // 
            // cmbMD5ComparisonFile
            // 
            this.cmbMD5ComparisonFile.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMD5ComparisonFile, "cmbMD5ComparisonFile");
            this.cmbMD5ComparisonFile.Name = "cmbMD5ComparisonFile";
            this.cmbMD5ComparisonFile.SelectedIndexChanged += new System.EventHandler(this.cmbMD5ComparisonFile_SelectedIndexChanged);
            this.cmbMD5ComparisonFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbMD5ComparisonFile_KeyUp);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Name = "label12";
            // 
            // btnMD5ComparisonBrowse
            // 
            this.btnMD5ComparisonBrowse.Image = global::SplitByte.Properties.Resources.view;
            resources.ApplyResources(this.btnMD5ComparisonBrowse, "btnMD5ComparisonBrowse");
            this.btnMD5ComparisonBrowse.Name = "btnMD5ComparisonBrowse";
            this.btnMD5ComparisonBrowse.UseVisualStyleBackColor = true;
            this.btnMD5ComparisonBrowse.Click += new System.EventHandler(this.btnMD5ComparisonBrowse_Click);
            // 
            // btnMD5Copy
            // 
            this.btnMD5Copy.Image = global::SplitByte.Properties.Resources.copy;
            resources.ApplyResources(this.btnMD5Copy, "btnMD5Copy");
            this.btnMD5Copy.Name = "btnMD5Copy";
            this.btnMD5Copy.UseVisualStyleBackColor = true;
            this.btnMD5Copy.Click += new System.EventHandler(this.btnMD5Copy_Click);
            // 
            // cmbMD5Signature
            // 
            this.cmbMD5Signature.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMD5Signature, "cmbMD5Signature");
            this.cmbMD5Signature.Name = "cmbMD5Signature";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Name = "label8";
            // 
            // cmbMD5InputFile
            // 
            this.cmbMD5InputFile.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMD5InputFile, "cmbMD5InputFile");
            this.cmbMD5InputFile.Name = "cmbMD5InputFile";
            this.cmbMD5InputFile.SelectedIndexChanged += new System.EventHandler(this.cmbMD5InputFile_SelectedIndexChanged);
            this.cmbMD5InputFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbMD5InputFile_KeyUp);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Name = "label7";
            // 
            // btnMD5InputFileBrowse
            // 
            this.btnMD5InputFileBrowse.Image = global::SplitByte.Properties.Resources.view;
            resources.ApplyResources(this.btnMD5InputFileBrowse, "btnMD5InputFileBrowse");
            this.btnMD5InputFileBrowse.Name = "btnMD5InputFileBrowse";
            this.btnMD5InputFileBrowse.UseVisualStyleBackColor = true;
            this.btnMD5InputFileBrowse.Click += new System.EventHandler(this.btnMD5InputFileBrowse_Click);
            // 
            // btnSplit
            // 
            resources.ApplyResources(this.btnSplit, "btnSplit");
            this.btnSplit.Image = global::SplitByte.Properties.Resources.flash;
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // bwSplit
            // 
            this.bwSplit.WorkerReportsProgress = true;
            this.bwSplit.WorkerSupportsCancellation = true;
            this.bwSplit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSplit_DoWork);
            this.bwSplit.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwSplit_ProgressChanged);
            this.bwSplit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSplit_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SplitByte.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            resources.ApplyResources(this.downloadToolStripMenuItem, "downloadToolStripMenuItem");
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMessageOnSucessToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // showMessageOnSucessToolStripMenuItem
            // 
            this.showMessageOnSucessToolStripMenuItem.CheckOnClick = true;
            this.showMessageOnSucessToolStripMenuItem.Name = "showMessageOnSucessToolStripMenuItem";
            resources.ApplyResources(this.showMessageOnSucessToolStripMenuItem, "showMessageOnSucessToolStripMenuItem");
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            resources.ApplyResources(this.splitToolStripMenuItem, "splitToolStripMenuItem");
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languages1ToolStripMenuItem,
            this.languages2ToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // languages1ToolStripMenuItem
            // 
            this.languages1ToolStripMenuItem.Name = "languages1ToolStripMenuItem";
            resources.ApplyResources(this.languages1ToolStripMenuItem, "languages1ToolStripMenuItem");
            // 
            // languages2ToolStripMenuItem
            // 
            this.languages2ToolStripMenuItem.Name = "languages2ToolStripMenuItem";
            resources.ApplyResources(this.languages2ToolStripMenuItem, "languages2ToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpGuideToolStripMenuItem,
            this.commandLineArgumentsToolStripMenuItem,
            this.downloadLatestVersionToolStripMenuItem,
            this.setUpdateProxyToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.checkForNewVersionEachWeekToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.toolStripMenuItem1,
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem,
            this.visit4dotsSoftwareWebsiteToolStripMenuItem,
            this.followUsOnTwitterToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // helpGuideToolStripMenuItem
            // 
            resources.ApplyResources(this.helpGuideToolStripMenuItem, "helpGuideToolStripMenuItem");
            this.helpGuideToolStripMenuItem.Name = "helpGuideToolStripMenuItem";
            this.helpGuideToolStripMenuItem.Click += new System.EventHandler(this.helpGuideToolStripMenuItem_Click);
            // 
            // downloadLatestVersionToolStripMenuItem
            // 
            this.downloadLatestVersionToolStripMenuItem.Name = "downloadLatestVersionToolStripMenuItem";
            resources.ApplyResources(this.downloadLatestVersionToolStripMenuItem, "downloadLatestVersionToolStripMenuItem");
            this.downloadLatestVersionToolStripMenuItem.Click += new System.EventHandler(this.downloadLatestVersionToolStripMenuItem_Click);
            // 
            // setUpdateProxyToolStripMenuItem
            // 
            this.setUpdateProxyToolStripMenuItem.Name = "setUpdateProxyToolStripMenuItem";
            resources.ApplyResources(this.setUpdateProxyToolStripMenuItem, "setUpdateProxyToolStripMenuItem");
            this.setUpdateProxyToolStripMenuItem.Click += new System.EventHandler(this.setUpdateProxyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SplitByte.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForNewVersionEachWeekToolStripMenuItem
            // 
            this.checkForNewVersionEachWeekToolStripMenuItem.CheckOnClick = true;
            this.checkForNewVersionEachWeekToolStripMenuItem.Name = "checkForNewVersionEachWeekToolStripMenuItem";
            resources.ApplyResources(this.checkForNewVersionEachWeekToolStripMenuItem, "checkForNewVersionEachWeekToolStripMenuItem");
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Image = global::SplitByte.Properties.Resources.edit;
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            resources.ApplyResources(this.feedbackToolStripMenuItem, "feedbackToolStripMenuItem");
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // dotsSoftwarePRODUCTCATALOGToolStripMenuItem
            // 
            resources.ApplyResources(this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem, "dotsSoftwarePRODUCTCATALOGToolStripMenuItem");
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Name = "dotsSoftwarePRODUCTCATALOGToolStripMenuItem";
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Click += new System.EventHandler(this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem_Click);
            // 
            // visit4dotsSoftwareWebsiteToolStripMenuItem
            // 
            resources.ApplyResources(this.visit4dotsSoftwareWebsiteToolStripMenuItem, "visit4dotsSoftwareWebsiteToolStripMenuItem");
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Name = "visit4dotsSoftwareWebsiteToolStripMenuItem";
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Click += new System.EventHandler(this.visit4dotsSoftwareWebsiteToolStripMenuItem_Click_2);
            // 
            // followUsOnTwitterToolStripMenuItem
            // 
            resources.ApplyResources(this.followUsOnTwitterToolStripMenuItem, "followUsOnTwitterToolStripMenuItem");
            this.followUsOnTwitterToolStripMenuItem.Name = "followUsOnTwitterToolStripMenuItem";
            this.followUsOnTwitterToolStripMenuItem.Click += new System.EventHandler(this.followUsOnTwitterToolStripMenuItem_Click);
            // 
            // bwJoin
            // 
            this.bwJoin.WorkerReportsProgress = true;
            this.bwJoin.WorkerSupportsCancellation = true;
            this.bwJoin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwJoin_DoWork);
            this.bwJoin.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwJoin_ProgressChanged);
            this.bwJoin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwJoin_RunWorkerCompleted);
            // 
            // bwMD5
            // 
            this.bwMD5.WorkerReportsProgress = true;
            this.bwMD5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMD5_DoWork);
            this.bwMD5.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwMD5_ProgressChanged);
            this.bwMD5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwMD5_RunWorkerCompleted);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTimeElapsedDesc
            // 
            resources.ApplyResources(this.lblTimeElapsedDesc, "lblTimeElapsedDesc");
            this.lblTimeElapsedDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeElapsedDesc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTimeElapsedDesc.Name = "lblTimeElapsedDesc";
            // 
            // lblTimeElapsed
            // 
            resources.ApplyResources(this.lblTimeElapsed, "lblTimeElapsed");
            this.lblTimeElapsed.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeElapsed.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            // 
            // lblTimeRemaining
            // 
            resources.ApplyResources(this.lblTimeRemaining, "lblTimeRemaining");
            this.lblTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeRemaining.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            // 
            // lblTimeRemainingDesc
            // 
            resources.ApplyResources(this.lblTimeRemainingDesc, "lblTimeRemainingDesc");
            this.lblTimeRemainingDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeRemainingDesc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTimeRemainingDesc.Name = "lblTimeRemainingDesc";
            // 
            // timElapsed
            // 
            this.timElapsed.Interval = 1000;
            this.timElapsed.Tick += new System.EventHandler(this.timElapsed_Tick);
            // 
            // commandLineArgumentsToolStripMenuItem
            // 
            this.commandLineArgumentsToolStripMenuItem.Name = "commandLineArgumentsToolStripMenuItem";
            resources.ApplyResources(this.commandLineArgumentsToolStripMenuItem, "commandLineArgumentsToolStripMenuItem");
            this.commandLineArgumentsToolStripMenuItem.Click += new System.EventHandler(this.commandLineArgumentsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblTimeRemainingDesc);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblTimeElapsedDesc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSplit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEqualParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private LabelToolTip label2;
        private System.Windows.Forms.Button btnBrowseSplitFile;
        private LabelToolTip label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbSplitSize;
        private LabelToolTip label3;
        private System.Windows.Forms.NumericUpDown nudEqualParts;
        private System.Windows.Forms.Button btnBrowseOutputFolder;
        private System.Windows.Forms.ComboBox cmbSplitSizeType;
        private CheckBoxToolTip chkSplitCompress;
        private CheckBoxToolTip chkSplitEncrypt;
        private CheckBoxToolTip chkSplitDelete;
        private CheckBoxToolTip chkSplitTimestamp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private CustomProgressBar progressBar1;
        public System.ComponentModel.BackgroundWorker bwSplit;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox groupBox1;
        private LabelToolTip label4;
        private System.Windows.Forms.ComboBox cmbSplitFnPattern;
        private System.Windows.Forms.GroupBox groupBox3;
        private CheckBoxToolTip chkJoinTimeStamp;
        private CheckBoxToolTip chkJoinDelete;
        private System.Windows.Forms.ComboBox cmbSplitInputFile;
        private System.Windows.Forms.ComboBox cmbSplitOutputFolder;
        private System.Windows.Forms.Button btnJoinBrowseOutputFile;
        private System.Windows.Forms.ComboBox cmbJoinFirstPart;
        private System.Windows.Forms.ComboBox cmbJoinOutputFile;
        private LabelToolTip label5;
        private System.Windows.Forms.Button btnJoinFirstPartBrowse;
        private LabelToolTip label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMD5Copy;
        private System.Windows.Forms.ComboBox cmbMD5Signature;
        private LabelToolTip label8;
        private System.Windows.Forms.ComboBox cmbMD5InputFile;
        private System.Windows.Forms.Button btnMD5InputFileBrowse;
        private LabelToolTip label7;
        private CheckBoxToolTip chkJoinSpecifyFiles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LabelToolTip label9;
        private LabelToolTip label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.ComponentModel.BackgroundWorker bwJoin;
        private CheckBoxToolTip chkSplitExplore;
        private CheckBoxToolTip chkJoinExplore;
        private System.Windows.Forms.Button btnMD5ComparisonCopy;
        private System.Windows.Forms.ComboBox cmbMD5ComparisonSignature;
        private LabelToolTip label11;
        private System.Windows.Forms.ComboBox cmbMD5ComparisonFile;
        private LabelToolTip label12;
        private System.Windows.Forms.Button btnMD5ComparisonBrowse;
        private CheckBoxToolTip chkJoinShutdown;
        private CheckBoxToolTip chkSplitShutdown;
        private CheckBoxToolTip chkSplitEmail;
        private System.ComponentModel.BackgroundWorker bwMD5;
        private RadioButtonToolTip chkSpitNumberParts;
        private RadioButtonToolTip chkSplitSize;
        private LabelToolTip label13;
        private System.Windows.Forms.ToolStripMenuItem languages1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languages2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUpdateProxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dotsSoftwarePRODUCTCATALOGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visit4dotsSoftwareWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followUsOnTwitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadLatestVersionToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private LabelToolTip lblTimeElapsedDesc;
        private LabelToolTip lblTimeElapsed;
        private LabelToolTip lblTimeRemaining;
        private LabelToolTip lblTimeRemainingDesc;
        private System.Windows.Forms.Timer timElapsed;
        private System.Windows.Forms.ComboBox cmbSplitWhenDone;
        private System.Windows.Forms.ComboBox cmbJoinWhenDone;
        private System.Windows.Forms.ToolStripMenuItem checkForNewVersionEachWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMessageOnSucessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandLineArgumentsToolStripMenuItem;
    }
}
