using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab5_BTVN_Bai2
{
    public partial class Form1 : Form
    {
        // Từ điển lưu trữ cặp từ Anh - Việt
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm từ vào ComboBox và từ điển
            dictionary.Add("Student", "Học sinh");
            dictionary.Add("Hello", "Xin chào");
            dictionary.Add("Happy", "Vui vẻ");
            dictionary.Add("Kenny", "Tên riêng");

            comboBox1.Items.AddRange(new string[] { "Student", "Hello", "Happy", "Kenny" });
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tiengAnh = comboBox1.Text;
            string tiengViet = txtTiengViet.Text;

            if (!string.IsNullOrEmpty(tiengAnh) && !string.IsNullOrEmpty(tiengViet))
            {
                if (!dictionary.ContainsKey(tiengAnh))
                {
                    // Thêm từ mới vào từ điển
                    dictionary.Add(tiengAnh, tiengViet);
                    comboBox1.Items.Add(tiengAnh);
                    MessageBox.Show("Đã thêm từ thành công");
                }
                else
                {
                    MessageBox.Show("Từ này đã tồn tại trong từ điển");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ tiếng Anh và nghĩa tiếng Việt");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem?.ToString();
            if (selected != null && dictionary.ContainsKey(selected))
            {
                txtTiengViet.Text = dictionary[selected];
            }
            else
            {
                txtTiengViet.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem?.ToString();
            if (selected != null && dictionary.ContainsKey(selected))
            {
                dictionary.Remove(selected);
                comboBox1.Items.Remove(selected);
                txtTiengViet.Clear();
                MessageBox.Show("Đã xóa từ thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn từ cần xóa.");
            }
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            dictionary.Clear();
            comboBox1.Items.Clear();
            txtTiengViet.Clear();
            MessageBox.Show("Đã xóa tất cả các từ.");
        }
    }
}
