namespace prjWinCsCalculatorsCurrencyExchanges2in1
{
    partial class frmChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAnyToUS = new System.Windows.Forms.RadioButton();
            this.rbtnUSToAny = new System.Windows.Forms.RadioButton();
            this.lblCurrentUSToAny = new System.Windows.Forms.Label();
            this.lblCurrentAnyToUS = new System.Windows.Forms.Label();
            this.lblConvertFrom = new System.Windows.Forms.Label();
            this.txtConvertValue = new System.Windows.Forms.TextBox();
            this.lblValueConvertedResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "CURRENCY - EXCHANGE";
            // 
            // cboCountries
            // 
            this.cboCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Location = new System.Drawing.Point(21, 83);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(197, 26);
            this.cboCountries.TabIndex = 7;
            this.cboCountries.Text = "Select Country";
            this.cboCountries.SelectedIndexChanged += new System.EventHandler(this.cboCountries_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAnyToUS);
            this.groupBox1.Controls.Add(this.rbtnUSToAny);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 96);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion type";
            // 
            // rbtnAnyToUS
            // 
            this.rbtnAnyToUS.AutoSize = true;
            this.rbtnAnyToUS.Location = new System.Drawing.Point(29, 48);
            this.rbtnAnyToUS.Name = "rbtnAnyToUS";
            this.rbtnAnyToUS.Size = new System.Drawing.Size(14, 13);
            this.rbtnAnyToUS.TabIndex = 6;
            this.rbtnAnyToUS.TabStop = true;
            this.rbtnAnyToUS.UseVisualStyleBackColor = true;
            this.rbtnAnyToUS.CheckedChanged += new System.EventHandler(this.rbtnAnyToUS_CheckedChanged);
            // 
            // rbtnUSToAny
            // 
            this.rbtnUSToAny.AutoSize = true;
            this.rbtnUSToAny.Location = new System.Drawing.Point(29, 24);
            this.rbtnUSToAny.Name = "rbtnUSToAny";
            this.rbtnUSToAny.Size = new System.Drawing.Size(14, 13);
            this.rbtnUSToAny.TabIndex = 5;
            this.rbtnUSToAny.TabStop = true;
            this.rbtnUSToAny.UseVisualStyleBackColor = true;
            this.rbtnUSToAny.CheckedChanged += new System.EventHandler(this.rbtnUSToAny_CheckedChanged);
            // 
            // lblCurrentUSToAny
            // 
            this.lblCurrentUSToAny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentUSToAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUSToAny.Location = new System.Drawing.Point(309, 108);
            this.lblCurrentUSToAny.Name = "lblCurrentUSToAny";
            this.lblCurrentUSToAny.Size = new System.Drawing.Size(289, 30);
            this.lblCurrentUSToAny.TabIndex = 12;
            // 
            // lblCurrentAnyToUS
            // 
            this.lblCurrentAnyToUS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentAnyToUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAnyToUS.Location = new System.Drawing.Point(309, 150);
            this.lblCurrentAnyToUS.Name = "lblCurrentAnyToUS";
            this.lblCurrentAnyToUS.Size = new System.Drawing.Size(289, 30);
            this.lblCurrentAnyToUS.TabIndex = 13;
            // 
            // lblConvertFrom
            // 
            this.lblConvertFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConvertFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertFrom.Location = new System.Drawing.Point(343, 222);
            this.lblConvertFrom.Name = "lblConvertFrom";
            this.lblConvertFrom.Size = new System.Drawing.Size(134, 30);
            this.lblConvertFrom.TabIndex = 14;
            // 
            // txtConvertValue
            // 
            this.txtConvertValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertValue.Location = new System.Drawing.Point(343, 257);
            this.txtConvertValue.Name = "txtConvertValue";
            this.txtConvertValue.Size = new System.Drawing.Size(133, 26);
            this.txtConvertValue.TabIndex = 15;
            this.txtConvertValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConvertValue_KeyPress);
            // 
            // lblValueConvertedResult
            // 
            this.lblValueConvertedResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValueConvertedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueConvertedResult.Location = new System.Drawing.Point(50, 346);
            this.lblValueConvertedResult.Name = "lblValueConvertedResult";
            this.lblValueConvertedResult.Size = new System.Drawing.Size(168, 30);
            this.lblValueConvertedResult.TabIndex = 16;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(537, 221);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(114, 31);
            this.btnConvert.TabIndex = 17;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(537, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 31);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(537, 295);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(114, 31);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 393);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblValueConvertedResult);
            this.Controls.Add(this.txtConvertValue);
            this.Controls.Add(this.lblConvertFrom);
            this.Controls.Add(this.lblCurrentAnyToUS);
            this.Controls.Add(this.lblCurrentUSToAny);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboCountries);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmChange";
            this.Text = "$ International currency exchange";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCountries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAnyToUS;
        private System.Windows.Forms.RadioButton rbtnUSToAny;
        private System.Windows.Forms.Label lblCurrentUSToAny;
        private System.Windows.Forms.Label lblCurrentAnyToUS;
        private System.Windows.Forms.Label lblConvertFrom;
        private System.Windows.Forms.TextBox txtConvertValue;
        private System.Windows.Forms.Label lblValueConvertedResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
    }
}