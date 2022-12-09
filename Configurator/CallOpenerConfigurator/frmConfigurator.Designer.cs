namespace CallOpenerConfigurator
{
    partial class frmConfigurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurator));
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaster2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRelayDelay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaster1 = new System.Windows.Forms.TextBox();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.cmdWrite = new System.Windows.Forms.Button();
            this.cmdReload = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.emailThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEmail = new System.Windows.Forms.ToolStripTextBox();
            this.communicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCommPort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deviceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Master Number #2:";
            // 
            // txtMaster2
            // 
            this.txtMaster2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaster2.Enabled = false;
            this.txtMaster2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMaster2.Location = new System.Drawing.Point(159, 340);
            this.txtMaster2.Name = "txtMaster2";
            this.txtMaster2.Size = new System.Drawing.Size(257, 27);
            this.txtMaster2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Relay Delay [sec]:";
            // 
            // txtRelayDelay
            // 
            this.txtRelayDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRelayDelay.Enabled = false;
            this.txtRelayDelay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRelayDelay.Location = new System.Drawing.Point(159, 372);
            this.txtRelayDelay.MaxLength = 3;
            this.txtRelayDelay.Name = "txtRelayDelay";
            this.txtRelayDelay.Size = new System.Drawing.Size(40, 27);
            this.txtRelayDelay.TabIndex = 20;
            this.txtRelayDelay.Text = "120";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Master Number #1:";
            // 
            // txtMaster1
            // 
            this.txtMaster1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaster1.Enabled = false;
            this.txtMaster1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMaster1.Location = new System.Drawing.Point(159, 307);
            this.txtMaster1.Name = "txtMaster1";
            this.txtMaster1.Size = new System.Drawing.Size(257, 27);
            this.txtMaster1.TabIndex = 18;
            this.txtMaster1.Text = "+381658180071";
            // 
            // txtNumbers
            // 
            this.txtNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumbers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumbers.Location = new System.Drawing.Point(11, 42);
            this.txtNumbers.Multiline = true;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(405, 225);
            this.txtNumbers.TabIndex = 15;
            this.txtNumbers.Text = "+381658180071;\r\n+381658180071;\r\n+381658180071;\r\n+381658180071;\r\n+381658180071;";
            // 
            // cmdWrite
            // 
            this.cmdWrite.Enabled = false;
            this.cmdWrite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdWrite.Image = global::CallOpenerConfigurator.Properties.Resources.save_48;
            this.cmdWrite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdWrite.Location = new System.Drawing.Point(216, 405);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.Size = new System.Drawing.Size(200, 60);
            this.cmdWrite.TabIndex = 14;
            this.cmdWrite.TabStop = false;
            this.cmdWrite.Text = "Write 2 GCO";
            this.cmdWrite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdWrite.UseVisualStyleBackColor = true;
            // 
            // cmdReload
            // 
            this.cmdReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdReload.Enabled = false;
            this.cmdReload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdReload.Image = global::CallOpenerConfigurator.Properties.Resources.sinchronize_48;
            this.cmdReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdReload.Location = new System.Drawing.Point(11, 405);
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(200, 60);
            this.cmdReload.TabIndex = 13;
            this.cmdReload.Text = "Reload Data";
            this.cmdReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdReload.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(428, 26);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 20);
            this.toolStripStatusLabel1.Text = "01:09:00 - 08.12.22.";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(171, 20);
            this.toolStripStatusLabel2.Text = "GCO RS232 - Disconnect";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.communicationToolStripMenuItem1,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsCSVToolStripMenuItem,
            this.importCSVToolStripMenuItem,
            this.toolStripSeparator3,
            this.emailThisToolStripMenuItem,
            this.txtEmail});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveAsCSVToolStripMenuItem
            // 
            this.saveAsCSVToolStripMenuItem.Image = global::CallOpenerConfigurator.Properties.Resources.upload_2;
            this.saveAsCSVToolStripMenuItem.Name = "saveAsCSVToolStripMenuItem";
            this.saveAsCSVToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.saveAsCSVToolStripMenuItem.Text = "Export .CSV";
            this.saveAsCSVToolStripMenuItem.Click += new System.EventHandler(this.ExportCSVToolStripMenuItem_Click);
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.Image = global::CallOpenerConfigurator.Properties.Resources.download;
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.importCSVToolStripMenuItem.Text = "Import .CSV";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(271, 6);
            // 
            // emailThisToolStripMenuItem
            // 
            this.emailThisToolStripMenuItem.Image = global::CallOpenerConfigurator.Properties.Resources.email;
            this.emailThisToolStripMenuItem.Name = "emailThisToolStripMenuItem";
            this.emailThisToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.emailThisToolStripMenuItem.Text = "E-mail this";
            this.emailThisToolStripMenuItem.Click += new System.EventHandler(this.emailThisToolStripMenuItem_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 27);
            this.txtEmail.Text = "test@tecomatic.net";
            this.txtEmail.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // communicationToolStripMenuItem1
            // 
            this.communicationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbCommPort,
            this.toolStripSeparator1,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator2,
            this.deviceInfoToolStripMenuItem});
            this.communicationToolStripMenuItem1.Name = "communicationToolStripMenuItem1";
            this.communicationToolStripMenuItem1.Size = new System.Drawing.Size(128, 24);
            this.communicationToolStripMenuItem1.Text = "&Communication";
            // 
            // cmbCommPort
            // 
            this.cmbCommPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommPort.Name = "cmbCommPort";
            this.cmbCommPort.Size = new System.Drawing.Size(121, 28);
            this.cmbCommPort.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Image = global::CallOpenerConfigurator.Properties.Resources.usb_connected_512;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Image = global::CallOpenerConfigurator.Properties.Resources.usb_disconnected_512;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // deviceInfoToolStripMenuItem
            // 
            this.deviceInfoToolStripMenuItem.Enabled = false;
            this.deviceInfoToolStripMenuItem.Image = global::CallOpenerConfigurator.Properties.Resources.chip_2_512;
            this.deviceInfoToolStripMenuItem.Name = "deviceInfoToolStripMenuItem";
            this.deviceInfoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deviceInfoToolStripMenuItem.Text = "&Device Info";
            this.deviceInfoToolStripMenuItem.Click += new System.EventHandler(this.deviceInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItem4.Text = "&About";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(72, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Site Name:";
            // 
            // txtSiteName
            // 
            this.txtSiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiteName.Enabled = false;
            this.txtSiteName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSiteName.Location = new System.Drawing.Point(159, 274);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(257, 27);
            this.txtSiteName.TabIndex = 30;
            this.txtSiteName.Text = "Novi Sad - B Ribnikar";
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaster2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRelayDelay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaster1);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.cmdWrite);
            this.Controls.Add(this.cmdReload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmConfigurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCO - Configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfigurator_FormClosing);
            this.Load += new System.EventHandler(this.frmConfigurator_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox txtMaster2;
        private Label label2;
        private TextBox txtRelayDelay;
        private Label label1;
        private TextBox txtMaster1;
        private TextBox txtNumbers;
        private Button cmdWrite;
        private Button cmdReload;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem communicationToolStripMenuItem1;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private ToolStripComboBox cmbCommPort;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsCSVToolStripMenuItem;
        private ToolStripMenuItem importCSVToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem deviceInfoToolStripMenuItem;
        private Label label5;
        private TextBox txtSiteName;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem emailThisToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer tmr;
        private ToolStripTextBox txtEmail;
    }
}