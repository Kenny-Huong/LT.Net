using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtn.Clear();
            txtn.Focus();
            lqKQ.Enabled = false;
        }

        
        bool kiemTra(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        
        bool kiemTraDuLieu()
        {
            int n;
            
            if (kiemTra(txtn.Text))
            {
                MessageBox.Show("Chưa có dữ liệu, hãy nhập lại", "Thông báo");
                txtn.Focus();
                return false;
            }
           
            if (!int.TryParse(txtn.Text, out n))
            {
                MessageBox.Show("Dữ liệu phải là số nguyên, hãy nhập lại", "Thông báo");
                txtn.Clear();
                txtn.Focus();
                return false;
            }
            
            if (n <= 0)
            {
                MessageBox.Show("Dữ liệu phải là số dương, hãy nhập lại", "Thông báo");
                txtn.Clear();
                txtn.Focus();
                return false;
            }
            return true;
        }

        
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (kiemTraDuLieu())
            {
                int n = int.Parse(txtn.Text);
                double sum = 0;
                
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }

                lqKQ.Enabled = true;
                lqKQ.Text = $"Tổng các số từ 1 - {n} = {sum.ToString()}";
            }
        }

      
        bool SoNT()
        {
            int n = int.Parse(txtn.Text);

            if (n <= 1) return false; 
            if (n == 2) return true; 
            if (n % 2 == 0) return false; 

            for (int i = 3; i <= Math.Sqrt(n); i += 2) // Chỉ kiểm tra số lẻ
            {
                if (n % i == 0) return false;
            }
            return true;
        }

       
        private void btnKtra_Click(object sender, EventArgs e)
        {
            if (kiemTraDuLieu()) 
            {
                int n = int.Parse(txtn.Text);
                if (SoNT()) 
                {
                    lqKQ.Text = $"{n} là số nguyên tố";
                }
                else
                {
                    lqKQ.Text = $"{n} không phải là số nguyên tố";
                }
            }
        }
    }
}
