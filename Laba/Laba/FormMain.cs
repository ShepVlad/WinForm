using HRLibrary.DataLayer;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Laba
{
    public partial class FormMain : Form
    {
        Context context = new Context();
        BindingSource bsEmployee;
       

        public FormMain()
        {
            InitializeComponent();
            bsEmployee = new BindingSource();
            tbPictNum.Enabled = false;
            pictureBox.AllowDrop = true;
            pictureBox.DragDrop += PictureBox_DragDrop;
            pictureBox.DragEnter += PictureBox_DragEnter;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            context.Photos.Load();
            context.Employees.Load();
            bsEmployee.DataSource = context.Employees.Local;
            _lbHRE.DisplayMember = "ToString";
            _lbHRE.ValueMember = "EmployeeId";
            _lbHRE.DataSource = bsEmployee;
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

                        pictureBox.Image = ResizeImage.FixedSize(img, 121, 130, true);
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

       
        private void _lbHRE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = bsEmployee.Current as Employee;

            tbName.Text = emp.FirstName;
            tbFname.Text = emp.LastName;
            tbiNN.Text = emp.INN;
            dtdateB.Value = emp.DateBirthday;

            var qry = context.Photos.Local.
                Where(g => g.EmployeeId == (bsEmployee.Current as Employee).EmployeeId).ToList();
            if(qry.Count==0)
            {

            }
            foreach (var item in qry)
            {
                Image img = Image.FromFile(item.PathPhoto);
                PictureBox p = new PictureBox();
                p.Width = 121;
                p.Height = 130;
                p.Image = ResizeImage.FixedSize(img, p.Width, p.Height, true);
                pictureBox.Image = img;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = bsEmployee.Current as Employee;
            foreach (Employee item in context.Employees.Local)
            {
                if(emp.EmployeeId==item.EmployeeId)
                {
                    item.FirstName = tbName.Text;
                   item.LastName = tbFname.Text;
                    item.INN = tbiNN.Text;
                   item.DateBirthday = dtdateB.Value;
                    break;
                }
            }
            context.SaveChanges();
            bsEmployee.ResetBindings(true);
        }
    }
}
