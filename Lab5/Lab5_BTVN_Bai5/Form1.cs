using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_BTVN_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                string[] fullName = e.Node.Text.Split(',');
                if (fullName.Length == 2)
                {
                    txtLastName.Text = fullName[0].Trim();
                    txtFirstName.Text = fullName[1].Trim();
                }
            }
        }
        private void PopulateTreeView()
        {
            treeView1.Nodes.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                treeView1.Nodes.Add(c.ToString(), c.ToString());
            }
        }
        private void btnAddName_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Vui lòng điền FirstName và LastName .");
                return;
            }

            char firstChar = lastName.ToUpper()[0];
            TreeNode node = treeView1.Nodes[firstChar.ToString()];

            if (node != null)
            {
                node.Nodes.Add($"{lastName}, {firstName}");
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = toolStripTextBox1.Text.Trim().ToLower();
            foreach (TreeNode node in treeView1.Nodes)
            {
                foreach (TreeNode childNode in node.Nodes)
                {
                    string fullName = childNode.Text.ToLower();
                    if (fullName.Contains(searchText))
                    {
                        treeView1.SelectedNode = childNode;
                        txtFirstName.Text = fullName.Split(',')[1].Trim();
                        txtLastName.Text = fullName.Split(',')[0].Trim();
                        return;
                    }
                }
            }
            MessageBox.Show("Không tìm thấy tên.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
