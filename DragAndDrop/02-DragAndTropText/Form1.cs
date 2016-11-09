using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_DragAndTropText
{
    public partial class Form1 : Form
    {

        bool dragstate;
        public Form1()
        {
            InitializeComponent();
            listBox1.AllowDrop = true;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            // при отпускании кнопки производим копирование данных в элемент списка
            listBox1.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
           
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            // при попадании на адресат формируем соответствующую иконку 
            // для курсора
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }
    }
}
