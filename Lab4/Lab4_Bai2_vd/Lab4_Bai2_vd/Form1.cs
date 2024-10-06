using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai2_vd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbTinhToan.Items.Add("+");
            cbbTinhToan.Items.Add("-");
            cbbTinhToan.Items.Add("*");
            cbbTinhToan.Items.Add("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbbTinhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((txtSo1.Text == "") || (txtSo2.Text == ""))
            {
                MessageBox.Show("Yêu cầu nhập dữ liệu cho 2 số", "Thông báo");
                txtSo1.Focus();
            }
            else
            {
                double a, b, cong, tru, nhan, chia;
                int pt;
                a = Convert.ToInt32(txtSo1.Text);
                b = Convert.ToInt32(txtSo2.Text);
                pt = cbbTinhToan.SelectedIndex;

                switch(pt)
                {
                    case 0:
                        cong = a + b;
                        txtResult.Text = cong.ToString();
                        break;
                    case 1:
                        tru = a - b;
                        txtResult.Text = tru.ToString();
                        break;
                    case 2:
                        nhan = a * b;
                        txtResult.Text = nhan.ToString();
                        break;
                    case 3:
                        if (b != 0)
                        {
                            chia = a / b;
                            txtResult.Text = chia.ToString();
                            break ;
                        }
                        else
                        {
                            MessageBox.Show("Không chia được cho mẫu = 0");
                            break ;
                        }
                }
            }
        }
    }
}
