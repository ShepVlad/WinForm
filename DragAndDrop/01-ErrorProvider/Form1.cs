using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_ErrorProvider
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

        private void txtInn_Validated(object sender, EventArgs e)
        {
            if (txtInn.Text.Length!=12)
                errorProvider.SetError(txtInn, "Length INN  equals 12!");
            else
                errorProvider.SetError(txtInn, string.Empty);
        }

        private void numHeihgt_Validated(object sender, EventArgs e)
        {
            if (numHeihgt.Value < 145 || numHeihgt.Value > 220)
                errorProvider.SetError(numHeihgt, "Рост должен находится в пределах от и до");
            else
                errorProvider.SetError(numHeihgt, string.Empty);
        }
    }
}
