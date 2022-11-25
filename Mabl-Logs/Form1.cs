using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Mabl_Logs
{
    public partial class Form1 : Form
    {
        public int TotalTests;
        public int TotalPassed;
        public int TotalFailed;
        public int TotalSkipped;
        public string MablCMD = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MablCMD = Settings1.Default.MablLoc + "\\mabl.cmd";
            this.txtMablCMD.Text = this.MablCMD;
            this.lvLog.MouseClick += new MouseEventHandler(this.LvLog_MouseClick);
            this.lvMablRun.MouseClick += new MouseEventHandler(this.LvLog_MouseClick);
            this.lvAvailableTests.MouseClick += new MouseEventHandler(this.LvLog_MouseClick);
            this.lvSelectedTests.MouseClick += new MouseEventHandler(this.LvLog_MouseClick);
        }
        #region Log tab
        #region Menus
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings f = new frmSettings();
            f.ShowDialog();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvLog.Items.Count > 0)
                this.lvLog.Items.Clear();
            if (this.lvSummary.Items.Count > 0)
                this.lvSummary.Items.Clear();
            this.TotalFailed = 0;
            this.TotalPassed = 0;
            this.TotalSkipped = 0;
            this.TotalTests = 0;
            this.OFD.InitialDirectory = "c:\\Test";
            this.OFD.Filter = "Mabl Logs (*.txt)|*.txt|All files (*.*)|*.*";
            this.OFD.FilterIndex = 2;
            this.OFD.RestoreDirectory = true;
            if (this.OFD.ShowDialog() != DialogResult.OK || !(this.OFD.FileName != ""))
                return;
            if (OFD.FileName != "")
            {
                ReadLog(OFD.FileName);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Controls
        private void btnRerunSelected_Click(object sender, EventArgs e)
        {
            RerunSelectedTests();
        }
        private void btnExportRerunLog_Click(object sender, EventArgs e)
        {
            int num = (int)this.SFD.ShowDialog();
            if (!(this.SFD.FileName != ""))
                return;
            StreamWriter streamWriter = new StreamWriter(this.SFD.FileName);
            foreach (string str in this.lbRerunOutput.Items)
                streamWriter.WriteLine(str);
            streamWriter.Close();
        }
        #endregion
        #region Functions
        private void ReadLog(string filename)
        {
            if (lvLog.Items.Count > 0) { lvLog.Items.Clear(); }
            
            StreamReader sr = new StreamReader(filename);
            //while(!sr.EndOfStream)
            //{
                string logline = sr.ReadLine();//Just get the 1st line to see how to read the file
                sr.Close();
                if (logline.Contains(",")) //Command script log
                {
                    ReadCommandScriptLog(filename);
                }
                else //Mabl output log
                {
                    if (logline.Contains("..."))
                    {
                        ReadMablOutputLog(filename);
                    }
                }
                lvLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //}
            //sr.Close();
            WriteStatus("");
        }
        private void ReadCommandScriptLog(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            while(!sr.EndOfStream)
            {
                string logline = sr.ReadLine();
                WriteStatus("Detected Command script log. Parsing...");
                //++this.TotalTests;
                if (logline != " ")
                {
                    string[] line = logline.Split(",");
                    if (line.Length > 1)
                    {
                        ListViewItem lvi = new ListViewItem(line[0]);
                        lvi.SubItems.Add(line[1]);
                        lvi.SubItems.Add(line[2]);
                        if (line[2].Contains("Passed"))
                        {
                            lvi.ForeColor = Color.Green;
                            ++this.TotalPassed;
                        }
                        if (line[2].Contains("Failed"))
                        {
                            lvi.ForeColor = Color.Red;
                            ++this.TotalFailed;
                        }
                        if (line[2].Contains("Skipped"))
                        {
                            lvi.ForeColor = Color.Orange;
                            ++this.TotalSkipped;
                        }
                        lvLog.Items.Add(lvi);
                        lvLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    }
                }
            }
            sr.Close();
            this.TotalTests = lvLog.Items.Count;
            this.lvSummary.Items.Add(new ListViewItem("Tests")
            {
                SubItems = {
            this.TotalTests.ToString()
          }
            });
            this.lvSummary.Items.Add(new ListViewItem("Passed")
            {
                SubItems = {
            this.TotalPassed.ToString()
          }
            });
            this.lvSummary.Items.Add(new ListViewItem("Failed")
            {
                SubItems = {
            this.TotalFailed.ToString()
          }
            });
            this.lvSummary.Items.Add(new ListViewItem("Skipped")
            {
                SubItems =
                {
                    this.TotalSkipped.ToString()
                }
            });
        }
        private void ReadMablOutputLog(string filename)
        {
            ListViewItem listViewItem1 = new ListViewItem();
            StreamReader sr = new StreamReader(filename);
            while(!sr.EndOfStream)
            {
                string logline = sr.ReadLine();
                WriteStatus("Detected Mabl output log. Parsing...");


                ListViewItem listViewItem2 = new ListViewItem();
                string str3 = logline;
                string str4 = str3;
                if (str3.Contains("Running test:"))
                {
                    string[] strArray = str4.Substring(28, str4.Length - 28).Split(new char[1] { '-' });
                    listViewItem2.Text = strArray[0];
                    listViewItem2.SubItems.Add(strArray[1] + "-" + strArray[2]);
                }
                if (str3.Contains("Test Passed"))
                {
                    listViewItem1.BackColor = Color.GreenYellow;
                    listViewItem1.SubItems.Add("Test Passed");
                }
                if (str3.Contains("Test Failed"))
                {
                    listViewItem1.BackColor = Color.Pink;
                    listViewItem1.SubItems.Add("Test Failed");
                }
                if (str3.Contains("Test Skipped"))
                {
                    listViewItem1.BackColor = Color.Orange;
                    listViewItem1.SubItems.Add("Test Skipped");
                }
                if (listViewItem2.Text != "")
                {
                    this.lvLog.Items.Add(listViewItem2);
                    listViewItem1 = listViewItem2;
                }
                this.lvMablRun.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.lbMablRun.Items.Add((object)str3);
                this.lbMablRun.TopIndex = Math.Max(this.lbMablRun.Items.Count - this.lbMablRun.ClientSize.Height / this.lbMablRun.ItemHeight + 1, 0);
                Application.DoEvents();
            }
            sr.Close();
        }
        private void RerunSelectedTests()
        {
            this.Cursor = Cursors.WaitCursor;
            string mablLoc = Settings1.Default.MablLoc;
            if (this.lbRerunOutput.Items.Count > 0)
                this.lbRerunOutput.Items.Clear();
            foreach (ListViewItem selectedItem in this.lvLog.SelectedItems)
            {
                Process process = new Process()
                {
                    StartInfo = new ProcessStartInfo()
                    {
                        FileName = mablLoc + "\\mabl.cmd",
                        Arguments = "tests run --id " + selectedItem.SubItems[1].Text.Trim(),
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                process.Start();
                while (!process.StandardOutput.EndOfStream)
                {
                    string str = process.StandardOutput.ReadLine();
                    if (str.Contains("Test Passed"))
                    {
                        selectedItem.BackColor = Color.LightGreen;
                        selectedItem.SubItems[2].Text += " Pass on 2nd run.";
                    }
                    if (str.Contains("Test Failed"))
                    {
                        selectedItem.BackColor = Color.Pink;
                        selectedItem.SubItems[2].Text += " Failed on 2nd run.";
                    }
                    this.lvLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    this.lbRerunOutput.Items.Add((object)str);
                    this.lbRerunOutput.TopIndex = Math.Max(this.lbRerunOutput.Items.Count - this.lbRerunOutput.ClientSize.Height / this.lbRerunOutput.ItemHeight + 1, 0);
                    Application.DoEvents();
                }
            }
            this.Cursor = Cursors.Default;
        }
        private void WriteStatus(string what)
        {
            lblLogStatus.Text = what;
            Application.DoEvents();
        }
        private void LvLog_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            ListViewItem focusedItem = this.lvLog.FocusedItem;
            if (focusedItem == null || !focusedItem.Bounds.Contains(e.Location))
                return;
            this.cmListItem.Show(Cursor.Position);
        }
        private void copyTestIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = this.lvLog.SelectedItems;
            string text = "";
            if (this.lvLog.SelectedItems.Count > 1)
            {
                foreach (ListViewItem listViewItem in selectedItems)
                    text = text + listViewItem.SubItems[1].Text + ",";
            }
            else
                text += this.lvLog.SelectedItems[0].SubItems[1].Text;
            Clipboard.SetText(text);
        }

        #endregion

        #endregion
        #region Run Tab

        private void rbOne_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.rbOne.Checked)
                return;
            this.rbAll.Checked = false;
            this.txtMablCMD.Text = this.MablCMD + " tests run --id ";
            this.lblLabels.Visible = false;
            this.txtLabels.Visible = false;
            this.lblID.Visible = true;
            this.txtID.Visible = true;
            this.rbTestList.Checked = false;
            this.lblTestList.Visible = false;
            this.txtTestList.Visible = false;
            this.btnBrowseTestList.Visible = false;
            this.lblPlanID.Visible = false;
            this.txtTestPlan.Visible = false;
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.rbAll.Checked)
                return;
            this.rbAll.Checked = true;
            this.txtMablCMD.Text = this.MablCMD + " tests run --labels ";
            this.lblLabels.Visible = true;
            this.txtLabels.Visible = true;
            this.lblID.Visible = false;
            this.txtID.Visible = false;
            this.rbTestList.Checked = false;
            this.lblTestList.Visible = false;
            this.txtTestList.Visible = false;
            this.btnBrowseTestList.Visible = false;
            this.lblPlanID.Visible = false;
            this.txtTestPlan.Visible = false;
        }

        private void rbTestList_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.rbTestList.Checked)
                return;
            this.rbAll.Checked = false;
            this.txtMablCMD.Text = "";// this.MablCMD + " tests run --id ";
            this.lblLabels.Visible = false;
            this.txtLabels.Visible = false;
            this.lblID.Visible = false;
            this.txtID.Visible = false;
            this.rbTestList.Checked = true;
            this.lblTestList.Visible = true;
            this.txtTestList.Visible = true;
            this.btnBrowseTestList.Visible = true;
            this.lblPlanID.Visible = false;
            this.txtTestPlan.Visible = false;
        }

        private void rbTestPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.rbTestPlan.Checked)
                return;
            this.rbAll.Checked = false;
            this.txtMablCMD.Text = this.MablCMD + " tests run --plan-id ";
            this.lblLabels.Visible = false;
            this.txtLabels.Visible = false;
            this.lblID.Visible = false;
            this.txtID.Visible = false;
            this.rbTestList.Checked = false;
            this.lblTestList.Visible = false;
            this.txtTestList.Visible = false;
            this.btnBrowseTestList.Visible = false;
            this.lblPlanID.Visible = true;
            this.txtTestPlan.Visible = true;
        }
        private void txtID_TextChanged(object sender, EventArgs e) => this.txtMablCMD.Text = this.MablCMD + " tests run --id " + this.txtID.Text;
        private void txtLabels_TextChanged(object sender, EventArgs e) => this.txtMablCMD.Text = this.MablCMD + " tests run --labels " + this.txtLabels.Text;

        private void btnExportRunLog_Click(object sender, EventArgs e)
        {
            int num = (int)this.SFD.ShowDialog();
            if (!(this.SFD.FileName != ""))
                return;
            StreamWriter streamWriter = new StreamWriter(this.SFD.FileName);
            foreach (string str in this.lbMablRun.Items)
                streamWriter.WriteLine(str);
            streamWriter.Close();
        }
        private void btnMablRun_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (this.lbMablRun.Items.Count > 0)
                this.lbMablRun.Items.Clear();
            if (this.lvMablRun.Items.Count > 0)
                this.lvMablRun.Items.Clear();
            if (this.rbOne.Checked)
            {
                ListViewItem listViewItem = new ListViewItem();
                if (!this.lvMablRun.Items.Contains(listViewItem))
                    this.lvMablRun.Items.Add(listViewItem);
                Process process = new Process()
                {
                    StartInfo = new ProcessStartInfo()
                    {
                        FileName = this.MablCMD,
                        Arguments = "tests run --id " + this.txtID.Text,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                process.Start();
                while (!process.StandardOutput.EndOfStream)
                {
                    string str1 = process.StandardOutput.ReadLine();
                    string str2 = str1;
                    if (str1.Contains("Running test:"))
                    {
                        string[] strArray = str2.Substring(28, str2.Length - 28).Split(new char[1] { '-' });
                        listViewItem.Text = strArray[0];
                        listViewItem.SubItems.Add(strArray[1] + "-" + strArray[2]);
                    }
                    if (str1.Contains("Test Passed"))
                    {
                        listViewItem.BackColor = Color.LightGreen;
                        listViewItem.SubItems.Add("Test Passed");
                    }
                    if (str1.Contains("Test Failed"))
                    {
                        listViewItem.BackColor = Color.Pink;
                        listViewItem.SubItems.Add("Test Failed");
                    }
                    if (str1.Contains("Test Skipped"))
                    {
                        listViewItem.BackColor = Color.Orange;
                        listViewItem.SubItems.Add("Test Skipped");
                    }
                    this.lbMablRun.Items.Add((object)str1);
                    this.lbMablRun.TopIndex = Math.Max(this.lbMablRun.Items.Count - this.lbMablRun.ClientSize.Height / this.lbMablRun.ItemHeight + 1, 0);
                    Application.DoEvents();
                }
                this.lvMablRun.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                Application.DoEvents();
            }
            if (this.rbAll.Checked)
            {
                ListViewItem listViewItem1 = new ListViewItem();
                Process process = new Process()
                {
                    StartInfo = new ProcessStartInfo()
                    {
                        FileName = this.MablCMD,
                        Arguments = "tests run --labels " + this.txtLabels.Text,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                process.Start();
                while (!process.StandardOutput.EndOfStream)
                {
                    ListViewItem listViewItem2 = new ListViewItem();
                    string str3 = process.StandardOutput.ReadLine();
                    string str4 = str3;
                    if (str3.Contains("Running test:"))
                    {
                        string[] strArray = str4.Substring(28, str4.Length - 28).Split(new char[1] { '-' });
                        listViewItem2.Text = strArray[0];
                        listViewItem2.SubItems.Add(strArray[1] + "-" + strArray[2]);
                    }
                    if (str3.Contains("Test Passed"))
                    {
                        listViewItem1.BackColor = Color.GreenYellow;
                        listViewItem1.SubItems.Add("Test Passed");
                    }
                    if (str3.Contains("Test Failed"))
                    {
                        listViewItem1.BackColor = Color.Pink;
                        listViewItem1.SubItems.Add("Test Failed");
                    }
                    if (str3.Contains("Test Skipped"))
                    {
                        listViewItem1.BackColor = Color.Orange;
                        listViewItem1.SubItems.Add("Test Skipped");
                    }
                    if (listViewItem2.Text != "")
                    {
                        this.lvMablRun.Items.Add(listViewItem2);
                        listViewItem1 = listViewItem2;
                    }
                    this.lvMablRun.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    this.lbMablRun.Items.Add((object)str3);
                    this.lbMablRun.TopIndex = Math.Max(this.lbMablRun.Items.Count - this.lbMablRun.ClientSize.Height / this.lbMablRun.ItemHeight + 1, 0);
                    Application.DoEvents();
                }
                this.lvMablRun.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                Application.DoEvents();
            }
            if (this.rbTestList.Checked)
            {
                StreamReader streamReader = new StreamReader(this.txtTestList.Text);
                while (!streamReader.EndOfStream)
                {
                    string[] strArray = streamReader.ReadLine().Split(",");
                    ListViewItem listViewItem3 = new ListViewItem(strArray[0]);
                    listViewItem3.SubItems.Add(strArray[1]);
                    this.lvMablRun.Items.Add(listViewItem3);
                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo()
                        {
                            FileName = this.MablCMD,
                            Arguments = "tests run --id " + strArray[1],
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                    };
                    process.Start();
                    while (!process.StandardOutput.EndOfStream)
                    {
                        ListViewItem listViewItem4 = new ListViewItem();
                        string str = process.StandardOutput.ReadLine();
                        if (str.Contains("Test Passed"))
                        {
                            listViewItem3.BackColor = Color.GreenYellow;
                            listViewItem3.SubItems.Add("Test Passed");
                        }
                        if (str.Contains("Test Failed"))
                        {
                            listViewItem3.BackColor = Color.Pink;
                            listViewItem3.SubItems.Add("Test Failed");
                        }
                        if (str.Contains("Test Skipped"))
                        {
                            listViewItem3.BackColor = Color.Orange;
                            listViewItem3.SubItems.Add("Test Skipped");
                        }
                        if (listViewItem4.Text != "")
                        {
                            this.lvMablRun.Items.Add(listViewItem4);
                            listViewItem3 = listViewItem4;
                        }
                        this.lvMablRun.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        this.lbMablRun.Items.Add((object)str);
                        this.lbMablRun.TopIndex = Math.Max(this.lbMablRun.Items.Count - this.lbMablRun.ClientSize.Height / this.lbMablRun.ItemHeight + 1, 0);
                        Application.DoEvents();
                    }
                    this.lvMablRun.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    Application.DoEvents();
                }
                streamReader.Close();
            }
            if (this.rbTestPlan.Checked)
            {
                StreamReader streamReader = new StreamReader(this.txtTestList.Text);
                while (!streamReader.EndOfStream)
                {
                    string[] strArray = streamReader.ReadLine().Split(",");
                    ListViewItem listViewItem3 = new ListViewItem(strArray[0]);
                    listViewItem3.SubItems.Add(strArray[1]);
                    this.lvMablRun.Items.Add(listViewItem3);
                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo()
                        {
                            FileName = this.MablCMD,
                            Arguments = "tests run --from-plan-id " + txtTestPlan.Text,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                    };
                    process.Start();
                    while (!process.StandardOutput.EndOfStream)
                    {
                        ListViewItem listViewItem4 = new ListViewItem();
                        string str = process.StandardOutput.ReadLine();
                        if (str.Contains("Test Passed"))
                        {
                            listViewItem3.BackColor = Color.GreenYellow;
                            listViewItem3.SubItems.Add("Test Passed");
                        }
                        if (str.Contains("Test Failed"))
                        {
                            listViewItem3.BackColor = Color.Pink;
                            listViewItem3.SubItems.Add("Test Failed");
                        }
                        if (str.Contains("Test Skipped"))
                        {
                            listViewItem3.BackColor = Color.Orange;
                            listViewItem3.SubItems.Add("Test Skipped");
                        }
                        if (listViewItem4.Text != "")
                        {
                            this.lvMablRun.Items.Add(listViewItem4);
                            listViewItem3 = listViewItem4;
                        }
                        this.lvMablRun.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        this.lbMablRun.Items.Add((object)str);
                        this.lbMablRun.TopIndex = Math.Max(this.lbMablRun.Items.Count - this.lbMablRun.ClientSize.Height / this.lbMablRun.ItemHeight + 1, 0);
                        Application.DoEvents();
                    }
                    this.lvMablRun.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    Application.DoEvents();
                }
                streamReader.Close();
            }
            this.Cursor = Cursors.Default;
        }
        #endregion
        #region Test List Builder
        private void btnGetTestsFromMabl_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string mablLoc = Settings1.Default.MablLoc;
            if (this.lvAvailableTests.Items.Count > 0)
                this.lvAvailableTests.Items.Clear();
            if (this.lvSelectedTests.Items.Count > 0)
                this.lvSelectedTests.Items.Clear();
            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = mablLoc + "\\mabl.cmd",
                    Arguments = "tests list --limit 5000",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                string str = process.StandardOutput.ReadLine();
                str.Contains("────────");
                if (str.Contains(" \u001B[90mâ”‚\u001B[39m "))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    string[] strArray = str.Split(" \u001B[90mâ”‚\u001B[39m ");
                    listViewItem.Text = strArray[1].Trim();
                    if (strArray[0].Contains("\u001B[90mâ”‚\u001B[39m"))
                        strArray[0] = strArray[0].Remove(0, 14);
                    listViewItem.SubItems.Add(strArray[0].Trim());
                    this.lvAvailableTests.Items.Add(listViewItem);
                }
                this.lvAvailableTests.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.lbRerunOutput.TopIndex = Math.Max(this.lbRerunOutput.Items.Count - this.lbRerunOutput.ClientSize.Height / this.lbRerunOutput.ItemHeight + 1, 0);
                this.lblAvailable.Text = "Available Tests: " + this.lvAvailableTests.Items.Count.ToString();
                Application.DoEvents();
            }
            this.Cursor = Cursors.Default;
        }

        #endregion

        private void btnSelectAllTests_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in this.lvAvailableTests.Items)
            {
                this.lvAvailableTests.Items.Remove(listViewItem);
                this.lvSelectedTests.Items.Add(listViewItem);
                this.lvSelectedTests.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                Label lblSelected = this.lblSelected;
                int count = this.lvSelectedTests.Items.Count;
                string str1 = "Selected Tests: " + count.ToString();
                lblSelected.Text = str1;
                Label lblAvailable = this.lblAvailable;
                count = this.lvAvailableTests.Items.Count;
                string str2 = "Available Tests: " + count.ToString();
                lblAvailable.Text = str2;
            }
        }

        private void btnSelectOne_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in this.lvAvailableTests.SelectedItems)
            {
                this.lvAvailableTests.Items.Remove(selectedItem);
                this.lvSelectedTests.Items.Add(selectedItem);
                this.lvSelectedTests.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                Label lblSelected = this.lblSelected;
                int count = this.lvSelectedTests.Items.Count;
                string str1 = "Selected Tests: " + count.ToString();
                lblSelected.Text = str1;
                Label lblAvailable = this.lblAvailable;
                count = this.lvAvailableTests.Items.Count;
                string str2 = "Available Tests: " + count.ToString();
                lblAvailable.Text = str2;
            }
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in this.lvSelectedTests.SelectedItems)
            {
                this.lvSelectedTests.Items.Remove(selectedItem);
                this.lvAvailableTests.Items.Add(selectedItem);
                Label lblSelected = this.lblSelected;
                int count = this.lvSelectedTests.Items.Count;
                string str1 = "Selected Tests: " + count.ToString();
                lblSelected.Text = str1;
                Label lblAvailable = this.lblAvailable;
                count = this.lvAvailableTests.Items.Count;
                string str2 = "Available Tests: " + count.ToString();
                lblAvailable.Text = str2;
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in this.lvSelectedTests.Items)
            {
                this.lvSelectedTests.Items.Remove(listViewItem);
                this.lvAvailableTests.Items.Add(listViewItem);
                Label lblSelected = this.lblSelected;
                int count = this.lvSelectedTests.Items.Count;
                string str1 = "Selected Tests: " + count.ToString();
                lblSelected.Text = str1;
                Label lblAvailable = this.lblAvailable;
                count = this.lvAvailableTests.Items.Count;
                string str2 = "Available Tests: " + count.ToString();
                lblAvailable.Text = str2;
            }
        }

        private void btnOpenTestList_Click(object sender, EventArgs e)
        {
            if (this.lvSelectedTests.Items.Count != 0)
                this.lvSelectedTests.Items.Clear();
            int num = (int)this.OFD.ShowDialog();
            if (!(this.OFD.FileName != ""))
                return;
            StreamReader streamReader = new StreamReader(this.OFD.FileName);
            while (!streamReader.EndOfStream)
            {
                string[] strArray = streamReader.ReadLine().Split(',');
                ListViewItem listViewItem1 = new ListViewItem(strArray[0]);
                if (strArray.Length > 1)
                {
                    listViewItem1.SubItems.Add(strArray[1]);
                    this.lvSelectedTests.Items.Add(listViewItem1);
                    this.lvSelectedTests.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    foreach (ListViewItem listViewItem2 in this.lvAvailableTests.Items)
                    {
                        if (listViewItem1.Text == listViewItem2.Text)
                            this.lvAvailableTests.Items.Remove(listViewItem2);
                    }
                }
                Label lblSelected = this.lblSelected;
                int count = this.lvSelectedTests.Items.Count;
                string str1 = "Selected Tests: " + count.ToString();
                lblSelected.Text = str1;
                Label lblAvailable = this.lblAvailable;
                count = this.lvAvailableTests.Items.Count;
                string str2 = "Available Tests: " + count.ToString();
                lblAvailable.Text = str2;
            }
            streamReader.Close();
        }

        private void btnGenerateTestList_Click(object sender, EventArgs e)
        {
            if (this.lvSelectedTests.Items.Count > 0)
            {
                int num = (int)this.SFD.ShowDialog();
                if (!(this.SFD.FileName != ""))
                    return;
                StreamWriter streamWriter = new StreamWriter(this.SFD.FileName);
                foreach (ListViewItem listViewItem in this.lvSelectedTests.Items)
                {
                    string str = listViewItem.Text + "," + listViewItem.SubItems[1].Text;
                    streamWriter.WriteLine(str);
                }
                streamWriter.Close();
            }
            else
            {
                int num1 = (int)MessageBox.Show("Please select some tests for the list", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnBrowseTestList_Click(object sender, EventArgs e)
        {
            int num = (int)this.OFD.ShowDialog();
            if (!(this.OFD.FileName != ""))
                return;
            this.txtTestList.Text = this.OFD.FileName;
        }
    }

    public class ListViewNF : ListView
    {
        public ListViewNF()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        protected override void OnNotifyMessage(Message m)
        {
            if (m.Msg == 20)
                return;
            base.OnNotifyMessage(m);
        }
    }
}