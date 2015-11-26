namespace IdlePowerSwitcher
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cbLowOption = new System.Windows.Forms.ComboBox();
            this.cbHighOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedIdleTime = new System.Windows.Forms.Label();
            this.sliderIdle = new System.Windows.Forms.TrackBar();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblLastInput = new System.Windows.Forms.Label();
            this.timerIdleTime = new System.Windows.Forms.Timer(this.components);
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeScrollLock = new System.Windows.Forms.Timer(this.components);
            this.chkMinimize = new System.Windows.Forms.CheckBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxCurrent = new System.Windows.Forms.GroupBox();
            this.groupBoxIdleTime = new System.Windows.Forms.GroupBox();
            this.llblChangePower = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToSystemTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sliderIdle)).BeginInit();
            this.cmsNotifyIcon.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxCurrent.SuspendLayout();
            this.groupBoxIdleTime.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLowOption
            // 
            this.cbLowOption.FormattingEnabled = true;
            this.cbLowOption.Location = new System.Drawing.Point(15, 182);
            this.cbLowOption.Name = "cbLowOption";
            this.cbLowOption.Size = new System.Drawing.Size(156, 24);
            this.cbLowOption.TabIndex = 0;
            this.cbLowOption.SelectedIndexChanged += new System.EventHandler(this.cbHighandLowOption_SelectedIndexChanged);
            // 
            // cbHighOption
            // 
            this.cbHighOption.FormattingEnabled = true;
            this.cbHighOption.Location = new System.Drawing.Point(192, 182);
            this.cbHighOption.Name = "cbHighOption";
            this.cbHighOption.Size = new System.Drawing.Size(156, 24);
            this.cbHighOption.TabIndex = 1;
            this.cbHighOption.SelectedIndexChanged += new System.EventHandler(this.cbHighandLowOption_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Low Power";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "High Power";
            // 
            // lblSelectedIdleTime
            // 
            this.lblSelectedIdleTime.AutoSize = true;
            this.lblSelectedIdleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedIdleTime.Location = new System.Drawing.Point(127, 22);
            this.lblSelectedIdleTime.Name = "lblSelectedIdleTime";
            this.lblSelectedIdleTime.Size = new System.Drawing.Size(87, 31);
            this.lblSelectedIdleTime.TabIndex = 4;
            this.lblSelectedIdleTime.Text = "00:00";
            // 
            // sliderIdle
            // 
            this.sliderIdle.Location = new System.Drawing.Point(6, 65);
            this.sliderIdle.Maximum = 600;
            this.sliderIdle.Name = "sliderIdle";
            this.sliderIdle.Size = new System.Drawing.Size(324, 45);
            this.sliderIdle.TabIndex = 5;
            this.sliderIdle.TickFrequency = 60;
            this.sliderIdle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderIdle.Scroll += new System.EventHandler(this.sliderIdle_Scroll);
            // 
            // lblTest
            // 
            this.lblTest.AutoEllipsis = true;
            this.lblTest.Location = new System.Drawing.Point(6, 22);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(148, 16);
            this.lblTest.TabIndex = 10;
            this.lblTest.Text = "Display Current Power";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(270, 309);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(78, 24);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblLastInput
            // 
            this.lblLastInput.AutoSize = true;
            this.lblLastInput.Location = new System.Drawing.Point(69, 48);
            this.lblLastInput.Name = "lblLastInput";
            this.lblLastInput.Size = new System.Drawing.Size(39, 16);
            this.lblLastInput.TabIndex = 12;
            this.lblLastInput.Text = "00:00";
            // 
            // timerIdleTime
            // 
            this.timerIdleTime.Enabled = true;
            this.timerIdleTime.Tick += new System.EventHandler(this.timerIdleTime_Tick);
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Checked = true;
            this.chkStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStartup.Location = new System.Drawing.Point(6, 21);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(114, 20);
            this.chkStartup.TabIndex = 13;
            this.chkStartup.Text = "Run on Startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Application is still running in system tray.";
            this.notifyIcon.BalloonTipTitle = "Still here!";
            this.notifyIcon.ContextMenuStrip = this.cmsNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Idle Power Switcher";
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cmsNotifyIcon
            // 
            this.cmsNotifyIcon.BackColor = System.Drawing.SystemColors.Control;
            this.cmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.cmsNotifyIcon.Name = "cmsNotifyIcon";
            this.cmsNotifyIcon.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // timeScrollLock
            // 
            this.timeScrollLock.Enabled = true;
            this.timeScrollLock.Tick += new System.EventHandler(this.timeScrollLock_Tick);
            // 
            // chkMinimize
            // 
            this.chkMinimize.AutoSize = true;
            this.chkMinimize.Location = new System.Drawing.Point(6, 47);
            this.chkMinimize.Name = "chkMinimize";
            this.chkMinimize.Size = new System.Drawing.Size(127, 20);
            this.chkMinimize.TabIndex = 14;
            this.chkMinimize.Text = "Minimize on Start";
            this.chkMinimize.UseVisualStyleBackColor = true;
            this.chkMinimize.CheckedChanged += new System.EventHandler(this.chkMinimize_CheckedChanged);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.chkStartup);
            this.groupBoxSettings.Controls.Add(this.chkMinimize);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 226);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(159, 78);
            this.groupBoxSettings.TabIndex = 15;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Time Idle:";
            // 
            // groupBoxCurrent
            // 
            this.groupBoxCurrent.Controls.Add(this.lblLastInput);
            this.groupBoxCurrent.Controls.Add(this.lblTest);
            this.groupBoxCurrent.Controls.Add(this.label7);
            this.groupBoxCurrent.Location = new System.Drawing.Point(192, 226);
            this.groupBoxCurrent.Name = "groupBoxCurrent";
            this.groupBoxCurrent.Size = new System.Drawing.Size(156, 78);
            this.groupBoxCurrent.TabIndex = 17;
            this.groupBoxCurrent.TabStop = false;
            this.groupBoxCurrent.Text = "Current";
            // 
            // groupBoxIdleTime
            // 
            this.groupBoxIdleTime.Controls.Add(this.lblSelectedIdleTime);
            this.groupBoxIdleTime.Controls.Add(this.sliderIdle);
            this.groupBoxIdleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIdleTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxIdleTime.Location = new System.Drawing.Point(12, 27);
            this.groupBoxIdleTime.Name = "groupBoxIdleTime";
            this.groupBoxIdleTime.Size = new System.Drawing.Size(336, 130);
            this.groupBoxIdleTime.TabIndex = 18;
            this.groupBoxIdleTime.TabStop = false;
            this.groupBoxIdleTime.Text = "Idle Time";
            // 
            // llblChangePower
            // 
            this.llblChangePower.AutoSize = true;
            this.llblChangePower.Location = new System.Drawing.Point(9, 313);
            this.llblChangePower.Name = "llblChangePower";
            this.llblChangePower.Size = new System.Drawing.Size(147, 16);
            this.llblChangePower.TabIndex = 19;
            this.llblChangePower.TabStop = true;
            this.llblChangePower.Text = "Change Power Settings";
            this.llblChangePower.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblChangePower_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToSystemTrayToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // minimizeToSystemTrayToolStripMenuItem
            // 
            this.minimizeToSystemTrayToolStripMenuItem.Name = "minimizeToSystemTrayToolStripMenuItem";
            this.minimizeToSystemTrayToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.minimizeToSystemTrayToolStripMenuItem.Text = "Minimize to System Tray";
            this.minimizeToSystemTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToSystemTrayToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.closeToolStripMenuItem1.Text = "Exit";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 345);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.llblChangePower);
            this.Controls.Add(this.groupBoxIdleTime);
            this.Controls.Add(this.groupBoxCurrent);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHighOption);
            this.Controls.Add(this.cbLowOption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sliderIdle)).EndInit();
            this.cmsNotifyIcon.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxCurrent.ResumeLayout(false);
            this.groupBoxCurrent.PerformLayout();
            this.groupBoxIdleTime.ResumeLayout(false);
            this.groupBoxIdleTime.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLowOption;
        private System.Windows.Forms.ComboBox cbHighOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedIdleTime;
        private System.Windows.Forms.TrackBar sliderIdle;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblLastInput;
        private System.Windows.Forms.Timer timerIdleTime;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timeScrollLock;
        private System.Windows.Forms.CheckBox chkMinimize;
        private System.Windows.Forms.ContextMenuStrip cmsNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxCurrent;
        private System.Windows.Forms.GroupBox groupBoxIdleTime;
        private System.Windows.Forms.LinkLabel llblChangePower;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToSystemTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

