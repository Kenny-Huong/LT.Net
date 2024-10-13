using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_BTVN_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = richTextBox1.Text.ToLower();

            ResetAlphabetColors();

            // Đổi màu đỏ cho các ký tự có trong RichTextBox
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    HighlightLetter(c);
                }
            }
        }
        // Hàm thay đổi màu chữ cái tương ứng
        private void HighlightLetter(char letter)
        {
            Button btn = Controls.Find("btn" + letter, true).FirstOrDefault() as Button;
            if (btn != null)
            {
                btn.ForeColor = Color.Red;
            }
        }

        // Reset màu chữ cái về đen
        private void ResetAlphabetColors()
        {
            foreach (char c in "abcdefghijklmnopqrstuvwxyz")
            {
                Button btn = Controls.Find("btn" + c, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void btnDemSo_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text.ToLower();
            int distinctLetters = text.Where(char.IsLetter).Distinct().Count();
            labelResult.Text = $"Số chữ cái khác nhau có trong xâu = {distinctLetters}";
        
        }
    }
}
