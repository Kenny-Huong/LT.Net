using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_BTVN_Bai3
{
    public partial class Form1 : Form
    {
        // Biến lưu trữ màu vẽ
        private Color colorToDraw = Color.Black;
        private string shapeToDraw = "HinhVuong"; // Mặc định là hình vuông

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollRed.Minimum = 0;
            hScrollGreen.Minimum = 0;
            hScrollBlue.Minimum = 0;
            hScrollBlue.Maximum = 255;
            hScrollGreen.Maximum = 255;
            hScrollRed.Maximum = 255;

            // Gọi sự kiện vẽ khi thay đổi lựa chọn RadioButton
            rdHinhTron.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rdElipse.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rdHCN.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rdHinhVuong.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            panelPreview.Paint += new PaintEventHandler(panelPreview_Paint); // Bắt sự kiện Paint cho panel
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Cập nhật hình cần vẽ dựa trên lựa chọn của RadioButton
            if (rdHinhTron.Checked)
                shapeToDraw = "HinhTron";
            else if (rdElipse.Checked)
                shapeToDraw = "Elipse";
            else if (rdHCN.Checked)
                shapeToDraw = "HCN";
            else if (rdHinhVuong.Checked)
                shapeToDraw = "HinhVuong";

            // Gọi vẽ lại panel
            panelPreview.Invalidate();
        }

        private void hScrollRed_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void hScrollGreen_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void hScrollBlue_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            int red = hScrollRed.Value;
            int green = hScrollGreen.Value;
            int blue = hScrollBlue.Value;
            colorToDraw = Color.FromArgb(red, green, blue);

            // Yêu cầu vẽ lại hình với màu mới
            panelPreview.Invalidate();
        }

        private void panelPreview_Paint(object sender, PaintEventArgs e)
        {
            // Lấy Graphics từ PaintEventArgs
            Graphics g = e.Graphics;

            Brush brush = new SolidBrush(colorToDraw);

            // Vẽ hình theo lựa chọn RadioButton
            if (shapeToDraw == "HinhTron")
            {
                g.FillEllipse(brush, 10, 10, 100, 100);
            }
            else if (shapeToDraw == "Elipse")
            {
                g.FillEllipse(brush, 10, 10, 150, 100);
            }
            else if (shapeToDraw == "HCN")
            {
                g.FillRectangle(brush, 10, 10, 150, 100);
            }
            else if (shapeToDraw == "HinhVuong")
            {
                g.FillRectangle(brush, 10, 10, 100, 100);
            }

            brush.Dispose();  // Giải phóng tài nguyên brush
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            // Gọi vẽ lại khi nhấn nút "Vẽ"
            panelPreview.Invalidate();
        }
    }
}
