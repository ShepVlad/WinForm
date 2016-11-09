namespace _01___TreeView
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node5");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuTollstrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addChiledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reamoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Treeview = new System.Windows.Forms.ImageList(this.components);
            this.Panelka = new System.Windows.Forms.Panel();
            this.buttonAddlbPanelka = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dell = new System.Windows.Forms.Button();
            this.contextMenuTollstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuTollstrip;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 2;
            this.treeView1.ImageList = this.Treeview;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node1";
            treeNode4.Text = "Node1";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Node4";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Node5";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(253, 523);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseUp);
            // 
            // contextMenuTollstrip
            // 
            this.contextMenuTollstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChiledToolStripMenuItem,
            this.reamoveToolStripMenuItem,
            this.addRootToolStripMenuItem});
            this.contextMenuTollstrip.Name = "contextMenuTollstrip";
            this.contextMenuTollstrip.Size = new System.Drawing.Size(131, 70);
            // 
            // addChiledToolStripMenuItem
            // 
            this.addChiledToolStripMenuItem.Name = "addChiledToolStripMenuItem";
            this.addChiledToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addChiledToolStripMenuItem.Text = "AddChiled";
            this.addChiledToolStripMenuItem.Click += new System.EventHandler(this.addChiledToolStripMenuItem_Click);
            // 
            // reamoveToolStripMenuItem
            // 
            this.reamoveToolStripMenuItem.Name = "reamoveToolStripMenuItem";
            this.reamoveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.reamoveToolStripMenuItem.Text = "Remove";
            this.reamoveToolStripMenuItem.Click += new System.EventHandler(this.reamoveToolStripMenuItem_Click);
            // 
            // addRootToolStripMenuItem
            // 
            this.addRootToolStripMenuItem.Name = "addRootToolStripMenuItem";
            this.addRootToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addRootToolStripMenuItem.Text = "Add root";
            this.addRootToolStripMenuItem.Click += new System.EventHandler(this.addRootToolStripMenuItem_Click);
            // 
            // Treeview
            // 
            this.Treeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Treeview.ImageStream")));
            this.Treeview.TransparentColor = System.Drawing.Color.Transparent;
            this.Treeview.Images.SetKeyName(0, "images (2).jpg");
            this.Treeview.Images.SetKeyName(1, "renault_megane_coupe_trophy_by_flav1u-d4poxmr.jpg");
            this.Treeview.Images.SetKeyName(2, "images.jpg");
            // 
            // Panelka
            // 
            this.Panelka.Location = new System.Drawing.Point(305, 12);
            this.Panelka.Name = "Panelka";
            this.Panelka.Size = new System.Drawing.Size(418, 236);
            this.Panelka.TabIndex = 1;
            // 
            // buttonAddlbPanelka
            // 
            this.buttonAddlbPanelka.Location = new System.Drawing.Point(273, 255);
            this.buttonAddlbPanelka.Name = "buttonAddlbPanelka";
            this.buttonAddlbPanelka.Size = new System.Drawing.Size(133, 23);
            this.buttonAddlbPanelka.TabIndex = 2;
            this.buttonAddlbPanelka.Text = "Add ListBox to Panel";
            this.buttonAddlbPanelka.UseVisualStyleBackColor = true;
            this.buttonAddlbPanelka.Click += new System.EventHandler(this.buttonAddlbPanelka_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add ListBox to Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dell
            // 
            this.dell.Location = new System.Drawing.Point(429, 254);
            this.dell.Name = "dell";
            this.dell.Size = new System.Drawing.Size(112, 23);
            this.dell.TabIndex = 4;
            this.dell.Text = "Remove";
            this.dell.UseVisualStyleBackColor = true;
            this.dell.Click += new System.EventHandler(this.dell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 523);
            this.Controls.Add(this.dell);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddlbPanelka);
            this.Controls.Add(this.Panelka);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuTollstrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList Treeview;
        private System.Windows.Forms.ContextMenuStrip contextMenuTollstrip;
        private System.Windows.Forms.ToolStripMenuItem addChiledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reamoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRootToolStripMenuItem;
        private System.Windows.Forms.Panel Panelka;
        private System.Windows.Forms.Button buttonAddlbPanelka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dell;
    }
}

