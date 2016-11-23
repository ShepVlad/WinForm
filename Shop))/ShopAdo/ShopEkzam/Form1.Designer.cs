namespace ShopEkzam
{
    partial class ShopADO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.lbCrusa = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gr = new System.Windows.Forms.GroupBox();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdminka = new System.Windows.Forms.Button();
            this.gbTresh = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbToSale = new System.Windows.Forms.ListBox();
            this.gbComments = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clbManufacturer = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbTresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.gbComments.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.Location = new System.Drawing.Point(6, 19);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(215, 56);
            this.lbCategory.TabIndex = 4;
            this.lbCategory.SelectedIndexChanged += new System.EventHandler(this.lbCategory_SelectedIndexChanged);
            // 
            // lbCrusa
            // 
            this.lbCrusa.FormattingEnabled = true;
            this.lbCrusa.Location = new System.Drawing.Point(6, 19);
            this.lbCrusa.Name = "lbCrusa";
            this.lbCrusa.Size = new System.Drawing.Size(225, 238);
            this.lbCrusa.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCategory);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Категории";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clbManufacturer);
            this.groupBox3.Location = new System.Drawing.Point(18, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 130);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Производители";
            // 
            // gr
            // 
            this.gr.Controls.Add(this.btnReset);
            this.gr.Controls.Add(this.btnCategory);
            this.gr.Controls.Add(this.btnSave);
            this.gr.Controls.Add(this.picturebox);
            this.gr.Controls.Add(this.pictureBox1);
            this.gr.Controls.Add(this.btnAdd);
            this.gr.Controls.Add(this.lbCrusa);
            this.gr.Location = new System.Drawing.Point(254, 12);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(535, 316);
            this.gr.TabIndex = 8;
            this.gr.TabStop = false;
            this.gr.Text = "Выборка";
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(260, 30);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(251, 165);
            this.picturebox.TabIndex = 8;
            this.picturebox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Location = new System.Drawing.Point(248, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 188);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Location = new System.Drawing.Point(399, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить в корзину";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnAdminka
            // 
            this.btnAdminka.Location = new System.Drawing.Point(18, 246);
            this.btnAdminka.Name = "btnAdminka";
            this.btnAdminka.Size = new System.Drawing.Size(131, 23);
            this.btnAdminka.TabIndex = 9;
            this.btnAdminka.Text = "Админка";
            this.btnAdminka.UseVisualStyleBackColor = true;
            this.btnAdminka.Click += new System.EventHandler(this.btnAdminka_Click);
            // 
            // gbTresh
            // 
            this.gbTresh.Controls.Add(this.label2);
            this.gbTresh.Controls.Add(this.label1);
            this.gbTresh.Controls.Add(this.textBox1);
            this.gbTresh.Controls.Add(this.btnBuy);
            this.gbTresh.Controls.Add(this.pictureBox5);
            this.gbTresh.Controls.Add(this.pictureBox6);
            this.gbTresh.Controls.Add(this.btnRemove);
            this.gbTresh.Controls.Add(this.lbToSale);
            this.gbTresh.Location = new System.Drawing.Point(807, 12);
            this.gbTresh.Name = "gbTresh";
            this.gbTresh.Size = new System.Drawing.Size(625, 316);
            this.gbTresh.TabIndex = 9;
            this.gbTresh.TabStop = false;
            this.gbTresh.Text = "Корзина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "грн";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Цена";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(481, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Lime;
            this.btnBuy.Location = new System.Drawing.Point(248, 242);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(124, 23);
            this.btnBuy.TabIndex = 9;
            this.btnBuy.Text = "Купить";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(302, 28);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(251, 165);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Blue;
            this.pictureBox6.Location = new System.Drawing.Point(290, 17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(275, 188);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Gold;
            this.btnRemove.Location = new System.Drawing.Point(248, 213);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Удалить из корзины";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // lbToSale
            // 
            this.lbToSale.FormattingEnabled = true;
            this.lbToSale.Location = new System.Drawing.Point(6, 19);
            this.lbToSale.Name = "lbToSale";
            this.lbToSale.Size = new System.Drawing.Size(225, 251);
            this.lbToSale.TabIndex = 5;
            // 
            // gbComments
            // 
            this.gbComments.Controls.Add(this.label3);
            this.gbComments.Controls.Add(this.textBox2);
            this.gbComments.Controls.Add(this.label4);
            this.gbComments.Location = new System.Drawing.Point(254, 334);
            this.gbComments.Name = "gbComments";
            this.gbComments.Size = new System.Drawing.Size(1067, 154);
            this.gbComments.TabIndex = 13;
            this.gbComments.TabStop = false;
            this.gbComments.Text = "Отзывы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ItalicT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отзыв писать тут->";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(374, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(631, 72);
            this.textBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RomanC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(48, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(920, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Оставте ваш отзыв, ХОРОШИЙ, на плохой мы все равно не отреагируем и удалим) Спаси" +
    "бо что выбрали нас!";
            // 
            // clbManufacturer
            // 
            this.clbManufacturer.CheckOnClick = true;
            this.clbManufacturer.FormattingEnabled = true;
            this.clbManufacturer.Location = new System.Drawing.Point(6, 15);
            this.clbManufacturer.Name = "clbManufacturer";
            this.clbManufacturer.Size = new System.Drawing.Size(215, 109);
            this.clbManufacturer.TabIndex = 14;
            this.clbManufacturer.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbManufacturer_ItemCheck);
            this.clbManufacturer.SelectedIndexChanged += new System.EventHandler(this.clbManufacturer_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(167, 246);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Назад";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(6, 263);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(144, 23);
            this.btnCategory.TabIndex = 11;
            this.btnCategory.Text = "Все товары в категории";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(156, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Как было";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ShopADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 507);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.gbComments);
            this.Controls.Add(this.gbTresh);
            this.Controls.Add(this.btnAdminka);
            this.Controls.Add(this.gr);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShopADO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.ShopADO_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbTresh.ResumeLayout(false);
            this.gbTresh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.gbComments.ResumeLayout(false);
            this.gbComments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.ListBox lbCrusa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdminka;
        private System.Windows.Forms.GroupBox gbTresh;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ListBox lbToSale;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbComments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbManufacturer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnReset;
    }
}

