using System;
using System.Windows.Forms;

namespace Lab6_Bai1_vd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1 giây
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime now = DateTime.Now;
            string s = "Hôm nay là ngày " + now.ToString("dd/MM/yyyy");
            s = s + " - Bây giờ là " + now.ToString("hh:mm:ss tt");

            // Thêm thông tin về sáng, chiều, tối, đêm
            if (now.Hour >= 5 && now.Hour < 12)
            {
                s = s + " - Buổi sáng";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                s = s + " - Buổi chiều";
            }
            else if (now.Hour >= 18 && now.Hour < 22)
            {
                s = s + " - Buổi tối";
            }
            else
            {
                s = s + " - Buổi đêm";
            }

            // Hiển thị thông tin vào thanh trạng thái
            toolStripStatusLabel1.Text = s;


            // Kiểm tra độ dài chuỗi trước khi xoay vòng
            if (this.Text.Length > 1)
            {
                this.Text = this.Text.Substring(1, this.Text.Length - 1) + this.Text.Substring(0, 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại mở file
            OpenFileDialog dlg = new OpenFileDialog();
            // Cập nhật lọc hiển thị các loại file bao gồm MOV
            dlg.Filter = "AVI file | *.avi | MPEG File | *.mpeg | Wav file | *.wav | Midi File | *.midi | Mp4 File | *.mp4 | MOV File | *.mov";

            // Hiển thị OpenDialog
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = dlg.FileName; // Lấy tên file và gán cho MediaPlayer
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
