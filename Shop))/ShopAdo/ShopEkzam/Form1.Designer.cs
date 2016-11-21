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
            this.lbManufacturer = new System.Windows.Forms.ListBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.lbCrusa = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gr = new System.Windows.Forms.GroupBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdminka = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbGood = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbToSale = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnO = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.FormattingEnabled = true;
            this.lbManufacturer.Location = new System.Drawing.Point(6, 19);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(215, 95);
            this.lbManufacturer.TabIndex = 3;
            this.lbManufacturer.SelectedIndexChanged += new System.EventHandler(this.lbManufacturer_SelectedIndexChanged);
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
            this.groupBox3.Controls.Add(this.lbManufacturer);
            this.groupBox3.Location = new System.Drawing.Point(18, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 130);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Производители";
            // 
            // gr
            // 
            this.gr.Controls.Add(this.pictureBox2);
            this.gr.Controls.Add(this.pictureBox1);
            this.gr.Controls.Add(this.btnAdd1);
            this.gr.Controls.Add(this.lbCrusa);
            this.gr.Location = new System.Drawing.Point(254, 12);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(535, 316);
            this.gr.TabIndex = 8;
            this.gr.TabStop = false;
            this.gr.Text = "Выборка";
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.Gold;
            this.btnAdd1.Location = new System.Drawing.Point(312, 223);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(124, 23);
            this.btnAdd1.TabIndex = 6;
            this.btnAdd1.Text = "Добавить в корзину";
            this.btnAdd1.UseVisualStyleBackColor = false;
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(260, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 165);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnAdminka
            // 
            this.btnAdminka.Location = new System.Drawing.Point(1234, 589);
            this.btnAdminka.Name = "btnAdminka";
            this.btnAdminka.Size = new System.Drawing.Size(121, 23);
            this.btnAdminka.TabIndex = 9;
            this.btnAdminka.Text = "Админка";
            this.btnAdminka.UseVisualStyleBackColor = true;
            this.btnAdminka.Click += new System.EventHandler(this.btnAdminka_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox3);
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Controls.Add(this.lbGood);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Location = new System.Drawing.Point(795, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(560, 316);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Все товары в Одном Списке!";
            // 
            // lbGood
            // 
            this.lbGood.FormattingEnabled = true;
            this.lbGood.Location = new System.Drawing.Point(6, 19);
            this.lbGood.Name = "lbGood";
            this.lbGood.Size = new System.Drawing.Size(245, 251);
            this.lbGood.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(284, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 165);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Blue;
            this.pictureBox4.Location = new System.Drawing.Point(272, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(275, 188);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Location = new System.Drawing.Point(343, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить в корзину";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.pictureBox5);
            this.groupBox6.Controls.Add(this.pictureBox6);
            this.groupBox6.Controls.Add(this.btnRemove);
            this.groupBox6.Controls.Add(this.lbToSale);
            this.groupBox6.Location = new System.Drawing.Point(254, 334);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(625, 278);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Корзина";
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
            // lbToSale
            // 
            this.lbToSale.FormattingEnabled = true;
            this.lbToSale.Location = new System.Drawing.Point(6, 19);
            this.lbToSale.Name = "lbToSale";
            this.lbToSale.Size = new System.Drawing.Size(225, 251);
            this.lbToSale.TabIndex = 5;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(248, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Купить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(481, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "грн";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(901, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 249);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Акции и Бонусы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Не знаете что подарить Своим друзьям и близким??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Подарите Старый Samsung 3 Duos!!!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ведь только в этой жизни покупая продукцию из нашего магазина ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Можно выиграть : Машину, Квартиру, своего бекенд Разроботчика";
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(901, 589);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(131, 23);
            this.btnO.TabIndex = 12;
            this.btnO.Text = "Оставить отзыв";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // ShopADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 707);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lbManufacturer;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.ListBox lbCrusa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnAdminka;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox lbGood;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ListBox lbToSale;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnO;
    }
}

