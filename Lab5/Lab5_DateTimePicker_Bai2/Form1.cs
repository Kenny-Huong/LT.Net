using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_DateTimePicker_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if(txtMatHang.Text != "" && txtGiaBan.Text != "" && txtXuatXu.Text != "")
            {
                if(dateTimePicker1.Value.Year < 1990)
                {
                    MessageBox.Show("Hàng đã cũ, cần thanh lý");
                }else if(dateTimePicker1.Value.Year < 2010){
                    MessageBox.Show("Hàng còn dùng được");
                }
                else
                {
                    MessageBox.Show("Hàng mới");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầu đủ thông tin");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Ngày nhập đã đổi thàn {dateTimePicker1.Value.Day}/{dateTimePicker1.Value.Month}/{dateTimePicker1.Value.Year}");
        }
    }
}
