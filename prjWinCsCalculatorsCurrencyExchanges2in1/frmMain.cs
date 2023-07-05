using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatorsCurrencyExchanges2in1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure do you wanna close the application? All the programs will be close.";
            string titleProgram = "Calculators And Currency Exchanges";
            DialogResult resultMsg;

            resultMsg = MessageBox.Show(msg, titleProgram, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultMsg == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            miToolbar.CheckOnClick = miStatusBar.CheckOnClick = true;
            miToolbar.Checked = miStatusBar.Checked = true;
        }

        private void miToolbar_Click(object sender, EventArgs e)
        {
            mmViewTab.ShowDropDown();
            tbrShortcut.Visible = miToolbar.Checked;
        }

        private void miStatusBar_Click(object sender, EventArgs e)
        {
            mmViewTab.ShowDropDown();
            stbStatusBar.Visible = miStatusBar.Checked;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAb = new frmAbout();
            showGeneralFrm(sender, e, frmAb);
        }

        private void miUserManual_Click(object sender, EventArgs e)
        {
            frmUserManual frmUM = new frmUserManual();
            showGeneralFrm(sender, e, frmUM);
        }

        private void miCalcStandard_Click(object sender, EventArgs e)
        {
            frmStandardCalculator frmStanCalc = new frmStandardCalculator();
            showGeneralFrm(sender, e, frmStanCalc);
        }

        private void tbbCalcStandard_Click(object sender, EventArgs e)
        {
            miCalcStandard_Click(sender, e);
        }

        private void miCalcScientific_Click(object sender, EventArgs e)
        {
            frmScientificCalculator frmScieCalc = new frmScientificCalculator();
            showGeneralFrm(sender, e, frmScieCalc);
        }

        private void tbbCalcScientific_Click(object sender, EventArgs e)
        {
            miCalcScientific_Click(sender, e);
        }

        private void miCurExchangeLocVer_Click(object sender, EventArgs e)
        {
            frmChange frmChg = new frmChange();
            showGeneralFrm(sender, e, frmChg);
        }

        private void tbbCurExchangeLocVer_Click(object sender, EventArgs e)
        {
            miCurExchangeLocVer_Click(sender, e);
        }

        private void miCurExchangeOnlVer_Click(object sender, EventArgs e)
        {
            frmOnlineChange frmOnChg = new frmOnlineChange();
            showGeneralFrm(sender, e, frmOnChg);
        }

        private void tbbCurExchangeOnlVer_Click(object sender, EventArgs e)
        {
            miCurExchangeOnlVer_Click(sender, e);
        }

        private void showGeneralFrm(object sender, EventArgs e, Form frmToShow)
        {
            frmToShow.MdiParent = this;

            frmToShow.Show();
            
            frmToShow.Top = ((this.Height - mmBar.Height - tbrShortcut.Height - stbStatusBar.Height) - frmToShow.Height) / 2;
            frmToShow.Left = (this.Width - frmToShow.Width) / 2;

            //lblStatusBar.Text = "Loadding " + frmToShow.Text + "...";
        }
    }
}
