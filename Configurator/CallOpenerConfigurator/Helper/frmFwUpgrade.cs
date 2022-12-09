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

namespace CallOpenerConfigurator.Helper
{
    public partial class frmFwUpgrade : Form
    {
        public frmFwUpgrade()
        {
            InitializeComponent();
        }
        string installDir = "C:\\gco";
        private void frmFwUpgrade_Load(object sender, EventArgs e)
        {
            textBox_Trace.Text = "ALERT: THIS UPGRADE WILL DELETE ALL DATA IN DEVICE!";
        }
        private void cmdUpgrade_Click(object sender, EventArgs e)
        {
            startUpgrade("COM2");
        }
        public bool startUpgrade(string serialPort, string installDir = "C:\\gco")
        {
            textBox_Trace.Text = "";
            // These files must be part of the installation.
            // They come from the Arduino installation directory arduino/hardware/tools/avr/bin
            if (!File.Exists(installDir + "\\avr\\avrdude.exe"))
            {
                textBox_Trace.Text += "avrdude tool not installed";

            }
            if (!File.Exists(installDir + "\\avr\\avrdude.conf"))
            {
                textBox_Trace.Text += "avrdude config file not installed";

            }
            if (!File.Exists(installDir + "\\avr\\cygwin1.dll"))
            {
                textBox_Trace.Text += "avrdude cygwin dll not installed";

            }
            if (!File.Exists(installDir + "\\avr\\libusb0.dll"))
            {
                textBox_Trace.Text += "avrdude usb dll not installed";

            }

            // THis file is the new image to be uploaded to the Arduino board...
            if (!File.Exists(installDir + "\\avr\\AVRImage.hex"))
            {
                textBox_Trace.Text += "AVR image not installed";
            }

            textBox_Trace.Text += "(DO NOT RESET OR TURN OFF TILL THIS COMPLETES)\r\n";
            MessageBox.Show("Click OK to Start", "AVR Update");
            string avrport = serialPort;
            string dir = installDir;
            dir.Replace("\\", "/");
            Process avrprog = new Process();
            StreamReader avrstdout, avrstderr;
            StreamWriter avrstdin;
            ProcessStartInfo psI = new ProcessStartInfo("cmd");


            psI.UseShellExecute = false;
            psI.RedirectStandardInput = true;
            psI.RedirectStandardOutput = true;
            psI.RedirectStandardError = true;
            psI.CreateNoWindow = true;
            avrprog.StartInfo = psI;
            avrprog.Start();
            avrstdin = avrprog.StandardInput;
            avrstdout = avrprog.StandardOutput;
            avrstderr = avrprog.StandardError;
            avrstdin.AutoFlush = true;
            //avrstdin.WriteLine(installDir + "\\avr\\avrdude.exe -Cavr/avrdude.conf -patmega328p -cstk500v1 -P" + avrport + " -b57600 -D -Uflash:w:" + dir + "/avr/AVRImage.hex:i");
            avrstdin.WriteLine("avr\\avrdude.exe -Cavr/avrdude.conf -patmega328p -cstk500v1 -P" + avrport + " -b57600 -D -Uflash:w:avr/AVRImage.hex:i");
            avrstdin.Close();
            textBox_Trace.Text = avrstdout.ReadToEnd();
            textBox_Trace.Text += avrstderr.ReadToEnd();
            return true;
        }
    }
}
