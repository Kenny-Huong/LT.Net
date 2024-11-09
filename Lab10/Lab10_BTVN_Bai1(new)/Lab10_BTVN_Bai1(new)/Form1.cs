using Lab10_BTVN_Bai1_new_.DomainClass;
using Lab10_BTVN_Bai1_new_.Responsitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_BTVN_Bai1_new_
{
    public partial class Form1 : Form
    {
        SinhVienRespo _repos = new SinhVienRespo();
        public Form1()
        {
            InitializeComponent();
            LoadGidSV();    
        }
        public void LoadGidSV() {
            dataGridView1.Rows.Clear();

            foreach (var stu in _repos.GetTbSinhViens())
            {
                dataGridView1.Rows.Add(stu.MaSv, stu.Ten, stu.GioiTinh, stu.NgaySinh, stu.Sdt, stu.DiaChi, stu.MaCs, stu.MaLop);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value?.ToString();
                txtTenSV.Text = row.Cells[1].Value?.ToString();
                txtGioiTinh.Text = row.Cells[2].Value?.ToString();
                txtNgaySinh.Text = row.Cells[3].Value?.ToString();
                txtSDT.Text = row.Cells[4].Value?.ToString();
                txtDC.Text = row.Cells[5].Value?.ToString();
                txtMaSC.Text = row.Cells[6].Value?.ToString();
                txtMaLop.Text = row.Cells[7].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
                // Kiểm tra các trường nhập liệu
                if (string.IsNullOrEmpty(txtMaSV.Text) || 
                    string.IsNullOrEmpty(txtTenSV.Text) || 
                    string.IsNullOrEmpty(txtSDT.Text)||
                    string.IsNullOrEmpty(txtGioiTinh.Text)||
                    string.IsNullOrEmpty(txtNgaySinh.Text)||
                    string.IsNullOrEmpty(txtDC.Text)||
                    string.IsNullOrEmpty(txtMaSC.Text)||
                    string.IsNullOrEmpty(txtMaLop.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                var sinhVien = new TbSinhVien
                {
                    MaSv = int.Parse(txtMaSV.Text),
                    Ten = txtTenSV.Text,
                    GioiTinh = txtGioiTinh.Text,
                    NgaySinh = DateTime.Parse(txtNgaySinh.Text).Date,
                    Sdt = txtSDT.Text,
                    DiaChi = txtDC.Text,
                    MaCs = int.Parse(txtMaSC.Text),
                    MaLop = int.Parse(txtMaLop.Text)
                };

                bool isAdded = _repos.AddSinhVien(sinhVien);
                if (isAdded)
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                    LoadGidSV();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm, vui lòng kiểm tra lại");
                }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || !int.TryParse(txtMaSV.Text, out int maSV) || maSV == 0)
            {
                MessageBox.Show("Vui lòng chọn mã SV hợp lệ để sửa thông tin.");
                return;
            }

            var obj = new TbSinhVien
            {
                MaSv = maSV,  // Gán mã sinh viên từ txtMaSV.Text
                Ten = txtTenSV.Text,
                GioiTinh = txtGioiTinh.Text,
                NgaySinh = DateTime.Parse(txtNgaySinh.Text).Date,
                Sdt = txtSDT.Text,
                DiaChi = txtDC.Text,
                MaCs = int.Parse(txtMaSC.Text),
                MaLop = int.Parse(txtMaLop.Text)
            };

            bool result = _repos.UpdateSV(obj);
            if (result)
            {
                MessageBox.Show("Sửa thông tin Sinh viên thành công");
                LoadGidSV();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình sửa thông tin sinh viên.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng hiện tại trong DataGridView hay không
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để xóa.");
                return;
            }

            // Lấy giá trị mã sinh viên từ DataGridView và chuyển đổi thành kiểu int
            var maSVString = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            int maSV;
            if (int.TryParse(maSVString, out maSV))
            {
                // Tìm sinh viên trong cơ sở dữ liệu có mã sinh viên tương ứng
                var obj = _repos.GetTbSinhViens().FirstOrDefault(mh => mh.MaSv == maSV);

                if (obj == null)
                {
                    MessageBox.Show("Không tìm thấy mặt hàng để xóa.");
                    return;
                }

                // Thực hiện xóa sinh viên
                bool isDeleted = _repos.DeleteSV(obj);
                if (isDeleted)
                {
                    MessageBox.Show("Xóa mặt hàng thành công");
                    LoadGidSV();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa mặt hàng.");
                }
            }
            else
            {
                // Nếu không thể chuyển đổi giá trị mã sinh viên thành int
                MessageBox.Show("Mã sinh viên không hợp lệ.");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
