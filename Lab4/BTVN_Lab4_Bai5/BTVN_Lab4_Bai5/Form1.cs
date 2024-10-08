using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Lab4_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbFonts.Items.Add("Times New Roman");
            cbbFonts.Items.Add("Arial");
            cbbFonts.Items.Add("Tahoma");
            cbbFonts.SelectedIndex = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi chọn phông chữ, thay đổi phông chữ cho RichTextBox
            string selectedFont = cbbFonts.SelectedItem.ToString();
            rtbVanBan.SelectionFont = new Font(selectedFont, rtbVanBan.Font.Size, rtbVanBan.Font.Style);
        }
    }
}
