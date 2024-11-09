using Lab10_QLThuVien_110824.DomainClass;
using Lab10_QLThuVien_110824.Responsitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_QLThuVien_110824
{
    public partial class Form1 : Form
    {
        NhanVienRepos _repos = new NhanVienRepos();
        public Form1()
        {
            InitializeComponent();
            LoadGidMH();
        }
        public void LoadGidMH()
        {
            dataGridView1.Rows.Clear(); // Xóa các hàng trước khi tải lại dữ liệu

            foreach (var stu in _repos.GetNhanviens())
            {
                dataGridView1.Rows.Add(stu.HoTenNhanVien, stu.NgaySinh.Value.ToString(), stu.DienThoai, stu.DiaChi);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells[0].Value?.ToString();

                if (DateTime.TryParse(row.Cells[1].Value?.ToString(), out DateTime dateValue))
                {
                    dateTimePicker1.Value = dateValue;
                }
                else
                {
                    
                    dateTimePicker1.Value = DateTime.Today;
                }
               
                txtDienThoai.Text = row.Cells[2].Value?.ToString();
                txtDiaChi.Text = row.Cells[3].Value?.ToString();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm.");
                return;
            }
            if (_repos.CheckIfPhoneExists(txtDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập lại.");
                return;
            }


            var nhanvien = new Nhanvien
            {
                HoTenNhanVien = txtHoTen.Text,
                DienThoai = txtDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                NgaySinh = dateTimePicker1.Value
            };

            bool isAdded = _repos.AddNhanVien(nhanvien);
            if (isAdded)
            {
                MessageBox.Show("Thêm mới nhân viên thành công");
                LoadGidMH();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm nhân viên. Có thể mã đã tồn tại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
