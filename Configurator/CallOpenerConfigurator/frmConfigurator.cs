using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace CallOpenerConfigurator
{
    public partial class frmConfigurator : Form
    {
        public frmConfigurator()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTimeHelper.getDateTime();
        }

        private void frmConfigurator_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTimeHelper.getDateTime();
            cmbCommPort.Items.Clear();
            for (int i = 1; i <= 20; i++)
                cmbCommPort.Items.Add($"COM{i}");
            cmbCommPort.SelectedIndex = 0;
            setLockFrame(false);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = Communication.SetStart(cmbCommPort.Text);
            setLockFrame(status);
            if (!status) MessageBox.Show($"Error with serial port: {cmbCommPort.Text}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Communication.SetStop();
            setLockFrame(false);
        }

        private void emailThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mail.sendEmail(txtEmail.Text, $"Phone number list - Site name: {txtSiteName.Text}", txtNumbers.Text);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmAbout nForm = new frmAbout();
            nForm.TopLevel = true;
            nForm.Show();
        }

        private void setLockFrame(bool state = false)
        {
            txtMaster1.Enabled = state;
            txtMaster2.Enabled = state;
            txtNumbers.Enabled = state;
            txtRelayDelay.Enabled = state;
            txtSiteName.Enabled = state;
            txtNumbers.Enabled = state;
            cmdReload.Enabled = state;
            cmdWrite.Enabled = state;
            deviceInfoToolStripMenuItem.Enabled = state;
            disconnectToolStripMenuItem.Enabled = state;
            connectToolStripMenuItem.Enabled = !state;
            cmbCommPort.Enabled = !state;
            if (state)
            {
                toolStripStatusLabel2.Text = "GCO RS232 - Connected";
                toolStripStatusLabel2.BackColor = Color.Green;
            }
            else
            {
                toolStripStatusLabel2.Text = "GCO RS232 - Disconnected";
                toolStripStatusLabel2.BackColor = Color.RebeccaPurple;
            }
        }

        private void deviceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"About Device: /r" +
            $"Device Name: {Communication.infoDeviceName} /r" +
            $"Device Ver: {Communication.infoDeviceVer} /r" +
            $"Firmware Ver: {Communication.infoFirmwareVer} /r" +
            $"Manufacter Date: {Communication.infoManufacterDate} /r" +
            $"SN: {Communication.InfoSN}");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void frmConfigurator_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Communication.SetStop();
            }
            catch { }
        }

        private void ExportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmdReload_Click(object sender, EventArgs e)
        {
            Communication.readAll();
            txtNumbers.Text = Communication.numbers;
            txtSiteName.Text = Communication.siteName;
            txtMaster1.Text = Communication.master1;
            txtMaster2.Text = Communication.master2;
            txtRelayDelay.Text = Communication.relayDelay;
        }

        private void cmdWrite_Click(object sender, EventArgs e)
        {
            Communication.numbers = txtNumbers.Text;
            Communication.siteName = txtSiteName.Text;
            Communication.master1 = txtMaster1.Text;
            Communication.master2 = txtMaster2.Text;
            Communication.relayDelay = txtRelayDelay.Text;
            Communication.writeAll();
        }
    }
}
