using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool state = led1.State;
            led1.State = !state;
        }

        private int color = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            led1.LedColor = (LedColor)(color++ % 5);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            barGraphH1.Value = (float)trackBar1.Value / 10;
        }
    }
}
