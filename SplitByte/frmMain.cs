using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace SplitByte
{
    public partial class frmMain : SplitByte.CustomForm
    {
        public static frmMain Instance = null;
        private int CmbCustomInd = -1;               

        public frmMain()
        {
            InitializeComponent();
            Instance = this;
        }

        public void AddFileFromWindowsExplorer(string filepath)
        {
            cmbSplitInputFile.Text = filepath;

            cmbJoinFirstPart.Text = filepath;

            cmbMD5InputFile.Text = filepath;
        }

        private void btnBrowseSplitFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cmbSplitInputFile.Text = openFileDialog1.FileName;

                if (cmbSplitOutputFolder.Text == String.Empty)
                {
                    cmbSplitOutputFolder.Text = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                }
            }
        }

        private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            if (cmbSplitInputFile.Text != String.Empty && cmbSplitOutputFolder.Text==String.Empty)
            {
                try
                {
                    folderBrowserDialog1.SelectedPath = System.IO.Path.GetDirectoryName(cmbSplitInputFile.Text);
                }
                catch { }
            }

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                cmbSplitOutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SetupOnLoad()
        {
            AddLanguageMenuItems();

            cmbSplitSizeType.Items.Add("");
            cmbSplitSizeType.Items.Add("Bytes");
            cmbSplitSizeType.Items.Add("Kilo Bytes");
            cmbSplitSizeType.Items.Add("Mega Bytes");
            cmbSplitSizeType.Items.Add("Giga Bytes");

            cmbSplitSizeType.SelectedIndex = 3;

            cmbSplitSize.Items.Add("Floppy 3.5\" 1457664 Bytes");
            cmbSplitSize.Items.Add("Zip-100 100 MBytes");
            cmbSplitSize.Items.Add("Zip-250 250 MBytes");
            cmbSplitSize.Items.Add("CD-650 650 MBytes");
            cmbSplitSize.Items.Add("CD-700 700 MBytes");
            cmbSplitSize.Items.Add("CD-800 800 MBytes");
            cmbSplitSize.Items.Add("CD-870 870 MBytes");
            cmbSplitSize.Items.Add("DVDR 4481 MBytes");
            cmbSplitSize.Items.Add(TranslateHelper.Translate("<Custom>"));
            CmbCustomInd = cmbSplitSize.Items.Count - 1;


            cmbSplitFnPattern.Items.Add(".part[d]");
            cmbSplitFnPattern.Items.Add(".[d]");
            cmbSplitFnPattern.Items.Add(".[ddd]");
            cmbSplitFnPattern.Items.Add(".part[a]");
            cmbSplitFnPattern.Items.Add(".[a]");
            cmbSplitFnPattern.Items.Add(".[aaa]");

            cmbSplitFnPattern.SelectedIndex = 0;

            RegistryHelper.FillComboBoxWithValues(ref cmbJoinFirstPart, "JoinFirstPartFile");
            RegistryHelper.FillComboBoxWithValues(ref cmbJoinOutputFile, "JoinOutputFile");
            RegistryHelper.FillComboBoxWithValues(ref cmbMD5InputFile, "MD5InputFile");
            RegistryHelper.FillComboBoxWithValues(ref cmbMD5Signature, "MD5Value");

            RegistryHelper.FillComboBoxWithValues(ref cmbMD5ComparisonFile, "MD5InputFile");
            RegistryHelper.FillComboBoxWithValues(ref cmbMD5ComparisonSignature, "MD5Value");

            RegistryHelper.FillComboBoxWithValues(ref cmbSplitInputFile, "SplitInputFile");
            RegistryHelper.FillComboBoxWithValues(ref cmbSplitOutputFolder, "SplitOutputFolder");

            
            if (ArgsHelper.FromWindowsExplorer)
            {
                if (ArgsHelper.Join)
                {
                    tabControl1.SelectedIndex  = 1;
                    cmbJoinFirstPart.Text = Module.args[0];

                    cmbJoinFirstPart_SelectedIndexChanged(null, null);
                }
                else if (ArgsHelper.Split)
                {
                    tabControl1.SelectedIndex= 0;
                    cmbSplitInputFile.Text = Module.args[0];

                    cmbSplitInputFile_SelectedIndexChanged(null, null);
                }                
            }
            else if (Module.IsExtensionJoin)
            {
                tabControl1.SelectedIndex = 1;
                cmbJoinFirstPart.Text = Module.args[1];

                cmbJoinFirstPart_SelectedIndexChanged(null, null);

            }

            cmbSplitWhenDone.Items.Add(TranslateHelper.Translate("Shutdown"));
            cmbSplitWhenDone.Items.Add(TranslateHelper.Translate("Sleep"));
            cmbSplitWhenDone.Items.Add(TranslateHelper.Translate("Hibernate"));
            cmbSplitWhenDone.Items.Add(TranslateHelper.Translate("Logoff"));
            cmbSplitWhenDone.Items.Add(TranslateHelper.Translate("Lock Workstation"));
            cmbSplitWhenDone.Items.Add(TranslateHelper.Translate("Restart"));
            cmbSplitWhenDone.Items.Add(TranslateHelper.Translate("Exit Application"));
            cmbSplitWhenDone.Items.Add(TranslateHelper.Translate("Do Nothing"));
            cmbSplitWhenDone.Items.Add(TranslateHelper.Translate("Explore Output File"));

            cmbSplitWhenDone.SelectedIndex = 7;

            cmbJoinWhenDone.Items.Add(TranslateHelper.Translate("Shutdown"));
            cmbJoinWhenDone.Items.Add(TranslateHelper.Translate("Sleep"));
            cmbJoinWhenDone.Items.Add(TranslateHelper.Translate("Hibernate"));
            cmbJoinWhenDone.Items.Add(TranslateHelper.Translate("Logoff"));
            cmbJoinWhenDone.Items.Add(TranslateHelper.Translate("Lock Workstation"));
            cmbJoinWhenDone.Items.Add(TranslateHelper.Translate("Restart"));
            cmbJoinWhenDone.Items.Add(TranslateHelper.Translate("Exit Application"));
            cmbJoinWhenDone.Items.Add(TranslateHelper.Translate("Do Nothing"));
            cmbJoinWhenDone.Items.Add(TranslateHelper.Translate("Explore Output File"));

            cmbJoinWhenDone.SelectedIndex = 7;
            
            if (Module.Portable)
            {
                chkSplitEmail.Enabled = false;
            }

            if (!Module.Portable)
            {
                chkSplitEncrypt.Checked = RegistryHelper.GetKeyValue("SplitEncrypt") == bool.TrueString;
                chkSplitCompress.Checked = RegistryHelper.GetKeyValue("SplitCompress") == bool.TrueString;
                chkSplitEmail.Checked = RegistryHelper.GetKeyValue("SplitEmail") == bool.TrueString;
                chkSplitExplore.Checked = RegistryHelper.GetKeyValue("SplitExplore") != bool.FalseString;
                chkSplitShutdown.Checked = RegistryHelper.GetKeyValue("SplitShutdown") == bool.TrueString;
                chkSplitTimestamp.Checked = RegistryHelper.GetKeyValue("SplitTimestamp") == bool.TrueString;
                chkSplitDelete.Checked = RegistryHelper.GetKeyValue("SplitDelete") == bool.TrueString;

                chkJoinDelete.Checked = RegistryHelper.GetKeyValue("JoinDelete") == bool.TrueString;
                chkJoinExplore.Checked = RegistryHelper.GetKeyValue("JoinExplore") != bool.FalseString;
                chkJoinShutdown.Checked = RegistryHelper.GetKeyValue("JoinShutdown") == bool.TrueString;
                chkJoinSpecifyFiles.Checked = RegistryHelper.GetKeyValue("JoinSpecifyFiles") == bool.TrueString;
                chkJoinTimeStamp.Checked = RegistryHelper.GetKeyValue("JoinTimeStamp") == bool.TrueString;

                checkForNewVersionEachWeekToolStripMenuItem.Checked = ((RegistryHelper.GetKeyValue("CheckWeek") == bool.TrueString)
                    || (RegistryHelper.GetKeyValue("CheckWeek") == string.Empty));

                string swn = RegistryHelper.GetKeyValue("SplitWhenDone");

                if (swn != string.Empty)
                {
                    try
                    {
                        cmbSplitWhenDone.SelectedIndex = int.Parse(swn);
                    }
                    catch { }
                }

                string jwn = RegistryHelper.GetKeyValue("JoinWhenDone");

                if (jwn != string.Empty)
                {
                    try
                    {
                        cmbJoinWhenDone.SelectedIndex = int.Parse(jwn);
                    }
                    catch { }
                }

                string selected_tab = RegistryHelper.GetKeyValue("SelectedTab");

                if (!ArgsHelper.FromWindowsExplorer && !Module.IsExtensionJoin && !Module.IsFromOpenWith)
                {
                    tabControl1.SelectedIndex = selected_tab != string.Empty ? int.Parse(selected_tab) : 0;
                }

                cmbSplitSizeType.SelectedIndex = RegistryHelper.GetKeyValue("SplitSizeType") != string.Empty ? int.Parse(RegistryHelper.GetKeyValue("SplitSizeType")) : 3;
                cmbSplitSize.Text = RegistryHelper.GetKeyValue("SplitSize");
                cmbSplitFnPattern.SelectedIndex = RegistryHelper.GetKeyValue("SplitFnPattern") != string.Empty ? int.Parse(RegistryHelper.GetKeyValue("SplitFnPattern")) : 0;
                nudEqualParts.Value = RegistryHelper.GetKeyValue("SplitEqualParts") != string.Empty ? int.Parse(RegistryHelper.GetKeyValue("SplitEqualParts")) : 8;

                chkSplitSize.Checked = RegistryHelper.GetKeyValue("SplitBySize") != bool.FalseString;
                chkSpitNumberParts.Checked = RegistryHelper.GetKeyValue("SplitNumberParts") == bool.TrueString;

                showMessageOnSucessToolStripMenuItem.Checked = ((RegistryHelper.GetKeyValue("ShowMessageOnSucess") == bool.TrueString)
                    || (RegistryHelper.GetKeyValue("ShowMessageOnSucess") == string.Empty));

            }
            this.Text = Module.ApplicationTitle;

            this.Icon = Properties.Resources.split_file_transp_48b;

            DownloadSuggestionsHelper ds = new DownloadSuggestionsHelper();
            ds.SetupDownloadMenuItems(downloadToolStripMenuItem);

            if (Module.Portable)
            {
                languageToolStripMenuItem.Visible = false;
                setUpdateProxyToolStripMenuItem.Visible = false;
            }

            // Custom Version 2.2019 start

            //downloadToolStripMenuItem.Visible = false;
            //languageToolStripMenuItem.Visible = false;
            //dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Visible = false;
            //visit4dotsSoftwareWebsiteToolStripMenuItem.Visible = false;
            //followUsOnTwitterToolStripMenuItem.Visible = false;

            //end

            ResizeControls();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RegistryHelper.FixRegistry();

            SetupOnLoad();

            if (!Module.Portable && checkForNewVersionEachWeekToolStripMenuItem.Checked)
            {
                UpdateHelper.InitializeCheckVersionWeek();
            }

            if (Module.IsFromOpenWith)
            {
                AddFileFromWindowsExplorer(Module.args[0]);
            }            
        }

        private void cmbSplitSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkSplitSize.Checked = true;
            chkSpitNumberParts.Checked = false;

            if (cmbSplitSize.SelectedIndex != cmbSplitSize.Items.Count - 1)
            {
                //cmbSplitSizeType.Text = "";

                cmbSplitSizeType.SelectedIndex = 0;
            }
        }

        private void bwSplit_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {            
            int progr = 0;

            if (e.UserState is ProgressChange)
            {
                ProgressChange pc = (ProgressChange)e.UserState;
                progr = pc.ChunkNum;

                double ms = pc.Elapsed.TotalSeconds;

                int time_remaining = (int)((progressBar1.Maximum-progr) * (int)ms) / progr;

                TimeSpan ts_remaining = new TimeSpan(0, 0, time_remaining);

                string ctxt = "";

                if (ts_remaining.Hours > 0)
                {
                    ctxt = ts_remaining.Hours.ToString("D2") + " : ";
                }

                ctxt += ts_remaining.Minutes.ToString("D2") + " : " + ts_remaining.Seconds.ToString("D2");
                progressBar1.CustomText = ctxt;
            }
            else
            {
                progr = (int)e.UserState;
            }

            //progressBar1.CustomText= progr.ToString();

            try
            {
                if (progressBar1.Maximum == 0)
                {
                    progressBar1.Maximum = progr;
                }
                else
                {
                    progressBar1.Value = progr;
                }
            }
            catch { }

            this.Invalidate();
        }

        private string splitfile = "";
        private long chunksize = 0;
        private string splitfolder = "";
        private int splitfnind = 0;
        private bool split_keep_timestamp = false;
        private bool split_delete_afterwards = false;
        private DateTime split_dtcreated = DateTime.Now;
        private DateTime split_dtupdated = DateTime.Now;
        private bool split_equal_parts = false;
        private int split_equal_parts_num = 0;
        private bool split_compress = false;
        private bool split_encrypt = false;
        private string split_encryption_password = "";

        private void btnSplit_Click(object sender, EventArgs e)
        {
            frmOverwrite.DefaultOverwriteOption = OverwriteOption.Ask;

            RegistryHelper.SetKeyValue("ShowMessageOnSucess", showMessageOnSucessToolStripMenuItem.Checked.ToString());


                if (tabControl1.SelectedIndex == 1)
                {
                    btnJoin_Click(null, null);
                    return;
                }
                else if (tabControl1.SelectedIndex == 2)
                {
                    return;
                }

                if (cmbSplitInputFile.Text.Trim() == String.Empty || !System.IO.File.Exists(cmbSplitInputFile.Text))
                {
                    Module.ShowMessage("Please specify a valid File to Split !");
                    return;
                }

                if (cmbSplitOutputFolder.Text.Trim() == String.Empty || !System.IO.Directory.Exists(cmbSplitOutputFolder.Text))
                {
                    Module.ShowMessage("Please specify a valid Destination Folder !");
                    return;
                }

                progressBar1.Maximum = 0;
                progressBar1.Value = 0;

                splitfile = cmbSplitInputFile.Text;

                bool found = false;
                int cmbind = 0;

                for (int k = 0; k < cmbSplitSize.Items.Count; k++)
                {
                    if (cmbSplitSize.Items[k].ToString() == cmbSplitSize.Text.Trim() && k != CmbCustomInd)
                    {
                        found = true;
                        cmbind = k;
                    }
                }

            //int isize;
            long isize;
            if (chkSplitSize.Checked)
                {
                    if (!found)
                    {
                    //if (!int.TryParse(cmbSplitSize.Text, out isize))
                    if (!long.TryParse(cmbSplitSize.Text, out isize))
                    {
                            Module.ShowMessage("Please specify a valid Split File Size !");
                            cmbSplitSize.Focus();
                            return;
                        }
                        else
                        {
                            if (long.Parse(cmbSplitSize.Text) == 0)
                            {
                                Module.ShowMessage("Please specify a valid Split File Size !");
                                cmbSplitSize.Focus();
                                return;
                            }

                            if (cmbSplitSizeType.SelectedIndex == 0)
                            {
                                Module.ShowMessage("Please specify if the Split File Size will be Bytes, Mega Bytes e.t.c.");
                                cmbSplitSizeType.Focus();
                                return;
                            }
                            else
                            {
                                if (cmbSplitSizeType.SelectedIndex == 1)
                                {
                                    chunksize = isize;
                                }
                                else if (cmbSplitSizeType.SelectedIndex == 2)
                                {
                                    chunksize = isize * 1024;
                                }
                                else if (cmbSplitSizeType.SelectedIndex == 3)
                                {
                                    chunksize = isize * 1024 * 1024;
                                }
                                else if (cmbSplitSizeType.SelectedIndex == 4)
                                {
                                    chunksize = isize * 1024 * 1024 * 1024;

                                    if (chunksize < 0)
                                    {
                                        chunksize = (-1) * chunksize;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (cmbSplitSize.SelectedIndex == 0)
                        {
                            chunksize = 1457664;
                        }
                        else if (cmbSplitSize.SelectedIndex == 1)
                        {
                            chunksize = 100 * 1024 * 1024;
                        }
                        else if (cmbSplitSize.SelectedIndex == 2)
                        {
                            chunksize = 250 * 1024 * 1024;
                        }
                        else if (cmbSplitSize.SelectedIndex == 3)
                        {
                            chunksize = 650 * 1024 * 1024;
                        }
                        else if (cmbSplitSize.SelectedIndex == 4)
                        {
                            chunksize = 700 * 1024 * 1024;
                        }
                        else if (cmbSplitSize.SelectedIndex == 5)
                        {
                            chunksize = 800 * 1024 * 1024;
                        }
                        else if (cmbSplitSize.SelectedIndex == 6)
                        {
                            chunksize = 870 * 1024 * 1024;
                        }
                        else if (cmbSplitSize.SelectedIndex == 7)
                        {
                            chunksize = 4698669056;//4481 * 1024 * 1024;
                        }
                        /*
                    else if (cmbSplitSize.SelectedIndex == 2)
                    {

                    }
                    cmbSplitSize.Items.Add("Floppy 3.5\" 1457664 Bytes");
                    cmbSplitSize.Items.Add("Zip-100 100 MBytes");
                    cmbSplitSize.Items.Add("Zip-250 250 MBytes");
                    cmbSplitSize.Items.Add("CD-650 650 MBytes");
                    cmbSplitSize.Items.Add("CD-700 700 MBytes");
                    cmbSplitSize.Items.Add("CD-800 800 MBytes");
                    cmbSplitSize.Items.Add("CD-870 870 MBytes");
                    cmbSplitSize.Items.Add("DVDR 4481 MBytes");*/
                    }
                }

                //chunksize = 1000000;
                splitfolder = cmbSplitOutputFolder.Text;
                splitfnind = cmbSplitFnPattern.SelectedIndex;
                split_delete_afterwards = chkSplitDelete.Checked;
                split_keep_timestamp = chkSplitTimestamp.Checked;

                if (split_keep_timestamp)
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(cmbSplitInputFile.Text);
                    split_dtcreated = fi.CreationTime;
                    split_dtupdated = fi.LastWriteTime;
                }

                split_equal_parts = chkSpitNumberParts.Checked;

                if (split_equal_parts)
                {
                    split_equal_parts_num = (int)nudEqualParts.Value;
                }

                split_compress = chkSplitCompress.Checked;
                split_encrypt = chkSplitEncrypt.Checked;

            //Module.ShowMessage(cmbSplitInputFile.Items.Count.ToString());
            //Module.ShowMessage(cmbSplitOutputFolder.Items.Count.ToString());

            cmbSplitInputFile.Text = splitfile;

            RegistryHelper.AddValueToComboBox(ref cmbSplitInputFile, "SplitInputFile");

            cmbSplitOutputFolder.Text = splitfolder;

            RegistryHelper.AddValueToComboBox(ref cmbSplitOutputFolder, "SplitOutputFolder");

            //Module.ShowMessage(cmbSplitInputFile.Items.Count.ToString());
            //Module.ShowMessage(cmbSplitOutputFolder.Items.Count.ToString());

            if (split_encrypt)
                {
                    frmEncryptionPassword fe = new frmEncryptionPassword();

                    if (fe.ShowDialog() == DialogResult.OK)
                    {
                        split_encryption_password = fe.txtPassword.Text;
                    }
                    else
                    {
                        split_encrypt = false;
                        return;
                    }
                }

                btnSplit.Enabled = false;

            btnCancel.Visible = true;
            lblTimeElapsed.Visible = true;
            lblTimeElapsedDesc.Visible = true;
            lblTimeRemaining.Visible = true;
            lblTimeRemainingDesc.Visible = true;
            TickCount = 0;
            timElapsed.Enabled = true;

            lblTimeElapsed.Text = "";
            lblTimeRemaining.Text = "";

            bwSplit.RunWorkerAsync();                                   
        }

        private void bwSplit_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SplitHelper.SplitFile(splitfile, chunksize, split_equal_parts, split_equal_parts_num, splitfolder, splitfnind, split_delete_afterwards, split_keep_timestamp, split_dtcreated, split_dtupdated, split_compress, split_encrypt, split_encryption_password);

                if (!frmMain.Instance.bwSplit.CancellationPending)
                {
                    e.Result = "Success";
                }
            }
            catch (Exception ex)
            {
                e.Result = "Error\n" + ex.ToString();
            }
            
        }

        private void chkSpitNumberParts_CheckedChanged(object sender, EventArgs e)
        {
            return;
            if (chkSpitNumberParts.Checked)
            {
                chkSplitSize.Checked = false;
            }
            else if (!chkSpitNumberParts.Checked && !chkSplitSize.Checked)
            {
                chkSpitNumberParts.Checked = true;
            }
        }

        private void chkSplitSize_CheckedChanged(object sender, EventArgs e)
        {
            return;

            if (chkSplitSize.Checked)
            {
                chkSpitNumberParts.Checked= false;
            }
            else if (!chkSpitNumberParts.Checked && !chkSplitSize.Checked)
            {
                chkSplitSize.Checked = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnJoinFirstPartBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "First Split Part Files (*.part0,*.part00,*.0,*.00,*.000,*.parta,*.a,*._a,.*.__a)" +
            "|*.part0;*.part00;*.0;*.00;*.000;*.parta;*.a;*._a;.*__a| All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int epos = openFileDialog1.FileName.LastIndexOf(".");
                cmbJoinFirstPart.Text = openFileDialog1.FileName;

                if (epos > 0)
                {
                    try
                    {
                        if (cmbJoinOutputFile.Text.Trim() == string.Empty)
                        {
                            cmbJoinOutputFile.Text = openFileDialog1.FileName.Substring(0, epos);
                        }
                    }
                    catch { }
                }
            }
        }

        private void btnJoinBrowseOutputFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            if (cmbJoinFirstPart.Text != String.Empty && System.IO.File.Exists(cmbJoinFirstPart.Text))
            {
                openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(cmbJoinFirstPart.Text);
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cmbJoinOutputFile.Text = openFileDialog1.FileName;
            }
        }

        private bool join_delete_files = false;
        private bool join_keeptimestamp = false;
        List<string> join_files = new List<string>();
        private bool join_explicit_files = false;
        private string join_output_file = "";


        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (!chkJoinSpecifyFiles.Checked && (cmbJoinFirstPart.Text.Trim() == String.Empty || !System.IO.File.Exists(cmbJoinFirstPart.Text)))
            {
                Module.ShowMessage("Please specify a valid First Split Part File !");
                return;
            }

            if (cmbJoinOutputFile.Text.Trim() == String.Empty)
            {
                Module.ShowMessage("Please specify a valid Output File !");
                return;
            }

            progressBar1.Maximum = 0;
            progressBar1.Value = 0;

            join_delete_files = chkJoinDelete.Checked;
            join_keeptimestamp = chkJoinTimeStamp.Checked;
            join_explicit_files = chkJoinSpecifyFiles.Checked;

            join_output_file = cmbJoinOutputFile.Text;

            RegistryHelper.AddValueToComboBox(ref cmbJoinFirstPart, "JoinFirstPartFile");
            RegistryHelper.AddValueToComboBox(ref cmbJoinOutputFile, "JoinOutputFile");

            if (!chkJoinSpecifyFiles.Checked)
            {
                join_files = new List<string>();
                join_files.Add(cmbJoinFirstPart.Text);
            }
            else
            {
                frmSpecifyFiles f = new frmSpecifyFiles();
                for (int k = 0; k < join_files.Count; k++)
                {
                    f.txtSpecificFiles.Text += join_files[k] + "\r\n";
                }

                if (f.ShowDialog() == DialogResult.OK)
                {
                    join_files = new List<string>();

                    for (int k = 0; k < f.txtSpecificFiles.Lines.Length; k++)
                    {
                        join_files.Add(f.txtSpecificFiles.Lines[k]);
                    }
                }
                else
                {
                    return;
                }
            }

            btnSplit.Enabled = false;

            btnCancel.Visible = true;
            lblTimeElapsed.Visible = true;
            lblTimeElapsedDesc.Visible = true;
            lblTimeRemaining.Visible = true;
            lblTimeRemainingDesc.Visible = true;

            TickCount = 0;
            timElapsed.Enabled = true;

            lblTimeElapsed.Text = "";
            lblTimeRemaining.Text = "";

            bwJoin.RunWorkerAsync();
        }

        private void bwJoin_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                JoinHelper.JoinFiles(join_files, join_explicit_files, join_output_file, join_delete_files, join_keeptimestamp,"");

                if (!frmMain.Instance.bwJoin.CancellationPending)
                {
                    e.Result = "Success";
                }
            }
            catch (Exception ex)
            {
                e.Result = "Error\n" + ex.ToString();
            }
        }

        private void bwJoin_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {                     

            try
            {
                int progr = (int)e.UserState;

                if (progressBar1.Maximum == 0)
                {
                    progressBar1.Maximum = progr;
                }
                else
                {
                    progressBar1.Value = progr;
                }
            }
            catch { }
        }

        private void bwJoin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSplit.Enabled = true;

            timElapsed.Enabled = false;

            progressBar1.Value = 0;
            progressBar1.Maximum = 0;

            btnCancel.Visible = false;
            lblTimeElapsed.Visible = false;
            lblTimeElapsedDesc.Visible = false;
            lblTimeRemaining.Visible = false;
            lblTimeRemainingDesc.Visible = false;

            if (e.Result != null)
            {
                if (e.Result.ToString() == "Success")
                {
                    if (chkJoinShutdown.Checked)
                    {
                        ProcessJoinWhenFinished();
                        /*
                        frmShutdown f = new frmShutdown();
                        f.ShowDialog();
                        */
                    }
                    else
                    {
                        if (showMessageOnSucessToolStripMenuItem.Checked)
                        {
                            Module.ShowMessage("Files were Joined Successfully !");
                        }
                    }

                    /*
                    if (chkJoinExplore.Checked)
                    {
                        System.Diagnostics.Process.Start("explorer.exe", "/select,\"" + JoinHelper.JoinOutputFile + "\"");
                    }
                    */

                }
                else if (e.Result.ToString().StartsWith("Error"))
                {
                    Module.ShowError(TranslateHelper.Translate("An error occured !") + "\n\n" + e.Result.ToString());
                }
            }
        }

        private void bwSplit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSplit.Enabled = true;

            timElapsed.Enabled = false;

            progressBar1.Value = 0;
            progressBar1.Maximum = 0;

            btnCancel.Visible = false;
            lblTimeElapsed.Visible = false;
            lblTimeElapsedDesc.Visible = false;
            lblTimeRemaining.Visible = false;
            lblTimeRemainingDesc.Visible = false;

            if (e.Result != null)
            {
                if (e.Result.ToString() == "Success")
                {
                    if (chkSplitShutdown.Checked)
                    {
                        ProcessSplitWhenFinished();
                        /*
                        frmShutdown f = new frmShutdown();
                        f.ShowDialog();
                        */
                    }
                    else
                    {
                        if (showMessageOnSucessToolStripMenuItem.Checked)
                        {
                            Module.ShowMessage("File was Split Successfully !");
                        }
                    }
                    
                    /*
                    if (chkSplitExplore.Checked)
                    {
                        System.Diagnostics.Process.Start("explorer.exe", "/select,\"" + SplitHelper.FirstSplitPartFilePath + "\"");                                                               
                    }
                    */
                    if (chkSplitEmail.Checked)
                    {
                        frmEmail fe = new frmEmail();
                        fe.ShowDialog();
                    }
                }
                else if (e.Result.ToString().StartsWith("Error"))
                {
                    Module.ShowError(TranslateHelper.Translate("An error occured !") + "\n\n" + e.Result.ToString());
                }
            }            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }

        private void GetAsyncMD5FirstCombo(string filepath)
        {
            MD5Arg m5 = new MD5Arg();
            m5.FirstCombo = true;
            m5.Filepath = filepath;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                bwMD5.RunWorkerAsync(m5);

                while (bwMD5.IsBusy)
                {
                    Application.DoEvents();
                }
            }
            finally
            {
                this.Cursor = null;
            }
        }

        private void GetAsyncMD5SecondCombo(string filepath)
        {
            MD5Arg m5 = new MD5Arg();
            m5.FirstCombo = false;
            m5.Filepath = filepath;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                bwMD5.RunWorkerAsync(m5);

                while (bwMD5.IsBusy)
                {
                    Application.DoEvents();
                }
            }
            finally
            {
                this.Cursor = null;
            }
        }
        private void btnMD5InputFileBrowse_Click(object sender, EventArgs e)
        {                       
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GetAsyncMD5FirstCombo(openFileDialog1.FileName);
                //GetMD5FirstCombo(openFileDialog1.FileName);
            }    
        }

        private void GetMD5FirstCombo(string filepath)
        {
            string hash=GetMD5HashFromFile(filepath);

            MD5Result m5 = new MD5Result();
            m5.FirstCombo = true;
            m5.MD5Hash = hash;
            m5.Filepath = filepath;

            bwMD5.ReportProgress(0, m5);
            
            
            
        }

        private void GetMD5SecondCombo(string filepath)
        {
            string hash = GetMD5HashFromFile(filepath);

            MD5Result m5 = new MD5Result();
            m5.FirstCombo = false;
            m5.MD5Hash = hash;
            m5.Filepath = filepath;

            bwMD5.ReportProgress(0, m5);

            
        }


        protected string GetMD5HashFromFile(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private void btnMD5Copy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            if (cmbMD5Signature.Text != String.Empty)
            {
                Clipboard.SetText(cmbMD5Signature.Text);
            }
        }

        private void cmbMD5InputFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (SetResultMD5) return;
            
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbMD5InputFile.Text == String.Empty || !System.IO.File.Exists(cmbMD5InputFile.Text))
                {
                    Module.ShowMessage("Please specify a valid File !");
                    return;
                }

                //GetMD5FirstCombo(cmbMD5InputFile.Text);
                GetAsyncMD5FirstCombo(cmbMD5InputFile.Text);
            }
        }

        private void btnMD5ComparisonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            if (cmbMD5ComparisonSignature.Text != String.Empty)
            {
                Clipboard.SetText(cmbMD5ComparisonSignature.Text);
            }
        }

        private void btnMD5ComparisonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                GetAsyncMD5SecondCombo(openFileDialog1.FileName);
                //GetMD5SecondCombo(openFileDialog1.FileName);
            }
        }

        private void cmbMD5ComparisonFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (SetResultMD5) return;

            if (e.KeyCode == Keys.Enter)
            {
                if (cmbMD5ComparisonFile.Text == String.Empty || !System.IO.File.Exists(cmbMD5ComparisonFile.Text))
                {
                    Module.ShowMessage("Please specify a valid File !");
                    return;
                }

                //GetMD5SecondCombo(cmbMD5ComparisonFile.Text);
                GetAsyncMD5SecondCombo(cmbMD5ComparisonFile.Text);
            }
        }

        private void CompareMD5Signatures()
        {
            if (cmbMD5ComparisonSignature.Text != String.Empty && cmbMD5Signature.Text != String.Empty
                && cmbMD5ComparisonSignature.Text != cmbMD5Signature.Text)
            {
                Module.ShowMessage("The two Files have different MD5 Checksum Signatures !");
            }
            else if (cmbMD5ComparisonSignature.Text != String.Empty && cmbMD5Signature.Text != String.Empty
                && cmbMD5ComparisonSignature.Text == cmbMD5Signature.Text)
            {
                Module.ShowMessage("The two Files have the same MD5 Checksum Signatures !");
            }
        }


        #region Downloads

        private void downloadFreePDFPasswordRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pdfdocmerge.com/pdf_password_remover/");
        }

        private void downloadFreePDFMetadataEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pdfdocmerge.com/pdf_metadata_editor/");
        }

        private void downloadPDFEncrypterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pdfdocmerge.com/pdfencrypter/");
        }

        private void downloadMultipleSearchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.multiplereplace.com");
        }

        private void downloadPDFMergeSplitToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.pdfdocmerge.com/pdfmergesplittool/");

        }

        private void downloadFreeFileUnlockerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.freefileunlocker.com");
        }

        private void downloadImgTransformerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.imgtransformer.com");
        }

        private void downloadFreeImagemapperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/imagemapper2/");
        }

        private void downloadCopyPathToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/copypathtoclipboard/");
        }

        private void downloadCopyTextContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/copytextcontents/");
        }

        private void downloadOpenCommandPromptHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/open_command_prompt_here/");
        }

        private void downloadFreeColorwheelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/colorwheel/");
        }

        private void visit4dotsSoftwareWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com");
        }


        private void downloadDocusTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com/freedocustree/");
        }
        
#endregion

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            frmUninstallQuestionnaire f = new frmUninstallQuestionnaire(false);

            f.ShowDialog();
            */

            System.Diagnostics.Process.Start("https://www.4dots-software.com/support/bugfeature.php?app=" + System.Web.HttpUtility.UrlEncode(Module.ShortApplicationTitle));
        }

        private void visit4dotsSoftwareWebsiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com");
        }

        #region Localization Old

        /*
        private void AddLanguageMenuItems()
        {
            for (int k = 0; k < frmLanguage.LangCodes.Count; k++)
            {
                ToolStripMenuItem ti = new ToolStripMenuItem();
                ti.Text = frmLanguage.LangDesc[k];
                ti.Tag = frmLanguage.LangCodes[k];
                ti.Image = frmLanguage.LangImg[k];

                if (Module.SelectedLanguage == frmLanguage.LangCodes[k])
                {
                    ti.Checked = true;
                }

                ti.Click += new EventHandler(tiLang_Click);
                languageToolStripMenuItem.DropDownItems.Add(ti);
            }
        }

        void tiLang_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ti = (ToolStripMenuItem)sender;
            string langcode = ti.Tag.ToString();
            ChangeLanguage(langcode);

            for (int k = 0; k < languageToolStripMenuItem.DropDownItems.Count; k++)
            {
                ToolStripMenuItem til = (ToolStripMenuItem)languageToolStripMenuItem.DropDownItems[k];
                if (til == ti)
                {
                    til.Checked = true;
                }
                else
                {
                    til.Checked = false;
                }
            }
        }

        private void ChangeLanguage(string language_code)
        {
            if (Module.Portable)
            {
                if (language_code == "en-US")
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture =
                        System.Globalization.CultureInfo.InvariantCulture;

                    Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

                }
                else
                {

                    try
                    {
                        System.Threading.Thread.CurrentThread.CurrentUICulture = new
                        System.Globalization.CultureInfo(language_code);

                        Application.CurrentCulture = new System.Globalization.CultureInfo(language_code);
                    }
                    catch (Exception ex)
                    {
                        Module.ShowError(ex);
                    }
                }
            }
            else
            {
                RegistryKey key = Registry.CurrentUser;
                try
                {
                    key = key.OpenSubKey("SOFTWARE\\4dots Software\\Split Byte", true);

                    key.SetValue("Language", language_code);
                    Program.SetLanguage();
                    key.SetValue("Menu Item Caption1", TranslateHelper.Translate("Split File with Split Byte"));
                    key.SetValue("Menu Item Caption2", TranslateHelper.Translate("Join Files with Split Byte"));
                }
                catch (Exception ex)
                {
                    Module.ShowError(ex);
                    return;
                }
                finally
                {
                    key.Close();
                }
            }
            this.Controls.Clear();

            InitializeComponent();                       

            SetupOnLoad();

        }
        */
        #endregion

        private void tabPage1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                IsDragging = true;
                e.Effect = DragDropEffects.All;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tabPage1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] filez = (string[])e.Data.GetData(DataFormats.FileDrop);
                cmbSplitInputFile.Text = filez[0];                
            }
        }

        private bool IsDragging = false;

        private void tabPage2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] filez = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (filez.Length == 1)
                {
                    cmbJoinFirstPart.Text = filez[0];
                }
                else
                {
                    chkJoinSpecifyFiles.Checked = true;
                    
                    for (int k = 0; k < filez.Length; k++)
                    {
                        join_files.Add(filez[k]);
                    }
                }
            }
        }

        private void tabPage2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                IsDragging = true;
                e.Effect = DragDropEffects.All;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tabControl1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                IsDragging = true;
                e.Effect = DragDropEffects.All;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tabControl1_DragDrop(object sender, DragEventArgs e)
        {
            if (tabControl1.TabIndex == 0)
            {
                tabPage1_DragDrop(sender, e);
            }
            else
            {
                tabPage2_DragDrop(sender, e);
            }
        }

        private void tabPage1_DragOver(object sender, DragEventArgs e)
        {
            IsDragging = true;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void tabPage2_DragOver(object sender, DragEventArgs e)
        {
            IsDragging = true;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void tabControl1_DragOver(object sender, DragEventArgs e)
        {
            IsDragging = true;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void nudEqualParts_ValueChanged(object sender, EventArgs e)
        {
            chkSpitNumberParts.Checked = true;
            chkSplitSize.Checked = false;
        }

        private void cmbSplitSize_TextChanged(object sender, EventArgs e)
        {
            chkSplitSize.Checked = true;
            chkSpitNumberParts.Checked = false;
        }

        private void cmbSplitSizeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkSplitSize.Checked = true;
            chkSpitNumberParts.Checked = false;
        }

        private void cmbSplitInputFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!System.IO.File.Exists(cmbSplitInputFile.Text))
                {
                    Module.ShowMessage("Please specify a valid Split Input File !");
                    return;
                }
                else
                {
                    if (cmbSplitOutputFolder.Text.Trim() == String.Empty)
                    {
                        cmbSplitOutputFolder.Text = System.IO.Path.GetDirectoryName(cmbSplitInputFile.Text);
                    }
                }
            }
        }

        private void cmbMD5InputFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SetResultMD5) return;
            
            if (RegistryHelper.AddingCombo) return;
            //GetMD5FirstCombo(cmbMD5InputFile.Text);
            GetAsyncMD5FirstCombo(cmbMD5InputFile.Text);
        }

        private void cmbMD5ComparisonFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SetResultMD5) return;

            if (RegistryHelper.AddingCombo) return;
            //GetMD5SecondCombo(cmbMD5ComparisonFile.Text);
            GetAsyncMD5SecondCombo(cmbMD5ComparisonFile.Text);
        }

        private void cmbSplitOutputFolder_SelectedIndexChanged(object sender, EventArgs e)
        {

            CheckSplitOutputFolder();
        }

        private bool CheckSplitOutputFolder()
        {
            if (cmbSplitOutputFolder.Text != String.Empty && !System.IO.Directory.Exists(cmbSplitOutputFolder.Text))
            {
                Module.ShowMessage("Please specify a valid Split File Output Folder !");
                cmbSplitOutputFolder.Text = "";
                return false;
            }

            return true;
        }

        private void cmbSplitOutputFolder_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                CheckSplitOutputFolder();
                
            }
        }

        private bool InKeyUp = false;
        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void cmbSplitInputFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbSplitOutputFolder.Text.Trim() == String.Empty)
            //{
                cmbSplitOutputFolder.Text = System.IO.Path.GetDirectoryName(cmbSplitInputFile.Text);
            //}
        }

        private void cmbJoinFirstPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cmbJoinFirstPart.Text.LastIndexOf(".");

            if (ind > 0)
            {
                //if (cmbJoinOutputFile.Text.Trim() == String.Empty)
                //{
                    cmbJoinOutputFile.Text = cmbJoinFirstPart.Text.Substring(0, ind);
                //}
            }

            try
            {
                if (cmbJoinFirstPart.Text != string.Empty)
                {
                    cmbJoinOutputFile.Text = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(cmbJoinFirstPart.Text), System.IO.Path.GetFileNameWithoutExtension(cmbJoinFirstPart.Text));
                }
            }
            catch { }
        }

        private void bwMD5_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is MD5Arg)
            {
                MD5Arg m5 = (MD5Arg)e.Argument;

                if (m5.FirstCombo)
                {
                    GetMD5FirstCombo(m5.Filepath);
                }
                else
                {
                    GetMD5SecondCombo(m5.Filepath);
                }
            }

            
        }

        private bool SetResultMD5 = false;

        private void bwMD5_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                SetResultMD5 = true;

                if (e.UserState is MD5Result)
                {
                    MD5Result m5 = (MD5Result)e.UserState;

                    if (m5.FirstCombo)
                    {
                        cmbMD5InputFile.Text = m5.Filepath;

                        RegistryHelper.AddValueToComboBox(ref cmbMD5InputFile, "MD5InputFile");

                        cmbMD5Signature.Text = m5.MD5Hash;

                        RegistryHelper.AddValueToComboBox(ref cmbMD5Signature, "MD5Value");

                        CompareMD5Signatures();
                    }
                    else
                    {
                        cmbMD5ComparisonFile.Text = m5.Filepath;

                        RegistryHelper.AddValueToComboBox(ref cmbMD5ComparisonFile, "MD5InputFile");

                        cmbMD5ComparisonSignature.Text = m5.MD5Hash;

                        RegistryHelper.AddValueToComboBox(ref cmbMD5ComparisonSignature, "MD5Value");

                        CompareMD5Signatures();
                    }
                }
            }
            finally
            {
                SetResultMD5 = false;
            }
        }

        private void bwMD5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void splitByteUsersGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Module.SelectedLanguage == "en-US")
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\SplitByte - Users Manual.chm");
            }
            else
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\" + Module.SelectedLanguage + "\\SplitByte - Users Manual.chm");
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                btnSplit.Visible = true;
                btnSplit.Text = TranslateHelper.Translate("&Split");
                cmbSplitInputFile.Focus();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                btnSplit.Visible = true;
                btnSplit.Text = TranslateHelper.Translate("&Join");
                cmbJoinFirstPart.Focus();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                btnSplit.Visible = false;
                cmbMD5InputFile.Focus();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryHelper.SetKeyValue("ShowMessageOnSucess", showMessageOnSucessToolStripMenuItem.Checked.ToString());
            RegistryHelper.SetKeyValue("SplitEncrypt", chkSplitEncrypt.Checked.ToString());
            RegistryHelper.SetKeyValue("SplitCompress", chkSplitCompress.Checked.ToString());
            RegistryHelper.SetKeyValue("SplitEmail",chkSplitEmail.Checked.ToString());
            RegistryHelper.SetKeyValue("SplitExplore",chkSplitExplore.Checked.ToString());
            RegistryHelper.SetKeyValue("SplitShutdown",chkSplitShutdown.Checked.ToString());
            RegistryHelper.SetKeyValue("SplitTimestamp", chkSplitTimestamp.Checked.ToString());
            RegistryHelper.SetKeyValue("SplitDelete", chkSplitDelete.Checked.ToString());

            RegistryHelper.SetKeyValue("JoinDelete", chkJoinDelete.Checked.ToString());
            RegistryHelper.SetKeyValue("JoinExplore", chkJoinExplore.Checked.ToString());
            RegistryHelper.SetKeyValue("JoinShutdown", chkJoinShutdown.Checked.ToString());
            RegistryHelper.SetKeyValue("JoinSpecifyFiles", chkJoinSpecifyFiles.Checked.ToString());
            RegistryHelper.SetKeyValue("JoinTimeStamp", chkJoinTimeStamp.Checked.ToString());

            RegistryHelper.SetKeyValue("SelectedTab", tabControl1.SelectedIndex.ToString());

            RegistryHelper.SetKeyValue("SplitBySize", chkSplitSize.Checked.ToString());
            RegistryHelper.SetKeyValue("SplitNumberParts", chkSpitNumberParts.Checked.ToString());

            RegistryHelper.SetKeyValue("SplitSizeType", cmbSplitSizeType.SelectedIndex.ToString());
            RegistryHelper.SetKeyValue("SplitSize", cmbSplitSize.Text);
            RegistryHelper.SetKeyValue("SplitFnPattern", cmbSplitFnPattern.SelectedIndex.ToString());
            RegistryHelper.SetKeyValue("SplitEqualParts", ((int)(nudEqualParts.Value)).ToString());

            RegistryHelper.SetKeyValue("CheckWeek", checkForNewVersionEachWeekToolStripMenuItem.Checked.ToString());

        }

        private void tabPage3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] filez = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (filez.Length == 1)
                {
                    if (cmbMD5InputFile.Text.Trim() == string.Empty)
                    {
                        GetAsyncMD5FirstCombo(filez[0]);
                    }
                    else if (cmbMD5ComparisonFile.Text.Trim() == string.Empty)
                    {
                        GetAsyncMD5SecondCombo(filez[0]);
                    }
                    else // both used
                    {
                        GetAsyncMD5FirstCombo(filez[0]);
                    }
                }
                else
                {                    
                        GetAsyncMD5FirstCombo(filez[0]);
                        GetAsyncMD5SecondCombo(filez[1]);
                }
            }
        }

        private void tabPage3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                IsDragging = true;
                e.Effect = DragDropEffects.All;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tabPage3_DragOver(object sender, DragEventArgs e)
        {
            IsDragging = true;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        #region Help Menu

        private void downloadLatestVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Module.DownloadURL);
        }

        private void dotsSoftwarePRODUCTCATALOGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(Application.StartupPath + "\\4dots-Software-PRODUCT-CATALOG-2015.pdf");
            System.Diagnostics.Process.Start("http://www.4dots-software.com/downloads/4dots-Software-PRODUCT-CATALOG-2015.pdf");
        }

        private void visit4dotsSoftwareWebsiteToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com");
        }

        private void followUsOnTwitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitter.com/4dotsSoftware");
        }

        private void setUpdateProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pr = new System.Diagnostics.Process();
            pr.StartInfo.FileName = Application.StartupPath + "\\4dotsLanguageDownloader.exe";
            pr.StartInfo.Arguments = "-setproxy";
            pr.Start();

            System.Threading.Thread.Sleep(300);

            while (!pr.HasExited)
            {
                Application.DoEvents();
            }

            if (pr.ExitCode != 0)
            {
                Module.ShowMessage("Error Could not set Update Proxy !");
            }
        }

        private void helpGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Module.HelpURL);
        }

        #endregion

        #region Localization

        private void AddLanguageMenuItems()
        {
            for (int k = 0; k < frmLanguage.LangCodes.Count; k++)
            {
                ToolStripMenuItem ti = new ToolStripMenuItem();
                ti.Text = frmLanguage.LangDesc[k];
                ti.Tag = frmLanguage.LangCodes[k];
                ti.Image = frmLanguage.LangImg[k];

                if (RegistryHelper.GetKeyValue("Language") == frmLanguage.LangCodes[k])
                {
                    ti.Checked = true;
                }

                ti.Click += new EventHandler(tiLang_Click);

                if (k < 25)
                {
                    languages1ToolStripMenuItem.DropDownItems.Add(ti);
                }
                else
                {
                    languages2ToolStripMenuItem.DropDownItems.Add(ti);
                }

                //languageToolStripMenuItem.DropDownItems.Add(ti);
            }
        }

        void tiLang_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ti = (ToolStripMenuItem)sender;
            string langcode = ti.Tag.ToString();
            ChangeLanguage(langcode);

            //for (int k = 0; k < languageToolStripMenuItem.DropDownItems.Count; k++)
            for (int k = 0; k < languages1ToolStripMenuItem.DropDownItems.Count; k++)
            {
                ToolStripMenuItem til = (ToolStripMenuItem)languages1ToolStripMenuItem.DropDownItems[k];
                if (til == ti)
                {
                    til.Checked = true;
                }
                else
                {
                    til.Checked = false;
                }
            }

            for (int k = 0; k < languages2ToolStripMenuItem.DropDownItems.Count; k++)
            {
                ToolStripMenuItem til = (ToolStripMenuItem)languages2ToolStripMenuItem.DropDownItems[k];
                if (til == ti)
                {
                    til.Checked = true;
                }
                else
                {
                    til.Checked = false;
                }
            }
        }

        private void ChangeLanguage(string language_code)
        {
            RegistryHelper.SetKeyValue("Language", language_code);
            frmLanguage.SetLanguage();

            bool maximized = (this.WindowState == FormWindowState.Maximized);
            this.WindowState = FormWindowState.Normal;

            //SaveSizeLocation();

            this.Controls.Clear();

            InitializeComponent();

            SetupOnLoad();

            if (maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }                        
            
            /*
            bool t1e = timer1.Enabled;
            bool t2e = timer2.Enabled;
            bool t3e = timer3.Enabled;
            */

            /*
            timer1.Enabled = t1e;
            timer2.Enabled = t2e;
            timer3.Enabled = t3e;
            */
        }

        #endregion

        private void cmbJoinFirstPart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbJoinFirstPart.Text != string.Empty)
                {
                    cmbJoinOutputFile.Text = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(cmbJoinFirstPart.Text), System.IO.Path.GetFileNameWithoutExtension(cmbJoinFirstPart.Text));
                }
            }
            catch { }
        }

        private void cmbSplitInputFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSplitOutputFolder.Text = System.IO.Path.GetDirectoryName(cmbSplitInputFile.Text);
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;

            bwJoin.CancelAsync();
            bwSplit.CancelAsync();

            while (bwJoin.IsBusy)
            {
                Application.DoEvents();
            }

            while (bwSplit.IsBusy)
            {
                Application.DoEvents();
            }

            btnCancel.Enabled = true;

            Module.ShowMessage("Operation was Cancelled !");
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            if (e.KeyChar == (char)Keys.Escape) 
            {
                if (InKeyUp) return;

                try
                {

                    InKeyUp = true;

                    bwJoin.CancelAsync();
                    bwSplit.CancelAsync();

                    while (bwJoin.IsBusy)
                    {
                        Application.DoEvents();
                    }

                    while (bwSplit.IsBusy)
                    {
                        Application.DoEvents();
                    }

                    Module.ShowMessage("Operation was Cancelled !");

                }
                finally
                {
                    InKeyUp = false;
                }
            }
        }

        private int TickCount = 0;
        private void timElapsed_Tick(object sender, EventArgs e)
        {
            TickCount++;

            TimeSpan ts = new TimeSpan(0, 0, TickCount);

            lblTimeElapsed.Text = (ts.Days > 0 ? ts.Days.ToString() : "") + ts.Hours.ToString("D2") + ":" + ts.Minutes.ToString("D2") + ":" + ts.Seconds.ToString("D2");

            try
            {
                decimal d1 = (decimal)TickCount;
                decimal d2 = (decimal)progressBar1.Value;
                decimal d3 = (decimal)progressBar1.Maximum;

                // tickcount pv
                //  x        max

                decimal d = (d3 * d1) / d2;
                int id = (int)d;

                int remaining = id - TickCount;

                TimeSpan tsrem = new TimeSpan(0, 0, remaining);

                lblTimeRemaining.Text = (tsrem.Days > 0 ? tsrem.Days.ToString() : "") + tsrem.Hours.ToString("D2") + ":" + tsrem.Minutes.ToString("D2") + ":" + tsrem.Seconds.ToString("D2");
            }
            catch { }

        }

        private void ProcessSplitWhenFinished()
        {
            if (chkSplitShutdown.Checked)
            {
                if (cmbSplitWhenDone.SelectedIndex == 0)
                {
                    ShutdownHelper.Shutdown();
                }
                else if (cmbSplitWhenDone.SelectedIndex == 1)
                {
                    ShutdownHelper.Sleep();
                }
                else if (cmbSplitWhenDone.SelectedIndex == 2)
                {
                    ShutdownHelper.Hibernate();
                }
                else if (cmbSplitWhenDone.SelectedIndex == 3)
                {
                    ShutdownHelper.Logoff();
                }
                else if (cmbSplitWhenDone.SelectedIndex == 4)
                {
                    ShutdownHelper.Lock();
                }
                else if (cmbSplitWhenDone.SelectedIndex == 5)
                {
                    ShutdownHelper.Restart();
                }
                else if (cmbSplitWhenDone.SelectedIndex == 6)
                {
                    Application.Exit();
                }
                // do nothing
                else if (cmbSplitWhenDone.SelectedIndex == 7)
                {

                }
                else if (cmbSplitWhenDone.SelectedIndex == 8)
                {
                    System.Diagnostics.Process.Start("explorer.exe", "/select,\"" + SplitHelper.FirstSplitPartFilePath + "\"");

                    /*
                    string args = string.Format("/e, /select, \"{0}\"", FirstOutputFile);
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = "explorer";
                    info.UseShellExecute = true;
                    info.Arguments = args;
                    Process.Start(info);
                    */
                }
            }
        }

        private void ProcessJoinWhenFinished()
        {
            if (chkJoinShutdown.Checked)
            {
                if (cmbJoinWhenDone.SelectedIndex == 0)
                {
                    ShutdownHelper.Shutdown();
                }
                else if (cmbJoinWhenDone.SelectedIndex == 1)
                {
                    ShutdownHelper.Sleep();
                }
                else if (cmbJoinWhenDone.SelectedIndex == 2)
                {
                    ShutdownHelper.Hibernate();
                }
                else if (cmbJoinWhenDone.SelectedIndex == 3)
                {
                    ShutdownHelper.Logoff();
                }
                else if (cmbJoinWhenDone.SelectedIndex == 4)
                {
                    ShutdownHelper.Lock();
                }
                else if (cmbJoinWhenDone.SelectedIndex == 5)
                {
                    ShutdownHelper.Restart();
                }
                else if (cmbJoinWhenDone.SelectedIndex == 6)
                {
                    Application.Exit();
                }
                // do nothing
                else if (cmbJoinWhenDone.SelectedIndex == 7)
                {

                }
                else if (cmbJoinWhenDone.SelectedIndex == 8)
                {
                    System.Diagnostics.Process.Start("explorer.exe", "/select,\"" + JoinHelper.JoinOutputFile + "\"");

                    /*
                    string args = string.Format("/e, /select, \"{0}\"", FirstOutputFile);
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = "explorer";
                    info.UseShellExecute = true;
                    info.Arguments = args;
                    Process.Start(info);
                    */
                }
            }
        }

        private void commandLineArgumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMessage fm = new frmMessage(true);
            fm.ShowDialog(this);
        }
    }
}

