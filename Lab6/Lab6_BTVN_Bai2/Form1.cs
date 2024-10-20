using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_BTVN_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nhóm 1");
            comboBox1.Items.Add("Nhóm 2");

        }

        public bool KTTen(string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }   

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool tenHopLe = KTTen(txtTen.Text);
            bool nhomHopLe = (comboBox1.SelectedIndex != -1);
            if (!tenHopLe || !nhomHopLe)
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu");
            }
            else
            {
                if(comboBox1.SelectedItem.ToString() == "Nhóm 1")
                {
                    listN1.Items.Add(txtTen.Text);
                }else if(comboBox1.SelectedItem.ToString() == "Nhóm 2")
                {
                    listN2.Items.Add(txtTen.Text);
                }
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnQua2_Click(object sender, EventArgs e)
        {
            if(listN1 != null)
            {
                var selectedItem = listN1.SelectedItem;
                listN2.Items.Add(selectedItem);
                listN1.Items.Remove(selectedItem);
            }
        }

        private void btnQua1_Click(object sender, EventArgs e)
        {
            if(listN2 != null)
            {
                var selectedItem = listN2.SelectedItem;
                listN1.Items.Add(selectedItem);
                listN2.Items.Remove(selectedItem);
            }

        }

        private void btnChuyenQ2_Click(object sender, EventArgs e)
        {
            while(listN1.Items.Count > 0)
            {
                var item = listN1.Items[0];
                listN2.Items.Add(item);
                listN1.Items.Remove(item);
            }
        }

        private void BtnChuyenQ1_Click(object sender, EventArgs e)
        {
            while(listN2.Items.Count > 0)
            {
                var item = listN2.Items[0];
                listN1.Items.Add(item);
                listN2.Items.Remove(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem listN1 có mục nào được chọn hay không
            if (listN1.SelectedItems.Count > 0)
            {
                List<object> itemsToRemove = new List<object>();

                // Lưu các mục đã chọn từ listN1 vào danh sách tạm
                foreach (var item in listN1.SelectedItems)
                {
                    itemsToRemove.Add(item);
                }

                // Xóa các mục đã chọn từ listN1
                foreach (var item in itemsToRemove)
                {
                    listN1.Items.Remove(item);
                }
            }
            // Kiểm tra xem listN2 có mục nào được chọn hay không
            else if (listN2.SelectedItems.Count > 0)
            {
                List<object> itemsToRemove = new List<object>();

                // Lưu các mục đã chọn từ listN2 vào danh sách tạm
                foreach (var item in listN2.SelectedItems)
                {
                    itemsToRemove.Add(item);
                }

                // Xóa các mục đã chọn từ listN2
                foreach (var item in itemsToRemove)
                {
                    listN2.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn mục nào để xóa!");
            }
        }
    }
}
