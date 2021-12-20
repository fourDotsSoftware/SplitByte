namespace SplitByte
{
    partial class frmJoinParts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.importListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importListFromExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.enterFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDocumentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seelctNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiSortBy = new System.Windows.Forms.ToolStripMenuItem();
            this.sortInDescendingOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericStringSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.filenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullFilepathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creationDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastModificationDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdbAddFile = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdbAddFolder = new System.Windows.Forms.ToolStripSplitButton();
            this.tsdbImportList = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.colFolder = new System.Windows.Forms.DataGridViewImageColumn();
            this.colFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.tiSortBy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.addFoldersToolStripMenuItem,
            this.toolStripMenuItem4,
            this.importListToolStripMenuItem,
            this.importListFromExcelFileToolStripMenuItem,
            this.toolStripMenuItem6,
            this.enterFileListToolStripMenuItem,
            this.saveDocumentsListToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Image = global::SplitByte.Properties.Resources.add;
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.addFilesToolStripMenuItem.Text = "&Add File(s)";
            // 
            // addFoldersToolStripMenuItem
            // 
            this.addFoldersToolStripMenuItem.Image = global::SplitByte.Properties.Resources.folder_add;
            this.addFoldersToolStripMenuItem.Name = "addFoldersToolStripMenuItem";
            this.addFoldersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.addFoldersToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.addFoldersToolStripMenuItem.Text = "Add &Folder(s)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(280, 6);
            // 
            // importListToolStripMenuItem
            // 
            this.importListToolStripMenuItem.Image = global::SplitByte.Properties.Resources.import1;
            this.importListToolStripMenuItem.Name = "importListToolStripMenuItem";
            this.importListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.importListToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.importListToolStripMenuItem.Text = "&Import List from Text File";
            // 
            // importListFromExcelFileToolStripMenuItem
            // 
            this.importListFromExcelFileToolStripMenuItem.Image = global::SplitByte.Properties.Resources.import1;
            this.importListFromExcelFileToolStripMenuItem.Name = "importListFromExcelFileToolStripMenuItem";
            this.importListFromExcelFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.importListFromExcelFileToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.importListFromExcelFileToolStripMenuItem.Text = "Import List from &Excel File";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(280, 6);
            // 
            // enterFileListToolStripMenuItem
            // 
            this.enterFileListToolStripMenuItem.Name = "enterFileListToolStripMenuItem";
            this.enterFileListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.enterFileListToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.enterFileListToolStripMenuItem.Text = "&Enter File List";
            // 
            // saveDocumentsListToolStripMenuItem
            // 
            this.saveDocumentsListToolStripMenuItem.Image = global::SplitByte.Properties.Resources.disk_blue;
            this.saveDocumentsListToolStripMenuItem.Name = "saveDocumentsListToolStripMenuItem";
            this.saveDocumentsListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveDocumentsListToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.saveDocumentsListToolStripMenuItem.Text = "&Save Documents List";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripMenuItem3,
            this.selectAllToolStripMenuItem,
            this.seelctNoneToolStripMenuItem,
            this.invertSelectionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::SplitByte.Properties.Resources.delete;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::SplitByte.Properties.Resources.brush2;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(208, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.selectAllToolStripMenuItem.Text = "&Select All";
            // 
            // seelctNoneToolStripMenuItem
            // 
            this.seelctNoneToolStripMenuItem.Name = "seelctNoneToolStripMenuItem";
            this.seelctNoneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.seelctNoneToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.seelctNoneToolStripMenuItem.Text = "Select &None";
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.invertSelectionToolStripMenuItem.Text = "&Invert Selection";
            // 
            // tiSortBy
            // 
            this.tiSortBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortInDescendingOrderToolStripMenuItem,
            this.numericStringSortToolStripMenuItem,
            this.toolStripMenuItem5,
            this.filenameToolStripMenuItem,
            this.fullFilepathToolStripMenuItem,
            this.fileSizeToolStripMenuItem,
            this.creationDateToolStripMenuItem,
            this.lastModificationDateToolStripMenuItem});
            this.tiSortBy.Name = "tiSortBy";
            this.tiSortBy.Size = new System.Drawing.Size(56, 20);
            this.tiSortBy.Text = "&Sort by";
            // 
            // sortInDescendingOrderToolStripMenuItem
            // 
            this.sortInDescendingOrderToolStripMenuItem.Name = "sortInDescendingOrderToolStripMenuItem";
            this.sortInDescendingOrderToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.sortInDescendingOrderToolStripMenuItem.Text = "S&ort in Descending Order";
            // 
            // numericStringSortToolStripMenuItem
            // 
            this.numericStringSortToolStripMenuItem.Name = "numericStringSortToolStripMenuItem";
            this.numericStringSortToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.numericStringSortToolStripMenuItem.Text = "Numeric String Sort";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(203, 6);
            // 
            // filenameToolStripMenuItem
            // 
            this.filenameToolStripMenuItem.Name = "filenameToolStripMenuItem";
            this.filenameToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.filenameToolStripMenuItem.Tag = "f:filename";
            this.filenameToolStripMenuItem.Text = "&Filename";
            // 
            // fullFilepathToolStripMenuItem
            // 
            this.fullFilepathToolStripMenuItem.Name = "fullFilepathToolStripMenuItem";
            this.fullFilepathToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.fullFilepathToolStripMenuItem.Tag = "f:filepath";
            this.fullFilepathToolStripMenuItem.Text = "F&ull Filepath";
            // 
            // fileSizeToolStripMenuItem
            // 
            this.fileSizeToolStripMenuItem.Name = "fileSizeToolStripMenuItem";
            this.fileSizeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.fileSizeToolStripMenuItem.Tag = "f:size";
            this.fileSizeToolStripMenuItem.Text = "&File Size";
            // 
            // creationDateToolStripMenuItem
            // 
            this.creationDateToolStripMenuItem.Name = "creationDateToolStripMenuItem";
            this.creationDateToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.creationDateToolStripMenuItem.Tag = "f:cdate";
            this.creationDateToolStripMenuItem.Text = "&Creation Date";
            // 
            // lastModificationDateToolStripMenuItem
            // 
            this.lastModificationDateToolStripMenuItem.Name = "lastModificationDateToolStripMenuItem";
            this.lastModificationDateToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.lastModificationDateToolStripMenuItem.Tag = "f:lmdate";
            this.lastModificationDateToolStripMenuItem.Text = "Last &Modification Date";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdbAddFile,
            this.tsbRemove,
            this.toolStripSeparator3,
            this.tsdbAddFolder,
            this.tsdbImportList,
            this.toolStripSeparator2,
            this.tsbCopy,
            this.tsbPaste,
            this.tsbMoveUp,
            this.tsbMoveDown,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(892, 62);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsdbAddFile
            // 
            this.tsdbAddFile.AutoSize = false;
            this.tsdbAddFile.Image = global::SplitByte.Properties.Resources.add1;
            this.tsdbAddFile.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsdbAddFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdbAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdbAddFile.Name = "tsdbAddFile";
            this.tsdbAddFile.Size = new System.Drawing.Size(80, 59);
            this.tsdbAddFile.Text = "Add File(s)";
            this.tsdbAddFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbRemove
            // 
            this.tsbRemove.AutoSize = false;
            this.tsbRemove.Image = global::SplitByte.Properties.Resources.delete1;
            this.tsbRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(70, 59);
            this.tsbRemove.Text = "Remove";
            this.tsbRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 62);
            // 
            // tsdbAddFolder
            // 
            this.tsdbAddFolder.AutoSize = false;
            this.tsdbAddFolder.Image = global::SplitByte.Properties.Resources.folder_add;
            this.tsdbAddFolder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsdbAddFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdbAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdbAddFolder.Name = "tsdbAddFolder";
            this.tsdbAddFolder.Size = new System.Drawing.Size(80, 59);
            this.tsdbAddFolder.Text = "Add Folder";
            this.tsdbAddFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsdbImportList
            // 
            this.tsdbImportList.AutoSize = false;
            this.tsdbImportList.Image = global::SplitByte.Properties.Resources.import1;
            this.tsdbImportList.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsdbImportList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdbImportList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdbImportList.Name = "tsdbImportList";
            this.tsdbImportList.Size = new System.Drawing.Size(80, 59);
            this.tsdbImportList.Text = "Import List";
            this.tsdbImportList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbCopy
            // 
            this.tsbCopy.AutoSize = false;
            this.tsbCopy.Image = global::SplitByte.Properties.Resources.copy1;
            this.tsbCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(83, 53);
            this.tsbCopy.Text = "&Copy";
            this.tsbCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbPaste
            // 
            this.tsbPaste.AutoSize = false;
            this.tsbPaste.Image = global::SplitByte.Properties.Resources.paste;
            this.tsbPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(83, 53);
            this.tsbPaste.Text = "&Paste";
            this.tsbPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbMoveUp
            // 
            this.tsbMoveUp.AutoSize = false;
            this.tsbMoveUp.Image = global::SplitByte.Properties.Resources.arrow_up_green;
            this.tsbMoveUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveUp.Name = "tsbMoveUp";
            this.tsbMoveUp.Size = new System.Drawing.Size(83, 53);
            this.tsbMoveUp.Text = "&Move Up";
            this.tsbMoveUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbMoveDown
            // 
            this.tsbMoveDown.AutoSize = false;
            this.tsbMoveDown.Image = global::SplitByte.Properties.Resources.arrow_down_green;
            this.tsbMoveDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveDown.Name = "tsbMoveDown";
            this.tsbMoveDown.Size = new System.Drawing.Size(83, 53);
            this.tsbMoveDown.Text = "Move &Down";
            this.tsbMoveDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // dgFiles
            // 
            this.dgFiles.AllowDrop = true;
            this.dgFiles.AllowUserToAddRows = false;
            this.dgFiles.AllowUserToDeleteRows = false;
            this.dgFiles.AllowUserToResizeRows = false;
            this.dgFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFolder,
            this.colFilename,
            this.colPassword,
            this.colSize,
            this.colFileDate,
            this.colFullFilePath});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFiles.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgFiles.GridColor = System.Drawing.Color.Black;
            this.dgFiles.Location = new System.Drawing.Point(0, 89);
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.RowHeadersVisible = false;
            this.dgFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFiles.Size = new System.Drawing.Size(892, 293);
            this.dgFiles.TabIndex = 5;
            // 
            // colFolder
            // 
            this.colFolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFolder.DataPropertyName = "foldersep";
            this.colFolder.HeaderText = "   ";
            this.colFolder.Name = "colFolder";
            this.colFolder.Width = 20;
            // 
            // colFilename
            // 
            this.colFilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFilename.DataPropertyName = "filename";
            this.colFilename.HeaderText = "Filename";
            this.colFilename.Name = "colFilename";
            this.colFilename.ReadOnly = true;
            this.colFilename.Width = 74;
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "password";
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            // 
            // colSize
            // 
            this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSize.DataPropertyName = "sizekb";
            this.colSize.HeaderText = "Size (KB)";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.Width = 75;
            // 
            // colFileDate
            // 
            this.colFileDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFileDate.DataPropertyName = "filedate";
            this.colFileDate.HeaderText = "File Date";
            this.colFileDate.Name = "colFileDate";
            this.colFileDate.ReadOnly = true;
            this.colFileDate.Width = 74;
            // 
            // colFullFilePath
            // 
            this.colFullFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFullFilePath.DataPropertyName = "fullfilepath";
            this.colFullFilePath.HeaderText = "Full File Path";
            this.colFullFilePath.Name = "colFullFilePath";
            this.colFullFilePath.ReadOnly = true;
            this.colFullFilePath.Width = 92;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::SplitByte.Properties.Resources.exit;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(453, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::SplitByte.Properties.Resources.check;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(312, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 29);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // frmJoinParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(892, 442);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgFiles);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmJoinParts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem importListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importListFromExcelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem enterFileListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDocumentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seelctNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiSortBy;
        private System.Windows.Forms.ToolStripMenuItem sortInDescendingOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numericStringSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem filenameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullFilepathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creationDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastModificationDateToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripSplitButton tsdbAddFile;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripSplitButton tsdbAddFolder;
        public System.Windows.Forms.ToolStripSplitButton tsdbImportList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripButton tsbMoveUp;
        private System.Windows.Forms.ToolStripButton tsbMoveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.DataGridViewImageColumn colFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullFilePath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
