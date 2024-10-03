using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BTVN_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap.Enabled = true;
            btnChuyen.Enabled = false;
            btnThoat.Enabled = true;
            txtXuat.Enabled = false;
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            btnChuyen.Enabled = true;
        }

        // Hàm kiểm tra chuỗi rỗng
        bool kiemTra(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        // Hàm kiểm tra dữ liệu đầu vào, chỉ kiểm tra xem có rỗng không
        bool kiemTraDuLieu()
        {
            if (kiemTra(txtNhap.Text)) return false;
            return true;
        }

        // Hàm xác định độ ưu tiên của toán tử
        int doUuTien(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        // Hàm chuyển đổi từ biểu thức trung tố sang hậu tố
        string chuyenTrungToSangHauTo(string bieuThuc)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder hauTo = new StringBuilder();

            foreach (char c in bieuThuc)
            {
                // Nếu ký tự là toán hạng (biến hoặc số), thêm vào kết quả hậu tố
                if (char.IsLetterOrDigit(c))
                {
                    hauTo.Append(c);
                }
                // Nếu ký tự là dấu ngoặc mở, đẩy vào ngăn xếp
                else if (c == '(')
                {
                    stack.Push(c);
                }
                // Nếu là dấu ngoặc đóng, lấy các toán tử ra khỏi ngăn xếp cho đến khi gặp dấu ngoặc mở
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        hauTo.Append(stack.Pop());
                    }
                    stack.Pop(); // Loại bỏ dấu ngoặc mở '('
                }
                // Nếu ký tự là toán tử
                else
                {
                    while (stack.Count > 0 && doUuTien(c) <= doUuTien(stack.Peek()))
                    {
                        hauTo.Append(stack.Pop());
                    }
                    stack.Push(c);
                }
            }

            // Lấy tất cả các toán tử còn lại trong ngăn xếp
            while (stack.Count > 0)
            {
                hauTo.Append(stack.Pop());
            }

            return hauTo.ToString();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (kiemTraDuLieu())
            {
                string bieuThucTrungTo = txtNhap.Text;
                string bieuThucHauTo = chuyenTrungToSangHauTo(bieuThucTrungTo);
                txtXuat.Text = bieuThucHauTo; // Hiển thị kết quả hậu tố
                txtXuat.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu trong biểu thức trung tố, hãy nhập lại ", "Thông báo");
                txtNhap.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
