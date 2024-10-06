using System;
using System.Windows.Forms;

namespace NguyenVanHuong_TinhToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbPhepToan.Items.Add("+");
            cmbPhepToan.Items.Add("-");
            cmbPhepToan.Items.Add("*");
            cmbPhepToan.Items.Add("/");
            cmbPhepToan.SelectedIndex = 0; // Chọn phép toán mặc định
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKQ.Enabled = false; // Vô hiệu hóa ô kết quả
        }

        private void cmbPhepToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Không kích hoạt ô kết quả tại đây
            // txtKQ.Enabled = true;

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtSo1.Text) || string.IsNullOrWhiteSpace(txtSo2.Text))
            {
                MessageBox.Show("Vui lòng nhập cả hai số!", "Thông báo");
                txtKQ.Text = ""; // Xóa kết quả nếu không có dữ liệu
                return;
            }

            double so1, so2, ketqua = 0;
            bool isValid1 = double.TryParse(txtSo1.Text, out so1);
            bool isValid2 = double.TryParse(txtSo2.Text, out so2);

            // Kiểm tra tính hợp lệ của các số đã nhập
            if (!isValid1 || !isValid2)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Thông báo");
                txtKQ.Text = ""; // Xóa kết quả nếu có dữ liệu không hợp lệ
                return;
            }

            string phepToan = cmbPhepToan.SelectedItem.ToString();

            switch (phepToan)
            {
                case "+":
                    ketqua = so1 + so2;
                    break;
                case "-":
                    ketqua = so1 - so2;
                    break;
                case "*":
                    ketqua = so1 * so2;
                    break;
                case "/":
                    if (so2 == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Thông báo");
                        return;
                    }
                    ketqua = so1 / so2;
                    break;
            }

            txtKQ.Text = ketqua.ToString(); // Hiển thị kết quả
        }
    }
}
