using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_DateTimePicker_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text != "" && txtQueQuan.Text != "")
            {
                if(dateTimePicker1.Value.Year <= 2006)
                {
                    MessageBox.Show("Đăng ký thành công");
                }
                else
                {
                    MessageBox.Show("Bạn phải trên 18 tuổi mới được đăng ký ");
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "Thông báo");
            }
        }
    }
}
