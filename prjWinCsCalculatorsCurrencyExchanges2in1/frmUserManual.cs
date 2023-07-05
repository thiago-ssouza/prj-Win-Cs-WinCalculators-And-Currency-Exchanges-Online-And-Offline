using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatorsCurrencyExchanges2in1
{
    public partial class frmUserManual : Form
    {
        public frmUserManual()
        {
            InitializeComponent();
        }

        private void frmUserManual_Load(object sender, EventArgs e)
        {
            String userManualMsg = "";

            userManualMsg += "\tThe project 2in1 contains the calculator (Standard and Scientific versions)\n";
            userManualMsg += "\tand the Currency Exchange (Local and Online versions).\n";

            lblUserManual.Text = userManualMsg;


            userManualMsg = "\tMenu Bar : \n\n";
            
            userManualMsg += "\tPrograms Tab : \n\n";
            
            userManualMsg += "\tCalculator Standard Version : Opens calculator standard version.\n";
            userManualMsg += "\tCalculator Scientific Version : Opens calculator scientific version.\n";
            userManualMsg += "\tCurrency Exchange Local Version : Opens currency exchange local version.\n";
            userManualMsg += "\tCurrency Exchange Online Version : Opens currency exchange online version.\n";
            userManualMsg += "\tQuit : Exit all application.\n\n";
            
            userManualMsg += "\tView Tab : \n\n";
            
            userManualMsg += "\tToolbar : Show/Hide Toolbar.\n";
            userManualMsg += "\tStatus Bar : Show/Hide Status bar.\n\n";

            userManualMsg += "\tHelp Tab : \n\n";

            userManualMsg += "\tUser Manual : Opens User Manual information.\n";
            userManualMsg += "\tAbout : Opens about information of the program.\n\n";

            userManualMsg += "\tToolbar : \n\n";

            userManualMsg += "\tIcon Button 1 - Calculator Standard Version : Opens calculator standard version.\n";
            userManualMsg += "\tIcon Button 2 - Calculator Scientific Version : Opens calculator scientific version.\n";
            userManualMsg += "\tIcon Button 3 - Currency Exchange Local Version : Opens currency exchange local version.\n";
            userManualMsg += "\tIcon Button 4 - Currency Exchange Online Version : Opens currency exchange online version.\n\n";

            userManualMsg += "\tStatus bar : \n\n";
            userManualMsg += "\tShow the action status.\n";

            lblBehaviours.Text = userManualMsg;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
