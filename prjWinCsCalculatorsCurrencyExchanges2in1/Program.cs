using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatorsCurrencyExchanges2in1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            //Application.Run(new frmStandardCalculator());
            //Application.Run(new frmUserManual());
            //Application.Run(new frmAbout());
            //Application.Run(new frmScientificCalculator());
            //Application.Run(new frmChange());
            //Application.Run(new frmOnlineChange());
        }
    }
}
