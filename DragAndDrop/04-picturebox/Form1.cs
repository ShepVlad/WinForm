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
//using WinLoaf.WorkClass;

namespace _04_picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox.AllowDrop = true;
            pictureBox.DragDrop += PictureBox_DragDrop;
            pictureBox.DragEnter += PictureBox_DragEnter;
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (a != null)
                {
                    string s = a.GetValue(0).ToString();
                    this.Activate();

                    if (".bmp" == Path.GetExtension(s) ||
                        ".jpg" == Path.GetExtension(s) ||
                        ".png" == Path.GetExtension(s))
                    {
                        Image img = default(Image);
                        img = Image.FromFile(((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
                        Clipboard.SetImage(img);
                        pictureBox.Image = img;
                        //ResizeImage d=new ResizeImage();
                        //ResizeImage.FixedSize(img, img.Height, true);




                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in DragDrop function: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
