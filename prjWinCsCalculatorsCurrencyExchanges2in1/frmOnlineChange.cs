using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static prjWinCsCalculatorsCurrencyExchanges2in1.frmOnlineChange;

namespace prjWinCsCalculatorsCurrencyExchanges2in1
{
    public partial class frmOnlineChange : Form
    {
        public frmOnlineChange()
        {
            InitializeComponent();
        }

        public struct Currency
        {
            public string CurrencyName;
            public string usdCurrencyName;
            public string CurrencyCode;
            public string usdCurrencyCode;
            public Single ValueUSDToCurrent;
            public Single ValueCurrentToUSD;

        }

        //Country[] arrCountries = new Country[50];
        Currency[] arrCurrencies;

        Int16 nbCurrencies, countUpdatedsFile = 0;
        //string filePublishedDateTime = "";
        string filePathAndName = "XML Daily Foreign Exchange Rates for U.S. Dollar (USD).xml";
        
        // cboCurrencyFrom
        string fromCurrencyName = "";
        string fromUsdCurrencyName = "";
        string fromCurrencyCode = "";
        string fromUsdCurrencyCode = "";
        Single fromValueCurrencyToUSD = 1;
        Single fromValueUSDToCurrency = 1;
        Int16 indexSelectedFrom = -1;

        // cboCurrencyFrom
        string toCurrencyName = "";
        string toUsdCurrencyName = "";
        string toCurrencyCode = "";
        string toUsdCurrencyCode = "";
        Single toValueCurrencyToUSD = 1;
        Single toValueUSDToCurrency = 1;
        Int16 indexSelectedTo = -1;

        private void frmOnlineChange_Load(object sender, EventArgs e)
        {
            //btnSwitch.FlatStyle = FlatStyle.Flat;
            //btnSwitch.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.Enabled = false;

            updateFileCreateCurrenciesArrFillUpCbo();
        }

        private string extractValueFromTags(string stringItem, Int16 indexItem)
        {
            return stringItem.Substring((indexItem + stringItem.IndexOf(">") + 1), stringItem.IndexOf("<", (indexItem + stringItem.IndexOf(">") + 1)) - (indexItem + stringItem.IndexOf(">") + 1)).Trim();
        }

        private string extractFileDateTime()
        {
            string filePublishedDateTime = "";
            StreamReader ratesFile = new StreamReader(filePathAndName);

            Int16 indexItem;
            string stringItem;


            /**
             * 
             * get the published date of the document and display in the lblDisplayDateTime.Text
             * */
            while (ratesFile.EndOfStream == false)
            {
                stringItem = ratesFile.ReadLine().Trim();
                indexItem = Convert.ToInt16(stringItem.IndexOf("<pubDate>"));

                while (indexItem == -1 && ratesFile.EndOfStream == false)
                {
                    stringItem = ratesFile.ReadLine().Trim();
                    indexItem = Convert.ToInt16(stringItem.IndexOf("<pubDate>"));
                    if (indexItem != -1)
                    {
                        filePublishedDateTime = stringItem.Substring((indexItem + stringItem.IndexOf(">") + 1), stringItem.IndexOf("<", (indexItem + stringItem.IndexOf(">") + 1)) - (indexItem + stringItem.IndexOf(">") + 1));
                        break;
                    }
                }
            }

            ratesFile.Close();

            return filePublishedDateTime;
        }

        private Int16 getCurrencyQuantity()
        {
            StreamReader ratesFile = new StreamReader(filePathAndName);

            Int16 count = 0;
            Int16 indexItem;
            string stringItem;

            /**
             * 
             * count the quantity of rates for the dynamic array
             * 
             */
            while (ratesFile.EndOfStream == false)
            {
                stringItem = ratesFile.ReadLine().Trim();
                indexItem = Convert.ToInt16(stringItem.IndexOf("<item>"));

                while (indexItem == -1 && ratesFile.EndOfStream == false)
                {
                    stringItem = ratesFile.ReadLine().Trim();
                    indexItem = Convert.ToInt16(stringItem.IndexOf("<item>"));
                }

                count++;
            }

            ratesFile.Close();

            return count;
        }

        private void fillArrCurrenciesAndAddCboCurrencies()
        {
            StreamReader ratesFile = new StreamReader(filePathAndName);

            Int16 count = 0;
            Int16 indexItem;
            string stringItem;

            /**
             * 
             * read the file geting the values, filling the array of structures and add the CurrencyCode + " " + CurrencyName in the cbo
             * 
             */
            while (ratesFile.EndOfStream == false && count < arrCurrencies.Length)
            {
                stringItem = ratesFile.ReadLine().Trim();
                indexItem = Convert.ToInt16(stringItem.IndexOf("<item>"));

                while (indexItem == -1 && ratesFile.EndOfStream == false)
                {
                    stringItem = ratesFile.ReadLine().Trim();
                    indexItem = Convert.ToInt16(stringItem.IndexOf("<item>"));
                }

                if (indexItem != -1)
                {

                    stringItem = ratesFile.ReadLine().Trim();
                    indexItem = Convert.ToInt16(stringItem.IndexOf("<baseCurrency>"));


                    while (indexItem == -1 && ratesFile.EndOfStream == false)
                    {

                        stringItem = ratesFile.ReadLine().Trim();
                        indexItem = Convert.ToInt16(stringItem.IndexOf("<baseCurrency>"));

                    }

                    arrCurrencies[count].usdCurrencyCode = extractValueFromTags(stringItem, indexItem);


                    stringItem = ratesFile.ReadLine().Trim();
                    indexItem = Convert.ToInt16(stringItem.IndexOf("<baseName>"));


                    while (indexItem == -1 && ratesFile.EndOfStream == false)
                    {

                        stringItem = ratesFile.ReadLine().Trim();
                        indexItem = Convert.ToInt16(stringItem.IndexOf("<baseName>"));

                    }

                    arrCurrencies[count].usdCurrencyName = extractValueFromTags(stringItem, indexItem);

                    if (count == 0)
                    {
                        arrCurrencies[count].CurrencyName = arrCurrencies[count].usdCurrencyName;
                        arrCurrencies[count].CurrencyCode = arrCurrencies[count].usdCurrencyCode;
                        arrCurrencies[count].ValueUSDToCurrent = arrCurrencies[count].ValueCurrentToUSD = 1;

                        cboCurrenciesFrom.Items.Add(arrCurrencies[count].CurrencyCode + " " + arrCurrencies[count].CurrencyName);
                        cboCurrenciesTo.Items.Add(arrCurrencies[count].CurrencyCode + " " + arrCurrencies[count].CurrencyName);

                        count++;

                        arrCurrencies[count].usdCurrencyName = arrCurrencies[count - 1].usdCurrencyName;
                        arrCurrencies[count].usdCurrencyCode = arrCurrencies[count - 1].usdCurrencyCode;

                    }


                    stringItem = ratesFile.ReadLine().Trim();
                    indexItem = Convert.ToInt16(stringItem.IndexOf("<targetCurrency>"));


                    while (indexItem == -1 && ratesFile.EndOfStream == false)
                    {

                        stringItem = ratesFile.ReadLine().Trim();
                        indexItem = Convert.ToInt16(stringItem.IndexOf("<targetCurrency>"));

                    }

                    arrCurrencies[count].CurrencyCode = extractValueFromTags(stringItem, indexItem);


                    stringItem = ratesFile.ReadLine().Trim();
                    indexItem = Convert.ToInt16(stringItem.IndexOf("<targetName>"));


                    while (indexItem == -1 && ratesFile.EndOfStream == false)
                    {

                        stringItem = ratesFile.ReadLine().Trim();
                        indexItem = Convert.ToInt16(stringItem.IndexOf("<targetName>"));

                    }

                    arrCurrencies[count].CurrencyName = extractValueFromTags(stringItem, indexItem);


                    stringItem = ratesFile.ReadLine().Trim();
                    indexItem = Convert.ToInt16(stringItem.IndexOf("<exchangeRate>"));


                    while (indexItem == -1 && ratesFile.EndOfStream == false)
                    {

                        stringItem = ratesFile.ReadLine().Trim();
                        indexItem = Convert.ToInt16(stringItem.IndexOf("<exchangeRate>"));

                    }

                    arrCurrencies[count].ValueUSDToCurrent = Convert.ToSingle(extractValueFromTags(stringItem, indexItem));

                    stringItem = ratesFile.ReadLine().Trim();
                    indexItem = Convert.ToInt16(stringItem.IndexOf("<inverseRate>"));


                    while (indexItem == -1 && ratesFile.EndOfStream == false)
                    {

                        stringItem = ratesFile.ReadLine().Trim();
                        indexItem = Convert.ToInt16(stringItem.IndexOf("<inverseRate>"));

                    }

                    arrCurrencies[count].ValueCurrentToUSD = Convert.ToSingle(extractValueFromTags(stringItem, indexItem));
                }

                if (stringItem != "</channel>")
                {
                    cboCurrenciesFrom.Items.Add(arrCurrencies[count].CurrencyCode + " " + arrCurrencies[count].CurrencyName);
                    cboCurrenciesTo.Items.Add(arrCurrencies[count].CurrencyCode + " " + arrCurrencies[count].CurrencyName);
                    count++;
                }
            }

            ratesFile.Close();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCurrenciesFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            auxSelectedIndexChanged("from");
        }

        private void cboCurrenciesTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            auxSelectedIndexChanged("to");
        }

        private void auxSelectedIndexChanged(string cboSelected)
        {
            string msgTitle = "$ Internaccional online currency exchange";
            string msg = "Cannot select the same currency. Please select another currency to calculate!";

            
            if (( cboSelected == "from" && (cboCurrenciesFrom.SelectedItem != null )) || (cboSelected == "to" && (cboCurrenciesTo.SelectedItem != null)))
            {

                if ( ( cboSelected == "from" && (cboCurrenciesTo.SelectedItem == null || cboCurrenciesFrom.SelectedItem.ToString() != cboCurrenciesTo.SelectedItem.ToString()) ) || (cboSelected == "to" && (cboCurrenciesFrom.SelectedItem == null || cboCurrenciesTo.SelectedItem.ToString() != cboCurrenciesFrom.SelectedItem.ToString()) ) )
                {
                    for (Int16 i = 0; i < nbCurrencies; i++)
                    {
                        //if (arrCurrencies[i].Name == cboCurrenciesFrom.SelectedItem)
                        if (cboSelected == "from" && ( (arrCurrencies[i].CurrencyCode + " " + arrCurrencies[i].CurrencyName) == cboCurrenciesFrom.SelectedItem.ToString()) )
                        {
                            fromValueUSDToCurrency = arrCurrencies[i].ValueUSDToCurrent;
                            fromValueCurrencyToUSD = arrCurrencies[i].ValueCurrentToUSD;

                            fromUsdCurrencyName = arrCurrencies[i].usdCurrencyName;
                            fromCurrencyName = arrCurrencies[i].CurrencyName;

                            fromCurrencyCode = arrCurrencies[i].CurrencyCode;
                            fromUsdCurrencyCode = arrCurrencies[i].usdCurrencyCode;
                            indexSelectedFrom = Convert.ToInt16(cboCurrenciesFrom.SelectedIndex);

                            //MessageBox.Show(fromValueUSDToCurrency + "\n" + fromValueCurrencyToUSD + "\n" + fromUsdCurrencyName + "\n" + fromCurrencyName + "\n" + fromCurrencyCode + "\n" + fromUsdCurrencyCode);

                            break;

                        }

                        if (cboSelected == "to" && ( (arrCurrencies[i].CurrencyCode + " " + arrCurrencies[i].CurrencyName) == cboCurrenciesTo.SelectedItem.ToString() ))
                        {
                            toValueUSDToCurrency = arrCurrencies[i].ValueUSDToCurrent;
                            toValueCurrencyToUSD = arrCurrencies[i].ValueCurrentToUSD;

                            toUsdCurrencyName = arrCurrencies[i].usdCurrencyName;
                            toCurrencyName = arrCurrencies[i].CurrencyName;

                            toCurrencyCode = arrCurrencies[i].CurrencyCode;
                            toUsdCurrencyCode = arrCurrencies[i].usdCurrencyCode;

                            indexSelectedTo = Convert.ToInt16(cboCurrenciesTo.SelectedIndex);

                            //MessageBox.Show(toValueUSDToCurrency + "\n" + toValueCurrencyToUSD + "\n" + toUsdCurrencyName + "\n" + toCurrencyName + "\n" + toCurrencyCode + "\n" + toUsdCurrencyCode);

                            break;

                        }

                    }
                }
                else
                {

                    MessageBox.Show(msg, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (cboSelected == "from")
                    {
                        if (indexSelectedFrom != -1)
                        {
                            cboCurrenciesFrom.SelectedIndex = indexSelectedFrom;
                        }
                        else
                        {
                            cboCurrenciesFrom.SelectedItem = null;
                            cboCurrenciesFrom.Text = "Select Currency";
                        }
                    }
                    else
                    {
                        if (indexSelectedTo != -1)
                        {
                            cboCurrenciesTo.SelectedIndex = indexSelectedTo;
                        }
                        else
                        {
                            cboCurrenciesTo.SelectedItem = null;
                            cboCurrenciesTo.Text = "Select Currency";
                        }

                    }
                }

            }
        }

        private void txtAmountEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            else
            {
                bool hasDot = txtAmountEnter.Text.Contains('.');

                if (e.KeyChar == '.' && hasDot)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtAmountResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            else
            {
                bool hasDot = txtAmountResult.Text.Contains('.');

                if (e.KeyChar == '.' && hasDot)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Int16 auxSwitch;

            if (cboCurrenciesFrom.SelectedItem != null || cboCurrenciesTo.SelectedItem != null)
            {
                auxSwitch = indexSelectedFrom;
                indexSelectedFrom = indexSelectedTo;
                indexSelectedTo = auxSwitch;

                cboCurrenciesTo.SelectedIndex = -1;
                cboCurrenciesFrom.SelectedIndex = indexSelectedFrom;
                cboCurrenciesTo.SelectedIndex = indexSelectedTo;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateFileCreateCurrenciesArrFillUpCbo();
        }

        private void downloadSaveFile()
        {
            string msgTitle = "$ Internaccional online currency exchange";
            string msg = "The latest rates file (XML Daily Foreign Exchange Rates for U.S. Dollar (USD).xml) was downloaded and updated sucessfully.";
            Int16 retriesNum = 3, waitToRetry = 1000;
            bool wasDownloadedUpdated = false;

            for (int i = 0; i < retriesNum; i++)
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("http://www.floatrates.com/daily/usd.xml");
                    doc.Save(Path.Combine("", "XML Daily Foreign Exchange Rates for U.S. Dollar (USD).xml"));

                    if (countUpdatedsFile != 0)
                    {
                        MessageBox.Show(msg, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    wasDownloadedUpdated = true;

                    break;
                }
                catch (Exception e) when (i < retriesNum)
                {
                    if (i < retriesNum)
                    {
                        if (countUpdatedsFile != 0)
                        {
                            msg = "Error download the latest version of the file: XML Daily Foreign Exchange Rates for U.S. Dollar (USD).xml\nPlease check you internet connection!\n Try " + (i + 1) + " of " + retriesNum;
                            MessageBox.Show(msg, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Task.Delay(waitToRetry);
                    }
                    
                }
            }

            if(countUpdatedsFile != 0 && !wasDownloadedUpdated)
            {
                msg = "It was not possible to download the latest version of the file: XML Daily Foreign Exchange Rates for U.S. Dollar (USD).xml\nThe application will use a previous file downloaded. Please check your internet connection and try to update after!";
                MessageBox.Show(msg, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            countUpdatedsFile++;

        }

        private void updateFileCreateCurrenciesArrFillUpCbo()
        {
            downloadSaveFile();

            lblDisplayDateTime.Text = extractFileDateTime();

            nbCurrencies = getCurrencyQuantity();

            arrCurrencies = new Currency[nbCurrencies];

            fillArrCurrenciesAndAddCboCurrencies();
        }

        private void btnSwitch_MouseDown(object sender, MouseEventArgs e)
        {
            btnSwitch.ForeColor = Color.LightGray;
        }

        private void btnSwitch_MouseUp(object sender, MouseEventArgs e)
        {
            btnSwitch.ForeColor = Color.DarkSlateGray;
        }

        private void btnSwitch_MouseEnter(object sender, EventArgs e)
        {
            btnSwitch.ForeColor = Color.LightGray;
        }

        private void btnSwitch_MouseLeave(object sender, EventArgs e)
        {
            btnSwitch.ForeColor = Color.DarkSlateGray;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string msgTitle = "$ Internaccional online currency exchange";
            string msg = "Invalid data: ";

            Int16 lengthAmountEnter = Convert.ToInt16(txtAmountEnter.Text.Trim().Length);
            Int16 lengthAmountResult = Convert.ToInt16(txtAmountResult.Text.Trim().Length);

            if (cboCurrenciesFrom.SelectedItem != null && cboCurrenciesTo.SelectedItem != null)
            {
                if (lengthAmountEnter > 0 || lengthAmountResult > 0)
                {
                    //if (lengthAmountEnter > 0 && lengthAmountResult == 0)
                    if (lengthAmountEnter > 0)
                    {
                        if (lengthAmountEnter == 1 && txtAmountEnter.Text.Trim() == ".")
                        {
                            msg += "Please enter numbers with '.' (dots).  Do not enter only '.' (dots)!";
                            MessageBox.Show(msg, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //txtAmountEnter.Text = "";
                            txtAmountEnter.Focus();
                        }
                        else
                        {
                            if (txtAmountEnter.Text.Trim().EndsWith("."))
                            {
                                //txtAmountEnter.Text = txtAmountEnter.Text.Trim().Remove(txtAmountEnter.Text.Length - 1, 1);
                                txtAmountEnter.Text = txtAmountEnter.Text.Trim().Remove(lengthAmountEnter - 1, 1);
                            }

                            Single amountEnter = Convert.ToSingle(txtAmountEnter.Text.Trim());
                            Single valueCalcFromCurrencyToUSD = fromValueCurrencyToUSD * amountEnter;
                            Single calculateValueTo = valueCalcFromCurrencyToUSD / toValueCurrencyToUSD;

                            txtAmountResult.Text = calculateValueTo.ToString();


                        }
                    }
                    else //(lengthAmountEnter == 0 && lengthAmountResult > 0)
                    {
                        if (lengthAmountResult == 1 && txtAmountResult.Text.Trim() == ".")
                        {
                            msg += "Please enter numbers with '.' (dots).  Do not enter only '.' (dots)!";
                            MessageBox.Show(msg, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //txtAmountEnter.Text = "";
                            txtAmountResult.Focus();
                        }
                        else
                        {
                            if (txtAmountResult.Text.Trim().EndsWith("."))
                            {
                                //txtAmountResult.Text = txtAmountResult.Text.Trim().Remove(txtAmountResult.Text.Length - 1, 1);
                                txtAmountResult.Text = txtAmountResult.Text.Trim().Remove(lengthAmountResult - 1, 1);
                            }

                            Single amountResult = Convert.ToSingle(txtAmountResult.Text.Trim());
                            Single valueCalcToCurrencyToUSD = toValueCurrencyToUSD * amountResult;
                            Single calculateValueFrom = valueCalcToCurrencyToUSD / fromValueCurrencyToUSD;

                            txtAmountEnter.Text = calculateValueFrom.ToString();


                        }
                    }
                }
            }
            else
            {
                if (cboCurrenciesFrom.SelectedItem == null)
                {
                    msg += "Please select the currency From you want to calculate!";
                    MessageBox.Show(msg, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboCurrenciesFrom.Focus();
                }
                else
                {
                    msg += "Please select the currency To you want to calculate!";
                    MessageBox.Show(msg, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboCurrenciesTo.Focus();
                }
                
            }

            
        }
    }
}
