using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_vd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (kiemTraDuLieu())
            {
                int s = 0;
                lqKQ.Enabled = true;
                int n = int.Parse(txtN.Text);
                
                for (int i = 1; i <= n; i++)
                {
                    s += 1/ i;
                }
                lqKQ.Text = "Tổng các chữ số của n là : " + s.ToString();
            }
            else
            {
                MessageBox.Show("Nhập sai n", "Thông báo");
                txtN.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            lqKQ.Enabled = false;
        }

        bool kiemTra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            else return true;
        }

        bool kiemTraDuLieu()
        {
            int n;
            if(kiemTra(txtN.Text)) return false;
            if(!int.TryParse(txtN.Text, out n)|| n <= 0) return false;
            return true;
         }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            if (kiemTraDuLieu())
            {
                int s = 0, r;
                lqKQ.Enabled = true;
                int n = int.Parse(txtN.Text);
                while(n != 0)
                {
                    r = n % 10;
                    s += r;
                    n /= 10;
                }
                lqKQ.Text = "Tổng các chữ số của n là : " + s.ToString();
            }
            else
            {
                MessageBox.Show("Nhập sai n", "Thông báo");
                txtN.Focus();
            }
        }
    }
}
