using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Monitor
{
    public partial class Form1 : Form
    {
        PerformanceCounter pCPU = new PerformanceCounter("Processor", "% Processor time", "_Total");
        PerformanceCounter pRam = new PerformanceCounter("Memory", "% Committed Bytes in Use");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text ="CPU:" + "     " + (int)pCPU.NextValue() + "    " + "%";


            label2.Text = "RAM:" + "     " + (int)pRam.NextValue() + "    " + "%";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
