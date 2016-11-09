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

namespace Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PopulateTreeView()
        {
            TreeNode rootnode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if(info.Exists)
            {
                rootnode = new TreeNode(info.Name);
                rootnode.Tag = info;
                GetDirectories(info.GetDirectories(), rootnode);
                treeView1.Nodes.Add(rootnode);
            }
        }


        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                  {new ListViewItem.ListViewSubItem(item, "Directory"),
                   new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                  { new ListViewItem.ListViewSubItem(item, "File"),
                   new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }




        private void GetDirectories(DirectoryInfo[] subDir,TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] SubDirs;
            foreach (DirectoryInfo subDir1 in subDir)
            {
                aNode = new TreeNode(subDir1.Name, 0, 1);
                aNode.Tag = subDir1;
                SubDirs = subDir1.GetDirectories();
                if(SubDirs.Length!=0)
                {
                    GetDirectories(SubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
    }
}
