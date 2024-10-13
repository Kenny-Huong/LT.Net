using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Form_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbDi.Items.Add("Hà Nội");
            cbbDi.Items.Add("TPHCM");
            cbbDi.Items.Add("Hải Phòng");
            cbbDen.Items.Add("Hạ Long");
            cbbDen.Items.Add("Vũng Tàu");
            cbbDen.Items.Add("Đà Nẵng");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(txtKhachHang.Text != "" && txtDiaChi.Text != "")
            {
                if(cbbDen.SelectedItem != null && cbbDi.SelectedItem!=null)
                {
                    richTextBox1.Clear();
                    richTextBox1.Text += $"Khách hàng : {txtKhachHang.Text}\n";
                    richTextBox1.Text += $"Ngày sinh : {dateNgaySinh.Value.Day}/" +
                        $"{dateNgaySinh.Value.Month}/{dateNgaySinh.Value.Year}\n";
                    richTextBox1.Text += $"Địa chỉ : {txtDiaChi.Text}\n";
                    richTextBox1.Text += $"Điểm xuất phát : {cbbDi.SelectedItem}\n";
                    richTextBox1.Text += $"Điểm đến : {cbbDen.SelectedItem}\n";
                    DateTime inTime = dateDi.Value;
                    DateTime outTime = dateVe.Value;
                    if(outTime >= inTime)
                    {
                        txtTongNgay.Text = outTime.Subtract(inTime).Days.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Chọn đầy đủ điểm khời hành , xuất phát");
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ thông tin");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKhachHang.Clear();
            txtDiaChi.Clear();
            richTextBox1.Clear();
            txtKhachHang.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
