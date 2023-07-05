namespace prjWinCsCalculatorsCurrencyExchanges2in1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mmBar = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCalcStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.miCalcScientific = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyExchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCurExchangeLocVer = new System.Windows.Forms.ToolStripMenuItem();
            this.miCurExchangeOnlVer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmViewTab = new System.Windows.Forms.ToolStripMenuItem();
            this.miToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.miStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserManual = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbrShortcut = new System.Windows.Forms.ToolStrip();
            this.tbbCalcStandard = new System.Windows.Forms.ToolStripButton();
            this.tbbCalcScientific = new System.Windows.Forms.ToolStripButton();
            this.tbbCurExchangeLocVer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbCurExchangeOnlVer = new System.Windows.Forms.ToolStripButton();
            this.stbStatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.mmBar.SuspendLayout();
            this.tbrShortcut.SuspendLayout();
            this.stbStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmBar
            // 
            this.mmBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.mmViewTab,
            this.helpToolStripMenuItem});
            this.mmBar.Location = new System.Drawing.Point(0, 0);
            this.mmBar.Name = "mmBar";
            this.mmBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mmBar.Size = new System.Drawing.Size(800, 24);
            this.mmBar.TabIndex = 0;
            this.mmBar.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorsToolStripMenuItem,
            this.currencyExchangeToolStripMenuItem,
            this.toolStripSeparator1,
            this.miQuit});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.filesToolStripMenuItem.Text = "Programs";
            // 
            // calculatorsToolStripMenuItem
            // 
            this.calculatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCalcStandard,
            this.miCalcScientific});
            this.calculatorsToolStripMenuItem.Name = "calculatorsToolStripMenuItem";
            this.calculatorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculatorsToolStripMenuItem.Text = "Calculators";
            // 
            // miCalcStandard
            // 
            this.miCalcStandard.Name = "miCalcStandard";
            this.miCalcStandard.Size = new System.Drawing.Size(163, 22);
            this.miCalcStandard.Text = "Standard Version";
            this.miCalcStandard.Click += new System.EventHandler(this.miCalcStandard_Click);
            // 
            // miCalcScientific
            // 
            this.miCalcScientific.Name = "miCalcScientific";
            this.miCalcScientific.Size = new System.Drawing.Size(163, 22);
            this.miCalcScientific.Text = "Scientific Version";
            this.miCalcScientific.Click += new System.EventHandler(this.miCalcScientific_Click);
            // 
            // currencyExchangeToolStripMenuItem
            // 
            this.currencyExchangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCurExchangeLocVer,
            this.miCurExchangeOnlVer});
            this.currencyExchangeToolStripMenuItem.Name = "currencyExchangeToolStripMenuItem";
            this.currencyExchangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currencyExchangeToolStripMenuItem.Text = "Currency Exchange";
            // 
            // miCurExchangeLocVer
            // 
            this.miCurExchangeLocVer.Name = "miCurExchangeLocVer";
            this.miCurExchangeLocVer.Size = new System.Drawing.Size(180, 22);
            this.miCurExchangeLocVer.Text = "Local Version";
            this.miCurExchangeLocVer.Click += new System.EventHandler(this.miCurExchangeLocVer_Click);
            // 
            // miCurExchangeOnlVer
            // 
            this.miCurExchangeOnlVer.Name = "miCurExchangeOnlVer";
            this.miCurExchangeOnlVer.Size = new System.Drawing.Size(180, 22);
            this.miCurExchangeOnlVer.Text = "Online Version";
            this.miCurExchangeOnlVer.Click += new System.EventHandler(this.miCurExchangeOnlVer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // miQuit
            // 
            this.miQuit.Name = "miQuit";
            this.miQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.miQuit.Size = new System.Drawing.Size(180, 22);
            this.miQuit.Text = "Quit ";
            this.miQuit.Click += new System.EventHandler(this.miQuit_Click);
            // 
            // mmViewTab
            // 
            this.mmViewTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miToolbar,
            this.miStatusBar});
            this.mmViewTab.Name = "mmViewTab";
            this.mmViewTab.Size = new System.Drawing.Size(44, 20);
            this.mmViewTab.Text = "View";
            // 
            // miToolbar
            // 
            this.miToolbar.Name = "miToolbar";
            this.miToolbar.Size = new System.Drawing.Size(126, 22);
            this.miToolbar.Text = "Toolbar";
            this.miToolbar.Click += new System.EventHandler(this.miToolbar_Click);
            // 
            // miStatusBar
            // 
            this.miStatusBar.Name = "miStatusBar";
            this.miStatusBar.Size = new System.Drawing.Size(126, 22);
            this.miStatusBar.Text = "Status Bar";
            this.miStatusBar.Click += new System.EventHandler(this.miStatusBar_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUserManual,
            this.miAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // miUserManual
            // 
            this.miUserManual.Name = "miUserManual";
            this.miUserManual.Size = new System.Drawing.Size(140, 22);
            this.miUserManual.Text = "User Manual";
            this.miUserManual.Click += new System.EventHandler(this.miUserManual_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(140, 22);
            this.miAbout.Text = "About";
            this.miAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbrShortcut
            // 
            this.tbrShortcut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbCalcStandard,
            this.tbbCalcScientific,
            this.tbbCurExchangeLocVer,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.tbbCurExchangeOnlVer});
            this.tbrShortcut.Location = new System.Drawing.Point(0, 24);
            this.tbrShortcut.Name = "tbrShortcut";
            this.tbrShortcut.Size = new System.Drawing.Size(800, 25);
            this.tbrShortcut.TabIndex = 1;
            this.tbrShortcut.Text = "toolStrip1";
            // 
            // tbbCalcStandard
            // 
            this.tbbCalcStandard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbCalcStandard.Image = global::prjWinCsCalculatorsCurrencyExchanges2in1.Properties.Resources.calc_stand_icon;
            this.tbbCalcStandard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbCalcStandard.Name = "tbbCalcStandard";
            this.tbbCalcStandard.Size = new System.Drawing.Size(23, 22);
            this.tbbCalcStandard.Text = "Standard Calculator";
            this.tbbCalcStandard.Click += new System.EventHandler(this.tbbCalcStandard_Click);
            // 
            // tbbCalcScientific
            // 
            this.tbbCalcScientific.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbCalcScientific.Image = global::prjWinCsCalculatorsCurrencyExchanges2in1.Properties.Resources.scie_calc;
            this.tbbCalcScientific.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbCalcScientific.Name = "tbbCalcScientific";
            this.tbbCalcScientific.Size = new System.Drawing.Size(23, 22);
            this.tbbCalcScientific.Text = "Scientific Calculator";
            this.tbbCalcScientific.Click += new System.EventHandler(this.tbbCalcScientific_Click);
            // 
            // tbbCurExchangeLocVer
            // 
            this.tbbCurExchangeLocVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbCurExchangeLocVer.Image = global::prjWinCsCalculatorsCurrencyExchanges2in1.Properties.Resources.dollar_sign;
            this.tbbCurExchangeLocVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbCurExchangeLocVer.Name = "tbbCurExchangeLocVer";
            this.tbbCurExchangeLocVer.Size = new System.Drawing.Size(23, 22);
            this.tbbCurExchangeLocVer.Text = "Local Currency Exchange";
            this.tbbCurExchangeLocVer.Click += new System.EventHandler(this.tbbCurExchangeLocVer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbCurExchangeOnlVer
            // 
            this.tbbCurExchangeOnlVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbCurExchangeOnlVer.Image = global::prjWinCsCalculatorsCurrencyExchanges2in1.Properties.Resources.cur_exc;
            this.tbbCurExchangeOnlVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbCurExchangeOnlVer.Name = "tbbCurExchangeOnlVer";
            this.tbbCurExchangeOnlVer.Size = new System.Drawing.Size(23, 22);
            this.tbbCurExchangeOnlVer.Text = "Online Currency Exchange";
            this.tbbCurExchangeOnlVer.Click += new System.EventHandler(this.tbbCurExchangeOnlVer_Click);
            // 
            // stbStatusBar
            // 
            this.stbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar});
            this.stbStatusBar.Location = new System.Drawing.Point(0, 428);
            this.stbStatusBar.Name = "stbStatusBar";
            this.stbStatusBar.Size = new System.Drawing.Size(800, 22);
            this.stbStatusBar.TabIndex = 2;
            this.stbStatusBar.Text = "statusStrip1";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(39, 17);
            this.lblStatusBar.Text = "Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjWinCsCalculatorsCurrencyExchanges2in1.Properties.Resources.Backimg_2in1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stbStatusBar);
            this.Controls.Add(this.tbrShortcut);
            this.Controls.Add(this.mmBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mmBar;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "LaSalle College";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mmBar.ResumeLayout(false);
            this.mmBar.PerformLayout();
            this.tbrShortcut.ResumeLayout(false);
            this.tbrShortcut.PerformLayout();
            this.stbStatusBar.ResumeLayout(false);
            this.stbStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmBar;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCalcStandard;
        private System.Windows.Forms.ToolStripMenuItem miCalcScientific;
        private System.Windows.Forms.ToolStripMenuItem currencyExchangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCurExchangeLocVer;
        private System.Windows.Forms.ToolStripMenuItem miCurExchangeOnlVer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miQuit;
        private System.Windows.Forms.ToolStripMenuItem mmViewTab;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tbrShortcut;
        private System.Windows.Forms.StatusStrip stbStatusBar;
        private System.Windows.Forms.ToolStripMenuItem miStatusBar;
        private System.Windows.Forms.ToolStripMenuItem miUserManual;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miToolbar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBar;
        private System.Windows.Forms.ToolStripButton tbbCalcStandard;
        private System.Windows.Forms.ToolStripButton tbbCalcScientific;
        private System.Windows.Forms.ToolStripButton tbbCurExchangeLocVer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbbCurExchangeOnlVer;
    }
}