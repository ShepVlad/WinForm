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
    public partial class MyWindow : Form
    {
        public MyWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Просто текст");
            MessageBox.Show("Текст с заголовком", "Заголовок");
            MessageBox.Show("Текст с заголовком и кнопочками", "Заголовок",
                MessageBoxButtons.AbortRetryIgnore);
            MessageBox.Show("Текст с заголовком с иконкой Information", "Заголовок",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Текст с заголовком с иконкой Question", "Заголовок",
           MessageBoxButtons.OK, MessageBoxIcon.Question);
            MessageBox.Show("Текст с заголовком с иконкой Asterisk", "Заголовок",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Текст с заголовком с иконкой Error", "Заголовок",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
           


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("2 * 2 = 5; (правильное ли тождество)", "Алгебра 1 класс",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res==DialogResult.Yes)
            {
                MessageBox.Show("Но но но, сыш, ты че", "Даун",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Го в Мак бро", "Молодец",
                  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
