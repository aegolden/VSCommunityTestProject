﻿using System;
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
        public Farm()
        {
            InitializeComponent();
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
            mainLabel.Text = "Greenhouse Status: ";
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
            string indata = sp.ReadExisting();
            Console.Write(indata);
        }
    }
}
