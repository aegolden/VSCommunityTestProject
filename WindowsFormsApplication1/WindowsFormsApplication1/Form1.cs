using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Farm : Form
    {
        private string _lastOxygenReading;

        public Farm()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void hiveOne_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Hive One Status: ";
            //connect to serial port 1.
            //display status dialog here.
        }

        private void hiveTwo_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Hive Two Status: ";
            //connect to serial port 2.
            //display status dialog here.
        }

        private void orchardButton_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Orchard Status: ";
            //integrate trail camera(s) to reply to status with imagery of the orchard.
            //integrate bluetooth connected temperature, precipitation, soil moisture and humiture device sensors.
            //connect wirelessy through bluetooth to activate tumbler motors on composters.
            //Reply with button click status "Tumblers Activated" and "Sensing Current Soil and Weather Conditions"
        }

        private void greenhouseButton_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Greenhouse Status (Oxygen): " + _lastOxygenReading;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Chicken Coop Status: ";
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //serial.write for gas sensor test. 
            SerialPort sp = (SerialPort)sender;
            _lastOxygenReading = sp.ReadLine();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checklist command box.
        }

        private void commandCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void commandCenter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0: // Fan
                    if (e.NewValue == CheckState.Checked)
                    {
                        byte[] command = { 0xFF };
                        serialPort1.Write(command, 0, 1);
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        byte[] command = { 0xF0 };
                        serialPort1.Write(command, 0, 1);
                    }
                    break;

                case 4: //Lights
                    if (e.NewValue == CheckState.Checked)
                    {
                        byte[] command = { 0xEF };
                        serialPort1.Write(command, 0, 1);
                    }

                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        byte[] command = { 0xE0 };
                        serialPort1.Write(command, 0, 1);
                    }
                    break;
            }
        }
    }
}
