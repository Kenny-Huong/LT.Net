using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_vd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txta.Enabled = false;
            txtb.Enabled = false;
            btnBCNN.Enabled = false;
            btnUCLN.Enabled = false;
            txtUCLN.Enabled = false;
            txtBCNN.Enabled = false;
        }

        //mã lệnh kiểm tra dữ liệu nhập vào
        bool kiemTra()
        {
            int n;
            if(kiemtra(txta.Text)||kiemtra(txtb.Text))
                return false;
            if(!int.TryParse(txta.Text, out n)|| n < 0) return false;
            if(!int.TryParse(txtb.Text, out n)|| n < 0)return false;
            return true;
        }

        bool kiemtra(String s)
        {
            if(string.IsNullOrEmpty(s)) return true;
            return false;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txta.Enabled=true;
            txtb.Enabled=true;
            txta.Focus();
            btnBCNN.Enabled=true;
            btnUCLN.Enabled=true;
        }

        int ucln(int a, int b)
        {
            while(a != b)
                if (a > b) a -= b;
                else b -= a;
            return a;
            
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            btnNhap.Enabled=true;
            if (kiemTra())
            {
                txtUCLN.Text = ucln(int.Parse(txta.Text),int.Parse(txtb.Text)).ToString();

            }
            else MessageBox.Show("Nhập sai dữ liệu", "Thông báo");
        }

        private void btnBCNN_Click(object sender, EventArgs e)
        {
            btnNhap.Enabled = true;
            if (kiemTra())
            {
                int s1, s2;
                s1 = int.Parse(txta.Text);
                s2 = int.Parse(txtb.Text);
                int n = ucln(s1, s2);
                txtBCNN.Text = ((s1 * s2) / n).ToString();
            }
            else MessageBox.Show("Nhập sai dữ liệu", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
