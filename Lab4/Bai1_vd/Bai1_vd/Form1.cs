using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_vd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbSelectColor.Items.Add("Yellow");
            cbbSelectColor.Items.Add("Red");
            cbbSelectColor.Items.Add("Blue");
            cbbSelectColor.Items.Add("Green");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Left = this.Width / 2 - label1.Width / 2;
           
            btnColorChange.Enabled = false;
        }

        private void btnColorChange_Click(object sender, EventArgs e)
        {
            if(cbbSelectColor.Text == "Yellow")
            {
                this.BackColor = Color.Yellow;
            }
            if (cbbSelectColor.Text == "Red")
            {
                this.BackColor = Color.Red;
            }
            if (cbbSelectColor.Text == "Blue")
            {
                this.BackColor = Color.Blue;
            }
            if (cbbSelectColor.Text == "Green")
            {
                this.BackColor = Color.Green;
            }

        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbbSelectColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnColorChange.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label1.Left = this.Width / 2 - label1.Width / 2;
            
        }
    }
}
