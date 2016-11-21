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
        FormBack form;
        public ShopADO()
        {
            InitializeComponent();
            context = new ShopContext();
            bsGoods = new BindingSource();
            bsManufacturers = new BindingSource();
            bsCategories = new BindingSource();
            form = new FormBack();

        }

        private void ShopADO_Load(object sender, EventArgs e)
        {
            context.Goods.Load();
            bsGoods.DataSource = context.Goods.Local;
            lbGood.DisplayMember = "GoodName";
            lbGood.ValueMember = "GoodId";
            lbGood.DataSource = bsGoods;

            context.Manufacturers.Load();

            lbManufacturer.DisplayMember = "ToString";
            lbManufacturer.ValueMember = "ManufacturerId";
            bsManufacturers.DataSource = context.Manufacturers.Local;
            
            lbManufacturer.DataSource = bsManufacturers;

            context.Categories.Load();
            bsCategories.DataSource = context.Categories.Local;
            lbCategory.DisplayMember = "CategoryName";
            lbCategory.ValueMember = "CategoryId";
            lbCategory.DataSource = bsCategories;

            
        }

        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindTrueGoods();
        }
        private void lbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
           FindTrueGoods();
        }
        private void FindTrueGoods()
        {

            var Cid = (bsCategories.Current as Category).CategoryId;
            var Mid = (bsManufacturers.Current as Manufacturer).ManufacturerId;
            var qry = context.Goods.Local.
                Where(g => g.CategoryId == Cid
                && g.ManufacturerId == Mid).ToList();
            lbCrusa.DisplayMember = "GoodName";
            lbCrusa.ValueMember = "GoodId";
            lbCrusa.DataSource = qry;
        }

        private void btnAdminka_Click(object sender, EventArgs e)
        {
           
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            form.Show();
        }
    }
}
