using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Lab4_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbWeb.Items.Add("Tuổi trẻ");
            cbbWeb.Items.Add("Thanh niên");
            cbbWeb.Items.Add("VNExpress");
            cbbWeb.Items.Add("Dân trí");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbbWeb.SelectedItem != null)
            {
                txtKQ.Text = $"Bạn đã chọn website {cbbWeb.SelectedItem.ToString()}";
            }
            else
            {
                txtKQ.Text = "Chưa có giá trị, yêu cầu chọn lại trong danh sách web";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
        }
    }
}
