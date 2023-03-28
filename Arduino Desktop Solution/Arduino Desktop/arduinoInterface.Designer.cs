namespace Arduino_Desktop
{
    partial class arduinoInterface
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
            this.testBtn = new System.Windows.Forms.Button();
            this.stopTestBtn = new System.Windows.Forms.Button();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.axialLoadCellLabel = new System.Windows.Forms.Label();
            this.latLoadCellLabel = new System.Windows.Forms.Label();
            this.dialIndicatorLabel = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblHandShake = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblPortData = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelHandshake = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activePort = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxDialIndicator = new System.Windows.Forms.TextBox();
            this.groupBoxData.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(13, 418);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(125, 35);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "Run Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // stopTestBtn
            // 
            this.stopTestBtn.Location = new System.Drawing.Point(274, 418);
            this.stopTestBtn.Name = "stopTestBtn";
            this.stopTestBtn.Size = new System.Drawing.Size(125, 35);
            this.stopTestBtn.TabIndex = 1;
            this.stopTestBtn.Text = "Stop Test";
            this.stopTestBtn.UseVisualStyleBackColor = true;
            this.stopTestBtn.Click += new System.EventHandler(this.stopTestBtn_Click);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.textBox2);
            this.groupBoxData.Controls.Add(this.textBox1);
            this.groupBoxData.Controls.Add(this.axialLoadCellLabel);
            this.groupBoxData.Controls.Add(this.latLoadCellLabel);
            this.groupBoxData.Controls.Add(this.dialIndicatorLabel);
            this.groupBoxData.Controls.Add(this.textBoxDialIndicator);
            this.groupBoxData.Location = new System.Drawing.Point(13, 247);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(385, 147);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Live Device Data";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 22);
            this.textBox2.TabIndex = 5;
            // 
            // axialLoadCellLabel
            // 
            this.axialLoadCellLabel.AutoSize = true;
            this.axialLoadCellLabel.Location = new System.Drawing.Point(10, 114);
            this.axialLoadCellLabel.Name = "axialLoadCellLabel";
            this.axialLoadCellLabel.Size = new System.Drawing.Size(134, 17);
            this.axialLoadCellLabel.TabIndex = 3;
            this.axialLoadCellLabel.Text = "Axial Load Cell Data";
            // 
            // latLoadCellLabel
            // 
            this.latLoadCellLabel.AutoSize = true;
            this.latLoadCellLabel.Location = new System.Drawing.Point(10, 78);
            this.latLoadCellLabel.Name = "latLoadCellLabel";
            this.latLoadCellLabel.Size = new System.Drawing.Size(149, 17);
            this.latLoadCellLabel.TabIndex = 2;
            this.latLoadCellLabel.Text = "Lateral Load Cell Data";
            // 
            // dialIndicatorLabel
            // 
            this.dialIndicatorLabel.AutoSize = true;
            this.dialIndicatorLabel.Location = new System.Drawing.Point(10, 42);
            this.dialIndicatorLabel.Name = "dialIndicatorLabel";
            this.dialIndicatorLabel.Size = new System.Drawing.Size(124, 17);
            this.dialIndicatorLabel.TabIndex = 1;
            this.dialIndicatorLabel.Text = "Dial Indicator Data";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.lblState);
            this.groupBoxSettings.Controls.Add(this.lblStopBits);
            this.groupBoxSettings.Controls.Add(this.lblDataBits);
            this.groupBoxSettings.Controls.Add(this.lblHandShake);
            this.groupBoxSettings.Controls.Add(this.lblParity);
            this.groupBoxSettings.Controls.Add(this.lblBaudRate);
            this.groupBoxSettings.Controls.Add(this.lblPortData);
            this.groupBoxSettings.Controls.Add(this.labelState);
            this.groupBoxSettings.Controls.Add(this.labelHandshake);
            this.groupBoxSettings.Controls.Add(this.labelParity);
            this.groupBoxSettings.Controls.Add(this.labelStopBits);
            this.groupBoxSettings.Controls.Add(this.labelDataBits);
            this.groupBoxSettings.Controls.Add(this.labelBaud);
            this.groupBoxSettings.Controls.Add(this.labelPort);
            this.groupBoxSettings.Location = new System.Drawing.Point(13, 31);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(386, 188);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "COM Port Settings";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(303, 141);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 17);
            this.lblState.TabIndex = 13;
            this.lblState.Text = "label7";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(303, 76);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(46, 17);
            this.lblStopBits.TabIndex = 12;
            this.lblStopBits.Text = "label6";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(303, 36);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(46, 17);
            this.lblDataBits.TabIndex = 11;
            this.lblDataBits.Text = "label5";
            // 
            // lblHandShake
            // 
            this.lblHandShake.AutoSize = true;
            this.lblHandShake.Location = new System.Drawing.Point(112, 141);
            this.lblHandShake.Name = "lblHandShake";
            this.lblHandShake.Size = new System.Drawing.Size(46, 17);
            this.lblHandShake.TabIndex = 10;
            this.lblHandShake.Text = "label4";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(113, 103);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(46, 17);
            this.lblParity.TabIndex = 9;
            this.lblParity.Text = "label3";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(113, 67);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(46, 17);
            this.lblBaudRate.TabIndex = 8;
            this.lblBaudRate.Text = "label2";
            // 
            // lblPortData
            // 
            this.lblPortData.AutoSize = true;
            this.lblPortData.Location = new System.Drawing.Point(113, 36);
            this.lblPortData.Name = "lblPortData";
            this.lblPortData.Size = new System.Drawing.Size(46, 17);
            this.lblPortData.TabIndex = 7;
            this.lblPortData.Text = "label1";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(243, 141);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(45, 17);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State:";
            // 
            // labelHandshake
            // 
            this.labelHandshake.AutoSize = true;
            this.labelHandshake.Location = new System.Drawing.Point(10, 141);
            this.labelHandshake.Name = "labelHandshake";
            this.labelHandshake.Size = new System.Drawing.Size(95, 17);
            this.labelHandshake.TabIndex = 5;
            this.labelHandshake.Text = "Handshaking:";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(57, 103);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(48, 17);
            this.labelParity.TabIndex = 4;
            this.labelParity.Text = "Parity:";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(220, 76);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(68, 17);
            this.labelStopBits.TabIndex = 3;
            this.labelStopBits.Text = "Stop Bits:";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(219, 36);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(69, 17);
            this.labelDataBits.TabIndex = 2;
            this.labelDataBits.Text = "Data Bits:";
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(26, 67);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(79, 17);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "Baud Rate:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(52, 36);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(38, 17);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Port:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comPortSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // comPortSettingsToolStripMenuItem
            // 
            this.comPortSettingsToolStripMenuItem.Name = "comPortSettingsToolStripMenuItem";
            this.comPortSettingsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.comPortSettingsToolStripMenuItem.Text = "COM Port Settings";
            this.comPortSettingsToolStripMenuItem.Click += new System.EventHandler(this.comPortSettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // activePort
            // 
            this.activePort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.activePort_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBoxDialIndicator
            // 
            this.textBoxDialIndicator.Location = new System.Drawing.Point(207, 37);
            this.textBoxDialIndicator.Name = "textBoxDialIndicator";
            this.textBoxDialIndicator.Size = new System.Drawing.Size(149, 22);
            this.textBoxDialIndicator.TabIndex = 0;
            // 
            // arduinoInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 465);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.stopTestBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "arduinoInterface";
            this.Text = "Arduino Desktop";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button stopTestBtn;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label axialLoadCellLabel;
        private System.Windows.Forms.Label latLoadCellLabel;
        private System.Windows.Forms.Label dialIndicatorLabel;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comPortSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.IO.Ports.SerialPort activePort;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelHandshake;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblHandShake;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblPortData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxDialIndicator;
    }
}

