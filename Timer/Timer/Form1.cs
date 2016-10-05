using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DisplayTime();
        }
        private void DisplayTime()
        {
            label1.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
