namespace CallOpenerConfigurator.Helper
{
    partial class frmFwUpgrade
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
            this.textBox_Trace = new System.Windows.Forms.TextBox();
            this.cmdUpgrade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Trace
            // 
            this.textBox_Trace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Trace.Location = new System.Drawing.Point(10, 12);
            this.textBox_Trace.Multiline = true;
            this.textBox_Trace.Name = "textBox_Trace";
            this.textBox_Trace.Size = new System.Drawing.Size(486, 271);
            this.textBox_Trace.TabIndex = 0;
            // 
            // cmdUpgrade
            // 
            this.cmdUpgrade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdUpgrade.Location = new System.Drawing.Point(318, 289);
            this.cmdUpgrade.Name = "cmdUpgrade";
            this.cmdUpgrade.Size = new System.Drawing.Size(178, 35);
            this.cmdUpgrade.TabIndex = 1;
            this.cmdUpgrade.Text = "Upgrade";
            this.cmdUpgrade.UseVisualStyleBackColor = true;
            this.cmdUpgrade.Click += new System.EventHandler(this.cmdUpgrade_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(10, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load FW from file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmFwUpgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdUpgrade);
            this.Controls.Add(this.textBox_Trace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFwUpgrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmware update";
            this.Load += new System.EventHandler(this.frmFwUpgrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Trace;
        private Button cmdUpgrade;
        private Button button1;
    }
}