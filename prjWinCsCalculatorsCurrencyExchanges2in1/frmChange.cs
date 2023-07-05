using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatorsCurrencyExchanges2in1
{
    public partial class frmChange : Form
    {

        public struct Country
        {
            public string Name;
            public string Currency;
            public Single Value;

        }

        Country[] arrCountries = new Country[50];

        Int16 nbCountries;
        const string US_CURRENCY = "US Dollar";
        string currencyAny = "";
        Single valueAny = 1;

        public frmChange()
        {
            InitializeComponent();
        }

        private void frmChange_Load(object sender, EventArgs e)
        {
            StreamReader ratesFile = new StreamReader("Rates.txt");
            
            Int16 count = 0;

            while (ratesFile.EndOfStream == false)
            {
                arrCountries[count].Name = ratesFile.ReadLine();
                arrCountries[count].Currency = ratesFile.ReadLine();
                arrCountries[count].Value = Convert.ToSingle(ratesFile.ReadLine());

                cboCountries.Items.Add(arrCountries[count].Name);

                count++;
            }

            nbCountries = count;

            ratesFile.Close();
        }

        private void cboCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (Int16 i = 0; i < nbCountries; i++)
            {

                //if (arrCountries[i].Name == cboCountries.SelectedItem.ToString())
                if (arrCountries[i].Name == cboCountries.SelectedItem)
                {
                    Single valueEuaToAny;

                    valueEuaToAny = 1 / arrCountries[i].Value;

                    lblCurrentUSToAny.Text = "1 " + US_CURRENCY + " = " + valueEuaToAny + " " + arrCountries[i].Currency + "(s)";

                    lblCurrentAnyToUS.Text = "1 " + arrCountries[i].Currency + " = " + arrCountries[i].Value + " " + US_CURRENCY;

                    rbtnUSToAny.Text = "From " + US_CURRENCY + " to " + arrCountries[i].Currency;

                    rbtnAnyToUS.Text = "From " + arrCountries[i].Currency + " to " + US_CURRENCY;

                    currencyAny = arrCountries[i].Currency;
                    valueAny = arrCountries[i].Value;

                    break;

                }

            }

            rbtnUSToAny.Checked = rbtnAnyToUS.Checked = false;
            lblConvertFrom.Text = lblValueConvertedResult.Text = "";
            //txtConvertValue.Clear();
        }

        private void rbtnUSToAny_CheckedChanged(object sender, EventArgs e)
        {
            if (cboCountries.SelectedItem != null)
            {
                lblConvertFrom.Text = US_CURRENCY;
                //lblValueConvertedResult.Text = "";
            }
            else
            {
                rbtnUSToAny.Checked = false;
            }
        }

        private void rbtnAnyToUS_CheckedChanged(object sender, EventArgs e)
        {
            if (cboCountries.SelectedItem != null)
            {
                lblConvertFrom.Text = currencyAny;
                //lblValueConvertedResult.Text = "";
            }
            else
            {
                rbtnAnyToUS.Checked = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboCountries.SelectedItem = null;
            cboCountries.Text = "Select Country";
            lblCurrentUSToAny.Text = lblCurrentAnyToUS.Text = lblConvertFrom.Text = "";
            rbtnUSToAny.Checked = rbtnAnyToUS.Checked = false; 
            txtConvertValue.Clear();
            currencyAny = "";
            valueAny = 1;



        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            String msg = "Invalid Operation : ";
            String title = "";
            if (cboCountries.SelectedItem == null)
            {
                msg += "Please select a Country!";
                MessageBox.Show(msg,title,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCountries.Focus();
            }else if (rbtnUSToAny.Checked == false && rbtnAnyToUS.Checked == false)
            {
                msg += "Please select a the Conversion type!";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //rbtnUSToAny.Focus();
            }else if (txtConvertValue.Text.Length == 0)
            {
                msg += "Please enter the value to be converted!";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConvertValue.Focus();
            }
            else
            {
                if (rbtnUSToAny.Checked)
                {
                    lblValueConvertedResult.Text = (Convert.ToSingle(txtConvertValue.Text) * (1 / valueAny)) + " " + currencyAny;
                }
                else
                {
                    lblValueConvertedResult.Text = (Convert.ToSingle(txtConvertValue.Text) * valueAny) + " " + US_CURRENCY;
                }
            }
        }

        private void txtConvertValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            else
            {
                bool hasDot = txtConvertValue.Text.Contains('.');

                if (e.KeyChar == '.' && hasDot)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
