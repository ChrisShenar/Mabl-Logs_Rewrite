namespace Mabl_Logs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblLogStatus = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnExportRerunLog = new System.Windows.Forms.Button();
            this.btnRerunSelected = new System.Windows.Forms.Button();
            this.lvSummary = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lvLog = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lbRerunOutput = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExportRunLog = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvMablRun = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.lbMablRun = new System.Windows.Forms.ListBox();
            this.btnMablRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMablCMD = new System.Windows.Forms.TextBox();
            this.txtTestPlan = new System.Windows.Forms.TextBox();
            this.lblPlanID = new System.Windows.Forms.Label();
            this.btnBrowseTestList = new System.Windows.Forms.Button();
            this.txtTestList = new System.Windows.Forms.TextBox();
            this.lblTestList = new System.Windows.Forms.Label();
            this.txtLabels = new System.Windows.Forms.TextBox();
            this.lblLabels = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.rbTestPlan = new System.Windows.Forms.RadioButton();
            this.rbTestList = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenTestList = new System.Windows.Forms.Button();
            this.btnGenerateTestList = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.btnGetTestsFromMabl = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.btnSelectOne = new System.Windows.Forms.Button();
            this.btnSelectAllTests = new System.Windows.Forms.Button();
            this.lvSelectedTests = new Mabl_Logs.ListViewNF();// System.Windows.Forms.ListView();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.lvAvailableTests = new Mabl_Logs.ListViewNF();// System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.cmListItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyTestIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cmListItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblLogStatus);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblLogStatus
            // 
            this.lblLogStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogStatus.AutoSize = true;
            this.lblLogStatus.Location = new System.Drawing.Point(4, 417);
            this.lblLogStatus.Name = "lblLogStatus";
            this.lblLogStatus.Size = new System.Drawing.Size(0, 15);
            this.lblLogStatus.TabIndex = 1;
            this.lblLogStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnExportRerunLog);
            this.splitContainer1.Panel1.Controls.Add(this.btnRerunSelected);
            this.splitContainer1.Panel1.Controls.Add(this.lvSummary);
            this.splitContainer1.Panel1.Controls.Add(this.lvLog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbRerunOutput);
            this.splitContainer1.Size = new System.Drawing.Size(786, 411);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnExportRerunLog
            // 
            this.btnExportRerunLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportRerunLog.Location = new System.Drawing.Point(651, 152);
            this.btnExportRerunLog.Name = "btnExportRerunLog";
            this.btnExportRerunLog.Size = new System.Drawing.Size(126, 23);
            this.btnExportRerunLog.TabIndex = 3;
            this.btnExportRerunLog.Text = "Export Log";
            this.btnExportRerunLog.UseVisualStyleBackColor = true;
            this.btnExportRerunLog.Click += new System.EventHandler(this.btnExportRerunLog_Click);
            // 
            // btnRerunSelected
            // 
            this.btnRerunSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRerunSelected.Location = new System.Drawing.Point(651, 117);
            this.btnRerunSelected.Name = "btnRerunSelected";
            this.btnRerunSelected.Size = new System.Drawing.Size(126, 23);
            this.btnRerunSelected.TabIndex = 2;
            this.btnRerunSelected.Text = "Rerun Selected";
            this.btnRerunSelected.UseVisualStyleBackColor = true;
            this.btnRerunSelected.Click += new System.EventHandler(this.btnRerunSelected_Click);
            // 
            // lvSummary
            // 
            this.lvSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSummary.FullRowSelect = true;
            this.lvSummary.GridLines = true;
            this.lvSummary.Location = new System.Drawing.Point(651, 3);
            this.lvSummary.Name = "lvSummary";
            this.lvSummary.Size = new System.Drawing.Size(131, 108);
            this.lvSummary.TabIndex = 1;
            this.lvSummary.UseCompatibleStateImageBehavior = false;
            this.lvSummary.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Result";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // lvLog
            // 
            this.lvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvLog.FullRowSelect = true;
            this.lvLog.GridLines = true;
            this.lvLog.Location = new System.Drawing.Point(3, 3);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(642, 177);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Test";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mabl ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Result";
            // 
            // lbRerunOutput
            // 
            this.lbRerunOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRerunOutput.FormattingEnabled = true;
            this.lbRerunOutput.ItemHeight = 15;
            this.lbRerunOutput.Location = new System.Drawing.Point(0, 0);
            this.lbRerunOutput.Name = "lbRerunOutput";
            this.lbRerunOutput.Size = new System.Drawing.Size(782, 221);
            this.lbRerunOutput.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExportRunLog);
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Controls.Add(this.btnMablRun);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtMablCMD);
            this.tabPage2.Controls.Add(this.txtTestPlan);
            this.tabPage2.Controls.Add(this.lblPlanID);
            this.tabPage2.Controls.Add(this.btnBrowseTestList);
            this.tabPage2.Controls.Add(this.txtTestList);
            this.tabPage2.Controls.Add(this.lblTestList);
            this.tabPage2.Controls.Add(this.txtLabels);
            this.tabPage2.Controls.Add(this.lblLabels);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Controls.Add(this.lblID);
            this.tabPage2.Controls.Add(this.rbTestPlan);
            this.tabPage2.Controls.Add(this.rbTestList);
            this.tabPage2.Controls.Add(this.rbAll);
            this.tabPage2.Controls.Add(this.rbOne);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Run";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExportRunLog
            // 
            this.btnExportRunLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportRunLog.Location = new System.Drawing.Point(696, 281);
            this.btnExportRunLog.Name = "btnExportRunLog";
            this.btnExportRunLog.Size = new System.Drawing.Size(88, 23);
            this.btnExportRunLog.TabIndex = 18;
            this.btnExportRunLog.Text = "Export Log";
            this.btnExportRunLog.UseVisualStyleBackColor = true;
            this.btnExportRunLog.Click += new System.EventHandler(this.btnExportRunLog_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Location = new System.Drawing.Point(8, 119);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvMablRun);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbMablRun);
            this.splitContainer2.Size = new System.Drawing.Size(684, 312);
            this.splitContainer2.SplitterDistance = 156;
            this.splitContainer2.TabIndex = 17;
            // 
            // lvMablRun
            // 
            this.lvMablRun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvMablRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMablRun.FullRowSelect = true;
            this.lvMablRun.GridLines = true;
            this.lvMablRun.Location = new System.Drawing.Point(0, 0);
            this.lvMablRun.Name = "lvMablRun";
            this.lvMablRun.Size = new System.Drawing.Size(680, 152);
            this.lvMablRun.TabIndex = 0;
            this.lvMablRun.UseCompatibleStateImageBehavior = false;
            this.lvMablRun.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Test";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mabl ID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Result";
            // 
            // lbMablRun
            // 
            this.lbMablRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMablRun.FormattingEnabled = true;
            this.lbMablRun.ItemHeight = 15;
            this.lbMablRun.Location = new System.Drawing.Point(0, 0);
            this.lbMablRun.Name = "lbMablRun";
            this.lbMablRun.Size = new System.Drawing.Size(680, 148);
            this.lbMablRun.TabIndex = 0;
            // 
            // btnMablRun
            // 
            this.btnMablRun.Location = new System.Drawing.Point(551, 90);
            this.btnMablRun.Name = "btnMablRun";
            this.btnMablRun.Size = new System.Drawing.Size(141, 23);
            this.btnMablRun.TabIndex = 16;
            this.btnMablRun.Text = "Run Mabl-CLI";
            this.btnMablRun.UseVisualStyleBackColor = true;
            this.btnMablRun.Click += new System.EventHandler(this.btnMablRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mabl command to be run";
            // 
            // txtMablCMD
            // 
            this.txtMablCMD.Location = new System.Drawing.Point(8, 90);
            this.txtMablCMD.Name = "txtMablCMD";
            this.txtMablCMD.Size = new System.Drawing.Size(537, 23);
            this.txtMablCMD.TabIndex = 14;
            // 
            // txtTestPlan
            // 
            this.txtTestPlan.Location = new System.Drawing.Point(561, 48);
            this.txtTestPlan.Name = "txtTestPlan";
            this.txtTestPlan.Size = new System.Drawing.Size(141, 23);
            this.txtTestPlan.TabIndex = 13;
            this.txtTestPlan.Visible = false;
            // 
            // lblPlanID
            // 
            this.lblPlanID.AutoSize = true;
            this.lblPlanID.Location = new System.Drawing.Point(561, 32);
            this.lblPlanID.Name = "lblPlanID";
            this.lblPlanID.Size = new System.Drawing.Size(47, 15);
            this.lblPlanID.TabIndex = 12;
            this.lblPlanID.Text = "Plan ID:";
            this.lblPlanID.Visible = false;
            // 
            // btnBrowseTestList
            // 
            this.btnBrowseTestList.Location = new System.Drawing.Point(524, 48);
            this.btnBrowseTestList.Name = "btnBrowseTestList";
            this.btnBrowseTestList.Size = new System.Drawing.Size(31, 23);
            this.btnBrowseTestList.TabIndex = 11;
            this.btnBrowseTestList.Text = "...";
            this.btnBrowseTestList.UseVisualStyleBackColor = true;
            this.btnBrowseTestList.Visible = false;
            this.btnBrowseTestList.Click += new System.EventHandler(this.btnBrowseTestList_Click);
            // 
            // txtTestList
            // 
            this.txtTestList.Location = new System.Drawing.Point(348, 48);
            this.txtTestList.Name = "txtTestList";
            this.txtTestList.Size = new System.Drawing.Size(180, 23);
            this.txtTestList.TabIndex = 10;
            this.txtTestList.Visible = false;
            // 
            // lblTestList
            // 
            this.lblTestList.AutoSize = true;
            this.lblTestList.Location = new System.Drawing.Point(348, 32);
            this.lblTestList.Name = "lblTestList";
            this.lblTestList.Size = new System.Drawing.Size(163, 15);
            this.lblTestList.TabIndex = 9;
            this.lblTestList.Text = "Path and Filename of Test List";
            this.lblTestList.Visible = false;
            // 
            // txtLabels
            // 
            this.txtLabels.Location = new System.Drawing.Point(155, 48);
            this.txtLabels.Name = "txtLabels";
            this.txtLabels.Size = new System.Drawing.Size(180, 23);
            this.txtLabels.TabIndex = 8;
            this.txtLabels.Visible = false;
            // 
            // lblLabels
            // 
            this.lblLabels.AutoSize = true;
            this.lblLabels.Location = new System.Drawing.Point(155, 32);
            this.lblLabels.Name = "lblLabels";
            this.lblLabels.Size = new System.Drawing.Size(180, 15);
            this.lblLabels.TabIndex = 7;
            this.lblLabels.Text = "Label(s) to test (Space separated)";
            this.lblLabels.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(8, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(141, 23);
            this.txtID.TabIndex = 6;
            this.txtID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(8, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 15);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Test ID:";
            this.lblID.Visible = false;
            // 
            // rbTestPlan
            // 
            this.rbTestPlan.AutoSize = true;
            this.rbTestPlan.Location = new System.Drawing.Point(561, 10);
            this.rbTestPlan.Name = "rbTestPlan";
            this.rbTestPlan.Size = new System.Drawing.Size(142, 19);
            this.rbTestPlan.TabIndex = 4;
            this.rbTestPlan.Text = "All Tests Under Plan ID";
            this.rbTestPlan.UseVisualStyleBackColor = true;
            this.rbTestPlan.CheckedChanged += new System.EventHandler(this.rbTestPlan_CheckedChanged);
            // 
            // rbTestList
            // 
            this.rbTestList.AutoSize = true;
            this.rbTestList.Location = new System.Drawing.Point(348, 10);
            this.rbTestList.Name = "rbTestList";
            this.rbTestList.Size = new System.Drawing.Size(119, 19);
            this.rbTestList.TabIndex = 3;
            this.rbTestList.Text = "All Tests From List";
            this.rbTestList.UseVisualStyleBackColor = true;
            this.rbTestList.CheckedChanged += new System.EventHandler(this.rbTestList_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(155, 10);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(146, 19);
            this.rbAll.TabIndex = 2;
            this.rbAll.Text = "All Tests Under Label(s)";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(8, 10);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(100, 19);
            this.rbOne.TabIndex = 1;
            this.rbOne.Text = "Individual Test";
            this.rbOne.UseVisualStyleBackColor = true;
            this.rbOne.CheckedChanged += new System.EventHandler(this.rbOne_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnOpenTestList);
            this.tabPage3.Controls.Add(this.btnGenerateTestList);
            this.tabPage3.Controls.Add(this.lblSelected);
            this.tabPage3.Controls.Add(this.lblAvailable);
            this.tabPage3.Controls.Add(this.btnGetTestsFromMabl);
            this.tabPage3.Controls.Add(this.btnRemoveAll);
            this.tabPage3.Controls.Add(this.btnRemoveOne);
            this.tabPage3.Controls.Add(this.btnSelectOne);
            this.tabPage3.Controls.Add(this.btnSelectAllTests);
            this.tabPage3.Controls.Add(this.lvSelectedTests);
            this.tabPage3.Controls.Add(this.lvAvailableTests);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Test List Builder";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "The Test list Builder is for generating a list of tests for the Mabl-CLI Command " +
    "Script to run.";
            // 
            // btnOpenTestList
            // 
            this.btnOpenTestList.Location = new System.Drawing.Point(643, 13);
            this.btnOpenTestList.Name = "btnOpenTestList";
            this.btnOpenTestList.Size = new System.Drawing.Size(141, 23);
            this.btnOpenTestList.TabIndex = 10;
            this.btnOpenTestList.Text = "Open Test List";
            this.btnOpenTestList.UseVisualStyleBackColor = true;
            this.btnOpenTestList.Click += new System.EventHandler(this.btnOpenTestList_Click);
            // 
            // btnGenerateTestList
            // 
            this.btnGenerateTestList.Location = new System.Drawing.Point(643, 42);
            this.btnGenerateTestList.Name = "btnGenerateTestList";
            this.btnGenerateTestList.Size = new System.Drawing.Size(141, 23);
            this.btnGenerateTestList.TabIndex = 9;
            this.btnGenerateTestList.Text = "Generate Test List";
            this.btnGenerateTestList.UseVisualStyleBackColor = true;
            this.btnGenerateTestList.Click += new System.EventHandler(this.btnGenerateTestList_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(419, 55);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(85, 15);
            this.lblSelected.TabIndex = 8;
            this.lblSelected.Text = "Selected Tests: ";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(5, 51);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(89, 15);
            this.lblAvailable.TabIndex = 7;
            this.lblAvailable.Text = "Available Tests: ";
            // 
            // btnGetTestsFromMabl
            // 
            this.btnGetTestsFromMabl.Location = new System.Drawing.Point(233, 42);
            this.btnGetTestsFromMabl.Name = "btnGetTestsFromMabl";
            this.btnGetTestsFromMabl.Size = new System.Drawing.Size(141, 23);
            this.btnGetTestsFromMabl.TabIndex = 6;
            this.btnGetTestsFromMabl.Text = "Get Tests from Mabl";
            this.btnGetTestsFromMabl.UseVisualStyleBackColor = true;
            this.btnGetTestsFromMabl.Click += new System.EventHandler(this.btnGetTestsFromMabl_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(380, 200);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(33, 23);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Location = new System.Drawing.Point(380, 171);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(33, 23);
            this.btnRemoveOne.TabIndex = 4;
            this.btnRemoveOne.Text = "<";
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            this.btnRemoveOne.Click += new System.EventHandler(this.btnRemoveOne_Click);
            // 
            // btnSelectOne
            // 
            this.btnSelectOne.Location = new System.Drawing.Point(380, 142);
            this.btnSelectOne.Name = "btnSelectOne";
            this.btnSelectOne.Size = new System.Drawing.Size(33, 23);
            this.btnSelectOne.TabIndex = 3;
            this.btnSelectOne.Text = ">";
            this.btnSelectOne.UseVisualStyleBackColor = true;
            this.btnSelectOne.Click += new System.EventHandler(this.btnSelectOne_Click);
            // 
            // btnSelectAllTests
            // 
            this.btnSelectAllTests.Location = new System.Drawing.Point(380, 113);
            this.btnSelectAllTests.Name = "btnSelectAllTests";
            this.btnSelectAllTests.Size = new System.Drawing.Size(33, 23);
            this.btnSelectAllTests.TabIndex = 2;
            this.btnSelectAllTests.Text = ">>";
            this.btnSelectAllTests.UseVisualStyleBackColor = true;
            this.btnSelectAllTests.Click += new System.EventHandler(this.btnSelectAllTests_Click);
            // 
            // lvSelectedTests
            // 
            this.lvSelectedTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvSelectedTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.lvSelectedTests.FullRowSelect = true;
            this.lvSelectedTests.GridLines = true;
            this.lvSelectedTests.Location = new System.Drawing.Point(419, 71);
            this.lvSelectedTests.Name = "lvSelectedTests";
            this.lvSelectedTests.Size = new System.Drawing.Size(365, 358);
            this.lvSelectedTests.TabIndex = 1;
            this.lvSelectedTests.UseCompatibleStateImageBehavior = false;
            this.lvSelectedTests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Test Title";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Test ID";
            // 
            // lvAvailableTests
            // 
            this.lvAvailableTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvAvailableTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.lvAvailableTests.FullRowSelect = true;
            this.lvAvailableTests.GridLines = true;
            this.lvAvailableTests.Location = new System.Drawing.Point(4, 71);
            this.lvAvailableTests.Name = "lvAvailableTests";
            this.lvAvailableTests.Size = new System.Drawing.Size(370, 358);
            this.lvAvailableTests.TabIndex = 0;
            this.lvAvailableTests.UseCompatibleStateImageBehavior = false;
            this.lvAvailableTests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Test Title";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Test ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // OFD
            // 
            this.OFD.RestoreDirectory = true;
            this.OFD.ShowReadOnly = true;
            // 
            // cmListItem
            // 
            this.cmListItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTestIDToolStripMenuItem});
            this.cmListItem.Name = "cmListItem";
            this.cmListItem.Size = new System.Drawing.Size(140, 26);
            // 
            // copyTestIDToolStripMenuItem
            // 
            this.copyTestIDToolStripMenuItem.Name = "copyTestIDToolStripMenuItem";
            this.copyTestIDToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copyTestIDToolStripMenuItem.Text = "Copy Test ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mabl-Logs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmListItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private Button btnExportRerunLog;
        private Button btnRerunSelected;
        private ListView lvSummary;
        private ListView lvLog;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TabPage tabPage3;
        private Label lblLogStatus;
        private OpenFileDialog OFD;
        private ListBox lbRerunOutput;
        private SaveFileDialog SFD;
        private TextBox txtTestPlan;
        private Label lblPlanID;
        private Button btnBrowseTestList;
        private TextBox txtTestList;
        private Label lblTestList;
        private TextBox txtLabels;
        private Label lblLabels;
        private TextBox txtID;
        private Label lblID;
        private RadioButton rbTestPlan;
        private RadioButton rbTestList;
        private RadioButton rbAll;
        private RadioButton rbOne;
        private ListView lvMablRun;
        private Button btnMablRun;
        private Label label1;
        private TextBox txtMablCMD;
        private Button btnExportRunLog;
        private SplitContainer splitContainer2;
        private ListBox lbMablRun;
        private ContextMenuStrip cmListItem;
        private ToolStripMenuItem copyTestIDToolStripMenuItem;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button btnGetTestsFromMabl;
        private Button btnRemoveAll;
        private Button btnRemoveOne;
        private Button btnSelectOne;
        private Button btnSelectAllTests;
        private ListViewNF lvSelectedTests;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListViewNF lvAvailableTests;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label lblAvailable;
        private Label lblSelected;
        private Label label2;
        private Button btnOpenTestList;
        private Button btnGenerateTestList;
    }
}