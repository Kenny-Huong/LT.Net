using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_BTVN_Bai1
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

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtN.Text, out n) && n > 0)
            {
                double sum = CalculateSum(n);
                lbKQ.Text = "Tổng S = " + sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương hợp lệ.");
            }
        }

        private double CalculateSum(int n)
        {
            double sum = 1.0; // Bắt đầu với 1 vì phần tử đầu tiên của tổng là 1
            double factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;  // Tính giai thừa
                sum += 1.0 / factorial;  // Cộng vào tổng
            }

            return sum;
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
