using ShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopEkzam
{
    public partial class ShopADO : Form
    {
        ShopContext context;
        BindingSource bsGoods;
        BindingSource bsManufacturers;
        BindingSource bsCategories;
        bool check=true;
        public ShopADO()
        {
            InitializeComponent();
            context = new ShopContext();
            bsGoods = new BindingSource();
            bsManufacturers = new BindingSource();
            bsCategories = new BindingSource();
           

        }
        private void clbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShopADO_Load(object sender, EventArgs e)
        {
            btnReset.Visible = false;
            btnSave.Visible = false;
            btnback.Visible = false;
            context.Goods.Load();
            bsGoods.DataSource = context.Goods.Local;
           

            context.Manufacturers.Load();
            bsManufacturers.DataSource = context.Manufacturers.Local;
            clbManufacturer.DisplayMember = "ToString";
            clbManufacturer.ValueMember = "ManufacturerId";
            clbManufacturer.DataSource = bsManufacturers;


            context.Categories.Load();
            bsCategories.DataSource = context.Categories.Local;
            lbCategory.DisplayMember = "CategoryName";
            lbCategory.ValueMember = "CategoryId";
            lbCategory.DataSource = bsCategories;

            
        }

        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(check==true)
            {
                lbCrusa.Items.Clear();
                bsManufacturers.ResetBindings(true);
            }
            else
            {
                Choice();
            }
          
        }
        private void btnAdminka_Click(object sender, EventArgs e)
        {
            gbComments.Visible = false;
            gbTresh.Visible = false;
            btnback.Visible = true;
            btnSave.Visible = true;
            btnAdminka.Visible = false;
            btnAdd.Visible = false;
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            gbComments.Visible = true;
            gbTresh.Visible = true;
            btnback.Visible =false;
            btnSave.Visible =false;
            btnAdminka.Visible = true;
            btnAdd.Visible = true;
        }
        private void clbManufacturer_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            if (e.NewValue == CheckState.Checked)
            {
                //  MessageBox.Show(string.Format("{0}", e.NewValue));

                Console.WriteLine();
                var Cid = (bsCategories.Current as Category).CategoryId;

                var qry3 = context.Goods.Local.Where(m => m.ManufacturerId == e.Index + 1 &&
                 m.CategoryId == Cid).ToList();
                lbCrusa.DisplayMember = "GoodName";
                lbCrusa.ValueMember = "GoodId";
                foreach (Good item in qry3)
                {
                    lbCrusa.Items.Add(item);
                }
            }
            else
            {
                var qry = context.Goods.Local.Where(m => m.ManufacturerId == e.Index + 1).ToList();
                foreach (Good item in qry)
                {
                    lbCrusa.Items.Remove(item);
                }
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            lbCrusa.Items.Clear();
            bsManufacturers.ResetBindings(true);
            btnCategory.Visible = false;
            btnReset.Visible = true;
            Choice();
        }

        private void Choice()
        {
            var Cid = (bsCategories.Current as Category).CategoryId;
            var qry2 = context.Goods.Local.Where(c => c.CategoryId == Cid).ToList();
            lbCrusa.DisplayMember = "GoodName";
            lbCrusa.ValueMember = "GoodId";
            lbCrusa.DataSource = qry2;
            check = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            check = false;
            var Cid = (bsCategories.Current as Category).CategoryId;
            var qry2 = context.Goods.Local.Where(c => c.CategoryId == Cid).ToList();
            lbCrusa.DisplayMember = "GoodName";
            lbCrusa.ValueMember = "GoodId";
            lbCrusa.DataSource = qry2;
            bsManufacturers.ResetBindings(true);
        }
    }
}
