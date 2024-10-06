using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lbResult.Enabled = false;
            btnResult.Enabled = false;
            btnResult.Enabled = false;
        }

        bool kiemTra(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        bool kiemTraSuLieu()
        {
            if (kiemTra(txtA.Text)) return false;
            if (kiemTra(txtB.Text)) return false;
            return true;
        }

        bool kiemTraSoThuc(string input)
        {
            float result;
            return float.TryParse(input, out result);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(kiemTraSuLieu())
            {
                if (!kiemTraSoThuc(txtA.Text) || !kiemTraSoThuc(txtB.Text)){
                    MessageBox.Show("Dữ liệu nhập vào cần phải là số thực ", "Thông báo");
                    return;
                }
                btnResult.Enabled=true;
                btnCheck.Enabled=false;
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo");
                return;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            if (a == 0)
            {
                if (b < 0)
                {
                    lbResult.Text = "Bất phương trình luôn đúng với mọi x";
                }
                else
                {
                    lbResult.Text = "Bất phương trình vô nghiệm";
                }
            }
            else
            {
                float x = -b / a;
                if (a > 0)
                {
                    lbResult.Text = $"Nghiệm của phương trình là x > {x}";
                }
                else
                {
                    lbResult.Text = $"Nghiệm của phương trình là x < {x}";
                }
            }
            lbResult.Enabled = true;
        }
    }
}
