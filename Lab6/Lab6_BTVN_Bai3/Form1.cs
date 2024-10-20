using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_BTVN_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float defaultFontSize;
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            defaultFontSize = richTextBox1.Font.Size;
        }

        private void btnSoanThao_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc nội dung file và hiển thị trong TextBox
                    string content = File.ReadAllText(openFileDialog.FileName);
                    richTextBox1.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở file: " + ex.Message);
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Ghi nội dung từ TextBox vào file
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                    MessageBox.Show("Lưu file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
                }
            }
        }

        private void forntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            // Mở hộp thoại chọn font
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Áp dụng font đã chọn cho nội dung trong RichTextBox
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            // Mở hộp thoại chọn màu sắc
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Áp dụng màu đã chọn cho văn bản trong RichTextBox
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void zoomIInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentFontSize = richTextBox1.Font.Size;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, currentFontSize + 2, richTextBox1.Font.Style);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentFontSize = richTextBox1.Font.Size;
            if (currentFontSize > 2) // Đảm bảo không quá nhỏ
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, currentFontSize - 2, richTextBox1.Font.Style);
            }
        }

        private void restoreDefaulZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, defaultFontSize, richTextBox1.Font.Style);
        }
    }
}
