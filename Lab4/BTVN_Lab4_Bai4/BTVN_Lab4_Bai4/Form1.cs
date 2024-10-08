using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Lab4_Bai4
{
    public partial class Form1 : Form
    {
        private int selctedIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }
        bool kiemTra(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        bool kiemTraDuLieu()
        {
            int n;
            if(kiemTra(txtN.Text))
            {
                MessageBox.Show("Chưa có dữ liệu , vui lòng nhập số", "Lỗi");
                txtN.Focus();
                return false;
            }
            return true;
            
        }
        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kiemTraDuLieu())
            {
                var number = txtN.Text;
                listNumber.Items.Add(number);
                txtN.Clear();
                txtN.Focus();
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listNumber.Items.Count; i++)
            {
                {
                    if (int.TryParse(listNumber.Items[i].ToString(), out int number))
                    {
                        number += 2;
                        listNumber.Items[i] = number;
                    }
                }
            }
        }

        private void grChucNang_Enter(object sender, EventArgs e)
        {

        }

        private void btnChanDau_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < listNumber.Items.Count;i++)
            {
                if (int.TryParse(listNumber.Items[i].ToString(), out int number)&&number%2==0){
                    MessageBox.Show($"Sỗ chẵn đầu tiên là {number}", "Số chẵn");
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn nào trong danh sách");
        }

        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            for(int i = listNumber.Items.Count - 1; i >= 0; i--)
            {
                if (int.TryParse(listNumber.Items[i].ToString(), out int number) && number % 2 != 0)
                {
                    MessageBox.Show($"Sỗ lẻ cuối cùng là {number}", "Số lẻ");
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ nào trong danh sách ");
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            var selectedItem = listNumber.SelectedItem;
            listNumber.Items.Remove(selectedItem);
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listNumber.Items.Count; i++)
            {
                listNumber.Items.RemoveAt(i);
                return;
            }
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            for (int i = listNumber.Items.Count - 1; i >= 0; i--)
            {
                listNumber.Items.RemoveAt(i);
                return;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
