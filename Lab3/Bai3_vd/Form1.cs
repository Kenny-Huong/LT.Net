using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_vd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCanh1.Enabled = false;
            txtCanh2.Enabled = false;
            txtCanh3.Enabled = false;
            groupBox2.Enabled = false;
            lbKQ.Visible = false;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtCanh1.Enabled=true;
            txtCanh2.Enabled=true;
            txtCanh3.Enabled=true;
            groupBox2.Enabled=true;
            txtCanh1.Focus();
        }

        bool kiemTra(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
                return true;
            else return false;
        }
        bool kiemtra_dulieu()
        {
            double n;
                if(kiemTra(txtCanh1.Text)||kiemTra(txtCanh2.Text)||kiemTra(txtCanh3.Text))  return false;
                if(!double.TryParse(txtCanh1.Text, out n) || n < 0) return false;
                if(!double.TryParse(txtCanh2.Text, out n) || n < 0) return false;
                if(!double.TryParse(txtCanh3.Text, out n) || n < 0) return false;
            return true;
        }
        bool kiemTraTamGiac(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else return false;
        }

        private void rdSTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh1.Enabled = false;
            txtCanh2.Enabled = false;
            txtCanh3.Enabled = false;
            btnNhap.Enabled = false;
            lbKQ.Visible = true;

            if (kiemtra_dulieu())
            {
                double a, b, c;
                a = double.Parse(txtCanh1.Text);
                b = double.Parse(txtCanh2.Text);
                c = double.Parse(txtCanh3.Text);

                if (kiemTraTamGiac(a, b, c))
                {
                    double p = (a + b + c) / 2;
                    lbKQ.Text = "Diện tích của tam giác : " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)).ToString();
                }
                else
                {
                    lbKQ.Text = "Ba cạnh bạn nhập không tạo thành 1 tam giác ";
                }
            }
            else MessageBox.Show("Dữ liệu chưa hơp lệ", "Thông báo");
        }

        private void rdCTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh1.Enabled = false;
            txtCanh2.Enabled = false;
            txtCanh3.Enabled = false;
            btnNhap.Enabled = false;
            lbKQ.Visible = true;

            if (kiemtra_dulieu())
            {
                double a, b, c;
                a = double.Parse(txtCanh1.Text);
                b = double.Parse(txtCanh2.Text);
                c = double.Parse(txtCanh3.Text);

                if (kiemTraTamGiac(a, b, c))
                {
                    double p = (a + b + c) / 2;
                    lbKQ.Text = "Diện tích của tam giác : " + (a + b + c).ToString();
                }
                else
                {
                    lbKQ.Text = "Ba cạnh bạn nhập không tạo thành 1 tam giác ";
                }
            }
            else MessageBox.Show("Dữ liệu chưa hơp lệ", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnNhap.Enabled = true;

            txtCanh1.Focus();
            txtCanh1.Clear();
            txtCanh2.Clear();
            txtCanh3.Clear();
            lbKQ.Text = "";
            
        }
    }
}
