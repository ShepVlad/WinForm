using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_rtbDragDropFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox.AllowDrop = true;

            richTextBox.DragEnter += richTextBox_DragEnter;
            richTextBox.DragDrop += richTextBox_DragDrop;

        }

        void richTextBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (a != null)
                {
                    string s = a.GetValue(0).ToString();
                    this.Activate();

                    if(".bmp" == Path.GetExtension(s)||
                        ".jpg"==Path.GetExtension(s)||
                        ".png"==Path.GetExtension(s))
                    {
                        Image img = default(Image);
                        img = Image.FromFile(((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
                        Clipboard.SetImage(img);
                        this.richTextBox.Paste();
                    }
                    else 
                    OpenFile(s);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in DragDrop function: " + ex.Message);
            }
        }
        private void OpenFile(string sFile)
        {
            try
            {
                // StreamReader StreamReader1 = new StreamReader(sFile, System.Text.Encoding.UTF8);
                StreamReader StreamReader1 = new StreamReader(sFile, System.Text.Encoding.UTF8);
                richTextBox.Text = StreamReader1.ReadToEnd();
                StreamReader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error loading from file");
            }

        }
        void richTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SaveFile(@"C:\Users\student\Desktop\Новая папка (5)");
        }
    }
}
