using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void hiveTwo_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Hive Two Status: ";
        }

        private void orchardButton_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Orchard Status: ";
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
    }
}
