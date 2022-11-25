using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabl_Logs
{
    public partial class frmSettings : Form
    {
        public bool IsSaved = true;
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.txtMablLoc.Text = Settings1.Default.MablLoc;
            this.IsSaved = true;
            this.FormClosing += new FormClosingEventHandler(this.FrmSettings_FormClosing);
        }
        private void FrmSettings_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (this.IsSaved)
                return;
            switch (MessageBox.Show("Save changes?", this.Text, MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    this.btnSave.PerformClick();
                    this.Close();
                    break;
                case DialogResult.No:
                    this.IsSaved = true;
                    this.Close();
                    break;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            int num = (int)this.FBD.ShowDialog();
            this.txtMablLoc.Text = this.FBD.SelectedPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings1.Default.MablLoc = this.txtMablLoc.Text;
            Settings1.Default.Save();
            this.IsSaved = true;
            this.Close();
        }

        private void txtMablLoc_TextChanged(object sender, EventArgs e)
        {
            IsSaved = false;
        }

    }
}
