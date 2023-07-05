namespace prjWinCsCalculatorsCurrencyExchanges2in1
{
    partial class frmUserManual
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserManual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBehaviours = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER MANUAL";
            // 
            // lblUserManual
            // 
            this.lblUserManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserManual.Location = new System.Drawing.Point(34, 45);
            this.lblUserManual.Name = "lblUserManual";
            this.lblUserManual.Size = new System.Drawing.Size(463, 42);
            this.lblUserManual.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Behaviours";
            // 
            // lblBehaviours
            // 
            this.lblBehaviours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBehaviours.Location = new System.Drawing.Point(34, 122);
            this.lblBehaviours.Name = "lblBehaviours";
            this.lblBehaviours.Size = new System.Drawing.Size(463, 414);
            this.lblBehaviours.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(422, 551);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "&OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmUserManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 586);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblBehaviours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserManual);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserManual";
            this.ShowIcon = false;
            this.Text = "User Manual";
            this.Load += new System.EventHandler(this.frmUserManual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBehaviours;
        private System.Windows.Forms.Button btnOk;
    }
}