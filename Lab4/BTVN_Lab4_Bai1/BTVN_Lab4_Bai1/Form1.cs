using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Lab4_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstWeb.Items.Add("Tuổi trẻ");
            lstWeb.Items.Add("Thanh niên");
            lstWeb.Items.Add("VNExpress");
            lstWeb.Items.Add("Dân trí");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {
            txtKQ.ReadOnly = true;
        }

        private void lstWeb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(lstWeb.SelectedItem != null)
            {
                txtKQ.Text = $"Bạn đã chọn website {lstWeb.SelectedItem.ToString()}";
            }
            else
            {
                txtKQ.Text = "Chưa có dữ liệu, yêu cầu chọn lại trong listWeb";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
        }
    }
}
