using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Lab4_Bai3
{
    public partial class Form1 : Form
    {
        private int selectedIndexA = -1;
        private int selectedIndexB = -1;
        public Form1()
        {
            InitializeComponent();
            listA.Items.Add("Nguyễn Văn Hướng");
            listA.Items.Add("Lê Hoài Khiêm");
            listA.Items.Add("Nguyễn Tấn Ngọc");
            listA.Items.Add("Trần Quang Quân");
            listB.Items.Add("Lê Thị Ngọc Ánh");
            listB.Items.Add("Hoàng Thị Linh");
            listB.Items.Add("Hà Thị Ánh Tuyết");
            listB.Items.Add("Nguyễn Trọng Bằng");
            listB.Items.Add("Nguyễn Việt Cường");

            btnXoaA.Enabled = false;
            btnXoaB.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnAllRight.Enabled = false;
            btnAllLeft.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var selectedItem = listA.SelectedItem;
            listA.Items.Remove(selectedItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var selectedItem = listB.SelectedItem;
            listB.Items.Remove(selectedItem);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(listA.SelectedItem != null)
            {
                var selectedItem = listA.SelectedItem;
                listB.Items.Add(selectedItem);
                listA.Items.Remove(selectedItem);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(listB.SelectedItem != null)
            {
                var selectedItem = listB.SelectedItem;
                listA.Items.Add(selectedItem);
                listB.Items.Remove(selectedItem);
            }
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            while (listA.Items.Count > 0)
            {
                var item = listA.Items[0];
                listB.Items.Add(item);
                listA.Items.Remove(item);
            }
        }

        private void listB_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoaB.Enabled = true;
            btnLeft.Enabled = true;
            btnAllLeft.Enabled = true;

            selectedIndexB = listB.SelectedIndex;
            if (listB.SelectedIndex >= 0)
            {
                var selectedItem = listB.SelectedItem;
                txtName.Text = selectedItem.ToString();
                selectedIndexA = -1;
            }
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            while(listB.Items.Count > 0)
            {
                var item = listB.Items[0];
                listA.Items.Add(item);
                listB.Items.Remove(item);
            }
        }

        private void listA_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoaA.Enabled = true;
            btnRight.Enabled = true;
            btnAllRight.Enabled = true;

            selectedIndexA = listA.SelectedIndex;
            if(listA.SelectedIndex >= 0)
            {
                var selectedItem = listA.SelectedItem;
                txtName.Text = selectedItem.ToString();
                selectedIndexB = -1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(selectedIndexA >= 0 && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                listA.Items[selectedIndexA] = txtName.Text;
                
               
            }
            if (selectedIndexB >= 0 && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                listB.Items[selectedIndexB] = txtName.Text;


            }
        }
    }
}
