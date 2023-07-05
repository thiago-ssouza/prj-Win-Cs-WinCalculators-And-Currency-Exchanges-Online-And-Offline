using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatorsCurrencyExchanges2in1
{
    public partial class frmStandardCalculator : Form
    {
        string value1 = "", value2 = "", memory = "";
        string operation = "";
        string result = "";
        bool entryHasChanged = false;
        string lastPercentage = "";
        bool lastWasEqual = false;
        const string DIVIDE_BY_ZERO_ERROR = "Cannot divide by zero";
        const string DIVIDE_BY_ZERO_ERROR_UNDEFINED = "Result is undefined";


        public frmStandardCalculator()
        {
            InitializeComponent();
        }

        private void frmStandardCalculator_Load(object sender, EventArgs e)
        {
            btnMc.ForeColor = btnMr.ForeColor = Color.DarkGray;
            btnMc.Enabled = btnMr.Enabled = false;
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addNumber(sender, e, 9);
        }

        private void addNumber(object sender, EventArgs e, Int16 numberEntered)
        {
            if (verifyDivideByZeroError())
            {
                resetDefaultBtnEntry();
            }

           if (! (lblEntry.Text.Length >= 16) ) {
                
                
                if ((!(Convert.ToSingle(lblEntry.Text) == 0) && entryHasChanged == true) || (lblEntry.Text.EndsWith(".") && entryHasChanged == true))
                {
                    lblEntry.Text += numberEntered.ToString();
                }
                else if (result != "" && value2 != "")
                {
                    lblEntry.Text = numberEntered.ToString();
                    lblResultDisplay.Text = "";
                    value1 = lblEntry.Text;
                }
                else if (result == "" && value2 != "")
                {
                    lblEntry.Text = numberEntered.ToString();
                    lblResultDisplay.Text = value1 + " " + operation;
                    value2 = "";
                }
                else
                {
                    lblEntry.Text = numberEntered.ToString();
                }

                entryHasChanged = true;

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if(verifyDivideByZeroError())
            {
                resetDefaultBtnEntry();
            }
            else
            {
                lblResultDisplay.Text = "";
                lblEntry.Text = 0.ToString();
                value1 = value2 = operation = result = "";
                entryHasChanged = false;
                lastPercentage = "";
                lastWasEqual = false;
            }
            
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            if (verifyDivideByZeroError())
            {
                resetDefaultBtnEntry();
            }
            else
            {
                if (result != "" && value2 != "")
                {
                    lblResultDisplay.Text = "";
                    lblEntry.Text = 0.ToString();
                    value1 = lblEntry.Text;
                    lastPercentage = "";
                    lastWasEqual = false;
                }
                else
                {
                    lblEntry.Text = 0.ToString();
                    lastPercentage = "";
                    lastWasEqual = false;
                }
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            preOperation("+");
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            preOperation("-");
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            preOperation("×");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            preOperation("÷");
        }

        private void preOperation(String currentOperation)
        {
            if ((operation != currentOperation && value1 != "" && entryHasChanged == true) || (operation != currentOperation && value1 == "" && result != "" && entryHasChanged == true))
            {
                calculateExpression();

                operation = currentOperation;

                if (result != DIVIDE_BY_ZERO_ERROR && result != DIVIDE_BY_ZERO_ERROR_UNDEFINED)
                {
                    if (result != "")
                    {
                        lblResultDisplay.Text = result + " " + operation;
                    }
                    else
                    {
                        lblResultDisplay.Text = value1 + " " + operation;
                    }
                    
                }
                else
                {
                    lblResultDisplay.Text = lblResultDisplay.Text.Substring(0, lblResultDisplay.Text.Length - 1) + operation;
                }
            }

            else
            {
                operation = currentOperation;
                calculateExpression();
            }
            lastWasEqual = false;
        }

        private void calculateExpression()
        {
            removeDotFromEnd();

            if (value1 == "")
            {
                if (result != "")
                {
                    if (value2 != "")
                    {
                        value1 = lblEntry.Text;
                        lblResultDisplay.Text = value1 + " " + operation;
                    }
                    else
                    {
                        value1 = result;
                        lblResultDisplay.Text = result + " " + operation;
                    }
 
                }
                else
                {
                    value1 = lblEntry.Text;
                    lblResultDisplay.Text = value1 + " " + operation;
                    entryHasChanged = false;
                }
                
            }
            else
            {
                if (result != "")
                {
                    if (value2 != "")
                    {
                        lblResultDisplay.Text = value1 + " " + operation;
                    }
                    else
                    {
                        lblResultDisplay.Text = result + " " + operation;
                    }
                    
                }
                else
                {
                    lblResultDisplay.Text = value1 + " " + operation;
                }
            }
            
            if (value2 == "")
            {

            
                if (entryHasChanged)
                {
                    value2 = lblEntry.Text;

                    verifyCalculateOperation();

                    lblEntry.Text = result;

                    lblResultDisplay.Text = (result != DIVIDE_BY_ZERO_ERROR && result != DIVIDE_BY_ZERO_ERROR_UNDEFINED) ? result + " " + operation : value1 + " " + operation + " " + value2 + " " + operation;

                    value2 = "";
                    value1 = "";
                
                }
            }
            else
            {
                value2 = "";
                result = "";
            }
            
            entryHasChanged = false;

        }

        private void resetDefaultBtnEntry()
        {
            btnPercentage.Enabled = btnOneDivideByX.Enabled = btnSquare.Enabled = btnSquareRoot.Enabled = btnPlusMinus.Enabled = btnDecimalPoint.Enabled = btnMPlus.Enabled = btnMMinus.Enabled = btnMs.Enabled = btnDivision.Enabled = btnMultiplication.Enabled = btnSubtraction.Enabled = btnAddition.Enabled = true;
            
            btnPercentage.ForeColor = btnOneDivideByX.ForeColor = btnSquare.ForeColor = btnSquareRoot.ForeColor = btnPlusMinus.ForeColor = btnDecimalPoint.ForeColor = btnMPlus.ForeColor = btnMMinus.ForeColor = btnMs.ForeColor = btnDivision.ForeColor = btnMultiplication.ForeColor = btnSubtraction.ForeColor = btnAddition.ForeColor = Form.DefaultForeColor;
            
            value1 = value2 = result = operation =  lblResultDisplay.Text = "";
            
            lblEntry.Text = 0.ToString();
            lastPercentage = "";
            lastWasEqual = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (verifyDivideByZeroError())
            {
                resetDefaultBtnEntry();
            }
            else
            {
                if (entryHasChanged == true && lblEntry.Text != "")
                {
                    if (lblEntry.Text.Length > 1)
                    {
                        lblEntry.Text = lblEntry.Text.Remove(lblEntry.Text.Length - 1, 1);
                    }
                    else
                    {
                        lblEntry.Text = 0.ToString();
                        value1 = "0";
                    }
                }
            }

        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            string transformedNum = "";

            
            transformedNum = Convert.ToSingle(lblEntry.Text) < 0 ? Math.Abs(Convert.ToSingle(lblEntry.Text)).ToString() : (Convert.ToSingle(lblEntry.Text) * -1).ToString();

            if (entryHasChanged)
            {
                if (lblEntry.Text != "0")
                {
                    lblEntry.Text = transformedNum;
                }
            }
            else
            {
                if (lblEntry.Text != "0")
                {    
                    lblEntry.Text = transformedNum;
                    if (transformedNum.IndexOf('-') != -1) {
                        lblResultDisplay.Text += " " + transformedNum.ToString();
                    }
                    else
                    {
                        lblResultDisplay.Text += " " +  "+"  + transformedNum.ToString();
                    }
                    if (result == "") {
                        value1 = (Convert.ToSingle(value1) + Convert.ToSingle(transformedNum)).ToString();
                    }
                    else
                    {
                        result = (Convert.ToSingle(result) + Convert.ToSingle(transformedNum)).ToString();
                    }                        

                }

            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            removeDotFromEnd();
            
            if (verifyDivideByZeroError())
            {
                resetDefaultBtnEntry();
            }
            else
            {
                if (value1 == "" && result == "")
                {
                    lblResultDisplay.Text = lblEntry.Text + " " + "=";
                }
                else {

                    if (value1 != "" && result == "")
                    {
                        value2 = lblEntry.Text;
                        
                    } else if (value1 == "" && result != "")
                    {
                        value1 = lblEntry.Text;
                        if (value2 == "")
                        {
                            value2 = value1;
                        }
                        value1 = result;
                        
                    }

                    verifyCalculateOperation();

                    lblResultDisplay.Text = (result != DIVIDE_BY_ZERO_ERROR && result != DIVIDE_BY_ZERO_ERROR_UNDEFINED) ? value1 + " " + operation + " " + value2 + " " + "=" : value1 + " " + operation;
                    lblEntry.Text = result;
                    value1 = "";

                }
            }

            lastPercentage = "";
            lastWasEqual = true;

            entryHasChanged = false;
            
        }

        private void verifyCalculateOperation()
        {
            switch (operation)
            {
                case "+":
                    result = (Convert.ToSingle(value1) + Convert.ToSingle(value2)).ToString();
                    break;
                case "-":
                    result = (Convert.ToSingle(value1) - Convert.ToSingle(value2)).ToString();
                    break;
                case "×":
                    result = (Convert.ToSingle(value1) * Convert.ToSingle(value2)).ToString();
                    break;
                case "÷":
                    if (value1 != "0" && value2 != "0")
                    {
                        result = (Convert.ToSingle(value1) / Convert.ToSingle(value2)).ToString();
                    }
                    else
                    {
                        if (value1 == "0" && value2 != "0")
                        {
                            result = (Convert.ToSingle(value1) / Convert.ToSingle(value2)).ToString();
                        }
                        else
                        {
                            if (value1 != "0" && value2 == "0")
                            {
                                result = DIVIDE_BY_ZERO_ERROR;
                            }
                            else if (value1 == "0" && value2 == "0")
                            {
                                result = DIVIDE_BY_ZERO_ERROR_UNDEFINED;
                            }

                            btnPercentage.ForeColor = btnOneDivideByX.ForeColor = btnSquare.ForeColor = btnSquareRoot.ForeColor = btnPlusMinus.ForeColor = btnDecimalPoint.ForeColor = btnMc.ForeColor = btnMr.ForeColor = btnMPlus.ForeColor = btnMMinus.ForeColor = btnMs.ForeColor = btnDivision.ForeColor = btnMultiplication.ForeColor = btnSubtraction.ForeColor = btnAddition.ForeColor = Color.DimGray;
                            btnPercentage.Enabled = btnOneDivideByX.Enabled = btnSquare.Enabled = btnSquareRoot.Enabled = btnPlusMinus.Enabled = btnDecimalPoint.Enabled = btnMc.Enabled = btnMr.Enabled = btnMPlus.Enabled = btnMMinus.Enabled = btnMs.Enabled = btnDivision.Enabled = btnMultiplication.Enabled = btnSubtraction.Enabled = btnAddition.Enabled = false;
                        }

                    }
                    break;
            }
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {

                if (entryHasChanged && lblEntry.Text.IndexOf(".") == -1)
                {
                    lblEntry.Text += ".";
                }
                else
                {
                    if (result != "" && value2 != "")
                    {
                        lblEntry.Text = 0.ToString() + ".";
                        lblResultDisplay.Text = "";
                        value1 = lblEntry.Text;
                    }
                    else
                    {
                        lblEntry.Text = 0.ToString() + ".";
                    }
                    
                }
                
                entryHasChanged = true;
            
        }

        private void removeDotFromEnd()
        {
            if (lblEntry.Text.EndsWith("."))
            {
                lblEntry.Text = lblEntry.Text.Remove((lblEntry.Text.Length - 1), 1);
            }
            if (value1.EndsWith("."))
            {
                value1 = value1.Remove((value1.Length - 1), 1);
            }
            if (value2.EndsWith("."))
            {
                value2 = value2.Remove((value2.Length - 1), 1);
            }
            if (result.EndsWith("."))
            {
                result = result.Remove((result.Length - 1), 1);
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
           
            
            if (value1 == "" && result == "")
            {
                lblEntry.Text = 0.ToString();
                lblResultDisplay.Text = 0.ToString();
            }
            else
            {
                if ((value1 != "" && result == "") && (operation == "+" || operation == "-"))
                {
                    
                    value2 = (Convert.ToSingle(value1) * (Convert.ToSingle(lblEntry.Text) / 100)).ToString();
                    
                    lblEntry.Text = value2;
                    lblResultDisplay.Text = value1 + " " + operation + " " + value2;

                }
                else if (((value1 != "" && result == "") && (operation == "×" || operation == "÷")))
                {
                    value2 = (Convert.ToSingle(lblEntry.Text) / 100).ToString();
                    lblEntry.Text = value2;
                    lblResultDisplay.Text = value1 + " " + operation + " " + value2;

                }
                else if (result != "")
                {
                    if (lastPercentage == "")
                    {
                        lastPercentage = (Convert.ToSingle(result)).ToString();
                    }

                    if (entryHasChanged)
                    {
                        result = (Convert.ToSingle(lblEntry.Text) * Convert.ToSingle(lastPercentage) / 100).ToString();
                        value1 = result;
                        lblResultDisplay.Text = result;
                        lblEntry.Text = result;
                    }
                    else
                    {

                        if (!lastWasEqual)
                        {
                            value2 = (Convert.ToSingle(value1) * (Convert.ToSingle(lblEntry.Text) / 100)).ToString();
                            lblEntry.Text = value2;
                            lblResultDisplay.Text = value1 + " " + operation + " " + value2;
                            result = value2;

                        }
                        else
                        {
                            result = (Convert.ToSingle(result) * Convert.ToSingle(lastPercentage) /100).ToString();
                            lblResultDisplay.Text = result;
                            lblEntry.Text = result;

                        }


                    }

                }
            }

            entryHasChanged = false;
            
            
        }

        private void btnOneDivideByX_Click(object sender, EventArgs e)
        {
            
            if (value1 == "" && result == "")
            {
                if (lblEntry.Text == "0")
                {
                    result = DIVIDE_BY_ZERO_ERROR;
                    lblResultDisplay.Text = 1.ToString() + "/" + lblEntry.Text;
                    lblEntry.Text = result;
                    btnPercentage.Enabled = btnOneDivideByX.Enabled = btnSquare.Enabled = btnSquareRoot.Enabled = btnPlusMinus.Enabled = btnDecimalPoint.Enabled = btnMc.Enabled = btnMr.Enabled = btnMPlus.Enabled = btnMMinus.Enabled = btnMs.Enabled = btnDivision.Enabled = btnMultiplication.Enabled = btnSubtraction.Enabled = btnAddition.Enabled = false;
                    btnPercentage.ForeColor = btnOneDivideByX.ForeColor = btnSquare.ForeColor = btnSquareRoot.ForeColor = btnPlusMinus.ForeColor = btnDecimalPoint.ForeColor = btnMc.ForeColor = btnMr.ForeColor = btnMPlus.ForeColor = btnMMinus.ForeColor = btnMs.ForeColor = btnDivision.ForeColor = btnMultiplication.ForeColor = btnSubtraction.ForeColor = btnAddition.ForeColor = Color.DimGray;
                }                
                else
                {
                    lblResultDisplay.Text = 1 + "/" + "(" + lblEntry.Text + ")";
                    lblEntry.Text = (1 / Convert.ToSingle(lblEntry.Text)).ToString();
                }
                
            }
            else
            {
                if ((value1 != "" && result == ""))
                {
                    if (lblEntry.Text == "0")
                    {
                        result = DIVIDE_BY_ZERO_ERROR;
                        lblResultDisplay.Text = 1.ToString() + "/" + lblEntry.Text;
                        lblEntry.Text = result;
                        btnPercentage.Enabled = btnOneDivideByX.Enabled = btnSquare.Enabled = btnSquareRoot.Enabled = btnPlusMinus.Enabled = btnDecimalPoint.Enabled = btnMc.Enabled = btnMr.Enabled = btnMPlus.Enabled = btnMMinus.Enabled = btnMs.Enabled = btnDivision.Enabled = btnMultiplication.Enabled = btnSubtraction.Enabled = btnAddition.Enabled = false;
                        btnPercentage.ForeColor = btnOneDivideByX.ForeColor = btnSquare.ForeColor = btnSquareRoot.ForeColor = btnPlusMinus.ForeColor = btnDecimalPoint.ForeColor = btnMc.ForeColor = btnMr.ForeColor = btnMPlus.ForeColor = btnMMinus.ForeColor = btnMs.ForeColor = btnDivision.ForeColor = btnMultiplication.ForeColor = btnSubtraction.ForeColor = btnAddition.ForeColor = Color.DimGray;
                    }
                    else
                    {
                        value2 = (1 / Convert.ToSingle(lblEntry.Text)).ToString();
                        lblResultDisplay.Text = value1 + " " + operation + " " + 1 + "/" + "(" + lblEntry.Text + ")";
                        lblEntry.Text = value2;
                    }

                }

                else if (result != "")
                {
                    if (lblEntry.Text == "0")
                    {
                        result = DIVIDE_BY_ZERO_ERROR;
                        lblResultDisplay.Text = 1.ToString() + "/" + lblEntry.Text;
                        lblEntry.Text = result;
                        btnPercentage.Enabled = btnOneDivideByX.Enabled = btnSquare.Enabled = btnSquareRoot.Enabled = btnPlusMinus.Enabled = btnDecimalPoint.Enabled = btnMc.Enabled = btnMr.Enabled = btnMPlus.Enabled = btnMMinus.Enabled = btnMs.Enabled = btnDivision.Enabled = btnMultiplication.Enabled = btnSubtraction.Enabled = btnAddition.Enabled = false;
                        btnPercentage.ForeColor = btnOneDivideByX.ForeColor = btnSquare.ForeColor = btnSquareRoot.ForeColor = btnPlusMinus.ForeColor = btnDecimalPoint.ForeColor = btnMc.ForeColor = btnMr.ForeColor = btnMPlus.ForeColor = btnMMinus.ForeColor = btnMs.ForeColor = btnDivision.ForeColor = btnMultiplication.ForeColor = btnSubtraction.ForeColor = btnAddition.ForeColor = Color.DimGray;
                    }
                    else
                    {
                        if (entryHasChanged)
                        {
                            result = (1 / Convert.ToSingle(lblEntry.Text)).ToString();
                            value1 = result;
                            lblResultDisplay.Text = 1 + "/" + "(" + lblEntry.Text + ")";
                        }
                        else
                        {
                            result = (1 / Convert.ToSingle(result)).ToString();

                        }

                        lblResultDisplay.Text = result;
                   
                        lblEntry.Text = result;
                    }                  

                }
            }


            entryHasChanged = false;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (value1 == "" && result == "")
            {
                
                lblResultDisplay.Text = "sqr" + "(" + lblEntry.Text + ")";
                lblEntry.Text = (Convert.ToSingle(lblEntry.Text) * Convert.ToSingle(lblEntry.Text)).ToString();

            }
            else
            {
                if ((value1 != "" && result == ""))
                {
                    value2 = (Convert.ToSingle(lblEntry.Text) * Convert.ToSingle(lblEntry.Text)).ToString();
                    lblResultDisplay.Text = value1 + " " + operation + " " + "sqr" + "(" + lblEntry.Text + ")";
                    lblEntry.Text = value2;

                }
                else if (result != "")
                {
                    if(value2 == "")
                    {
                        if (entryHasChanged)
                        {
                            value1 = result;
                            result = (Convert.ToSingle(result) * Convert.ToSingle(lblEntry.Text)).ToString();
                            lblResultDisplay.Text = value1 + " " + operation + " " + "sqr" + "(" + lblEntry.Text + ")";
                            value2 = (Convert.ToSingle(lblEntry.Text) * Convert.ToSingle(lblEntry.Text)).ToString();
                        }
                        else
                        {
                            result = (Convert.ToSingle(result) * Convert.ToSingle(lblEntry.Text)).ToString();
                            value1 = result;
                            lblResultDisplay.Text = "sqr" + "(" + lblEntry.Text + ")";
                            value2 = (Convert.ToSingle(lblEntry.Text) * Convert.ToSingle(lblEntry.Text)).ToString();
                        }
                    }
                    else
                    {
                        if (entryHasChanged)
                        {
                            result = (Convert.ToSingle(lblEntry.Text) * Convert.ToSingle(lblEntry.Text)).ToString();
                            value1 = result;
                            lblResultDisplay.Text = "sqr" + "(" + lblEntry.Text + ")";
                        }
                        else
                        {
                            
                            result = (Convert.ToSingle(result) * Convert.ToSingle(result)).ToString();
                            lblResultDisplay.Text = "sqr" + "(" + lblEntry.Text + ")";
                        }
                    }

                    lblEntry.Text = result;

                }
            }


            entryHasChanged = false;
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            memory = "";
            //btnMc.ForeColor = btnMr.ForeColor = Color.DarkGray;
            btnMc.Enabled = btnMr.Enabled = false;
            entryHasChanged = false;
            if (value2 != "")
            {
                lblResultDisplay.Text = "";
            }
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memoryAddSub("+");
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            memoryAddSub("-");
        }

        private void memoryAddSub(String memOperation)
        {
            if (memory == "")
            {
                memory = lblEntry.Text;
            }
            else
            {
                if (memOperation == "+")
                {
                    memory = (Convert.ToSingle(memory) + Convert.ToSingle(lblEntry.Text)).ToString();
                }
                else
                {
                    memory = (Convert.ToSingle(memory) - Convert.ToSingle(lblEntry.Text)).ToString();
                }
            }
            if (value2 != "")
            {
                lblResultDisplay.Text = "";
            }

            enableMcMrBtns();
        }

        private void btnMs_Click(object sender, EventArgs e)
        {
            memory = lblEntry.Text;
            if (value2 != "")
            {
                lblResultDisplay.Text = "";
            }
            enableMcMrBtns();
        }

        private void btnMr_Click(object sender, EventArgs e)
        {
            lblEntry.Text = memory;
            if (value2 != "")
            {
                lblResultDisplay.Text = "";
            }
            entryHasChanged = false;

        }

        private void enableMcMrBtns()
        {
            btnMc.ForeColor = btnMr.ForeColor = Form.DefaultForeColor;
            btnMc.Enabled = btnMr.Enabled = true;
            entryHasChanged = false;

        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (value1 == "" && result == "")
            {

                lblResultDisplay.Text = "√" + "(" + lblEntry.Text + ")";
                lblEntry.Text =  (Math.Sqrt(Convert.ToSingle(lblEntry.Text))).ToString();

            }
            else
            {
                if ((value1 != "" && result == ""))
                {
                    value2 = Math.Sqrt(Convert.ToSingle(lblEntry.Text)).ToString();
                    lblResultDisplay.Text = value1 + " " + operation + " " + "√" + "(" + lblEntry.Text + ")";
                    lblEntry.Text = value2;

                }
                else if (result != "")
                {
                    if (value2 == "")
                    {
                        if (entryHasChanged)
                        {
                            value1 = result;
                            result = Math.Sqrt(Convert.ToSingle(lblEntry.Text)).ToString();
                            lblResultDisplay.Text = value1 + " " + operation + " " + "√" + "(" + lblEntry.Text + ")";
                            value2 = Math.Sqrt(Convert.ToSingle(lblEntry.Text)).ToString();
                        }
                        else
                        {
                            result = Math.Sqrt(Convert.ToSingle(lblEntry.Text)).ToString();
                            value1 = result;
                            lblResultDisplay.Text = "√" + "(" + lblEntry.Text + ")";
                            value2 = Math.Sqrt(Convert.ToSingle(lblEntry.Text)).ToString();
                        }
                    }
                    else
                    {
                        if (entryHasChanged)
                        {
                            result = Math.Sqrt(Convert.ToSingle(lblEntry.Text)).ToString();
                            value1 = result;
                            lblResultDisplay.Text = "√" + "(" + lblEntry.Text + ")";
                        }
                        else
                        {

                            result = Math.Sqrt(Convert.ToSingle(result)).ToString();
                            lblResultDisplay.Text = "√" + "(" + lblEntry.Text + ")";

                        }
                    }

                    lblEntry.Text = result;

                }
            }


            entryHasChanged = false;
        }

        private bool verifyDivideByZeroError()
        {
            if (lblEntry.Text == DIVIDE_BY_ZERO_ERROR || lblEntry.Text == DIVIDE_BY_ZERO_ERROR_UNDEFINED)
            {
                return true;
            }
            return false;
        }
    }
}
