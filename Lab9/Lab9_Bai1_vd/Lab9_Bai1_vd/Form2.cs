using Lab9_Bai1_vd.DomainClass;
using Lab9_Bai1_vd.Responsitories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab9_Bai1_vd
{
    public partial class Form2 : Form
    {
        MatHangResponsitories _repos = new MatHangResponsitories();

        public Form2()
        {
            InitializeComponent();
            LoadGidMH();
        }

        public void LoadGidMH()
        {
            dataGridView1.Rows.Clear(); // Xóa các hàng trước khi tải lại dữ liệu

            foreach (var stu in _repos.GetTblMatHangs())
            {
                dataGridView1.Rows.Add(stu.MaMh, stu.TenMh, stu.Dvt);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtMaMatHang.Text = row.Cells[0].Value?.ToString();
                txtTenMatHang.Text = row.Cells[1].Value?.ToString();
                txtDonViTinh.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMatHang.Text) ||
                string.IsNullOrWhiteSpace(txtTenMatHang.Text) ||
                string.IsNullOrWhiteSpace(txtDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm.");
                return;
            }

            var matHang = new TblMatHang
            {
                MaMh = txtMaMatHang.Text,
                TenMh = txtTenMatHang.Text,
                Dvt = txtDonViTinh.Text
            };

            bool isAdded = _repos.AddMatHang(matHang);
            if (isAdded)
            {
                MessageBox.Show("Thêm mới mặt hàng thành công");
                LoadGidMH();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm mặt hàng. Có thể mã đã tồn tại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để xóa.");
                return;
            }

            var maMh = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            var obj = _repos.GetTblMatHangs().FirstOrDefault(mh => mh.MaMh == maMh);

            if (obj == null)
            {
                MessageBox.Show("Không tìm thấy mặt hàng để xóa.");
                return;
            }

            bool isDeleted = _repos.DeleteMatHang(obj);
            if (isDeleted)
            {
                MessageBox.Show("Xóa mặt hàng thành công");
                LoadGidMH();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình xóa mặt hàng.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMatHang.Text))
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để sửa thông tin.");
                return;
            }

            var obj = new TblMatHang
            {
                MaMh = txtMaMatHang.Text,
                TenMh = txtTenMatHang.Text,
                Dvt = txtDonViTinh.Text
            };

            bool result = _repos.Update(obj);
            if (result)
            {
                MessageBox.Show("Sửa thông tin mặt hàng thành công");
                LoadGidMH();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình sửa thông tin mặt hàng.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maMh = txtMaMatHang.Text.Trim();

            if (string.IsNullOrEmpty(maMh))
            {
                MessageBox.Show("Vui lòng nhập mã mặt hàng cần tìm");
                return;
            }

            // Tìm khách hàng theo mã
            var matHang = _repos.GetTblMatHangs().FirstOrDefault(kh => kh.MaMh == maMh);

            if (matHang != null)
            {
                // Hiển thị thông tin khách hàng tìm thấy trên DataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(matHang.MaMh, matHang.TenMh, matHang.Dvt);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mặt hàng với mã này");
                LoadGidMH(); // Hiển thị lại danh sách khách hàng nếu không tìm thấy
            }
        }
    }
}
