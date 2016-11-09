using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___TreeView
{
    public partial class Form1 : Form
    {
        //TreeNode newNode = new TreeNode("text", 2, 0);
        ListBox lbForm;
        ListBox lbPanel;
        List<string> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<string>();
        }

        private void addChiledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("text", 2, 0);
            treeView1.SelectedNode.Nodes.Add(newNode);
            treeView1.SelectedNode.Expand();
            treeView1.SelectedNode = newNode;
        }

        private void reamoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var del =MessageBox.Show("Уверен???", "Delete", MessageBoxButtons.OKCancel);
            if(del == DialogResult.OK)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void addRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("sargae");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
          //TreeNode treenode =treeView1.GetNodeAt(new Point(e.X, e.Y));
           // MessageBox.Show(treenode.Text);

        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
          //  MessageBox.Show(e.Node.Name);
        }

        private void recurse_list(TreeNodeCollection nodes,string QName)
        {
            foreach (TreeNode i in nodes)
            {

                if(i.Nodes.Count>0)
                {
                    recurse_list(i.Nodes, QName + i.Text + ":");
                }
            }
        }

        private void buttonAddlbPanelka_Click(object sender, EventArgs e)
        {
            lbPanel = new ListBox();
            lbPanel.Left = 20;
            lbPanel.Top = 20;
            lbPanel.Width = 300;
            lbPanel.Height = 188;
            list.Clear();
            recurse_list(treeView1.Nodes,string.Empty);
            foreach (var item in list)
            {
                lbPanel.Items.Add(item);
            }
           // lbPanel.Items = list;
            Panelka.Controls.Add(lbPanel);

        }

        private void dell_Click(object sender, EventArgs e)
        {
            lbPanel.Items.Clear();
            Panelka.Controls.Remove(lbPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbForm = new ListBox();
            lbForm.Left = 230;lbForm.Top
        }
    }
}
