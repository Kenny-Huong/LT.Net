using Lab10_BTVN_Bai2.DomainClass;
using Lab10_BTVN_Bai2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_BTVN_Bai2
{
    public partial class Form1 : Form
    {
        HangHoaRepos _repos = new HangHoaRepos();
        public Form1()
        {
            InitializeComponent();
            LoadGidHH();
        }
        public void LoadGidHH()
        {
            dataGridView1.Rows.Clear();
            foreach(var stu in _repos.GetTbHangHoas())
            {
                dataGridView1.Rows.Add(stu.MaHang, stu.TenHang, stu.DonVi, stu.DonGia, stu.SoLuong);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells[0].Value?.ToString();
                txtTenHang.Text = row.Cells[1].Value?.ToString();
                txtDonVi.Text = row.Cells[2].Value?.ToString();
                txtDonGia.Text = row.Cells[3].Value?.ToString();
                txtSoLuong.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text) ||
                string.IsNullOrWhiteSpace(txtTenHang.Text) ||
                string.IsNullOrWhiteSpace(txtDonVi.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm.");
                return;
            }

            var matHang = new TbHangHoa
            {
                MaHang = txtMaHang.Text,
                TenHang = txtTenHang.Text,
                DonVi = txtDonVi.Text,
                DonGia = int.Parse(txtDonGia.Text),
                SoLuong = int.Parse(txtSoLuong.Text)
            };

            bool isAdded = _repos.AddHangHoa(matHang);
            if (isAdded)
            {
                MessageBox.Show("Thêm mới mặt hàng thành công");
                LoadGidHH();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm mặt hàng. Có thể mã đã tồn tại.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để sửa thông tin.");
                return;
            }
            int donGia;
            int soLuong;

            if (!int.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá phải là một số hợp lệ.");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng phải là một số hợp lệ.");
                return;
            }


            var obj = new TbHangHoa
            {
                MaHang = txtMaHang.Text,
                TenHang = txtTenHang.Text,
                DonVi = txtDonVi.Text,
                DonGia = donGia,
                SoLuong = soLuong

            };

            bool result = _repos.Update(obj);
            if (result)
            {
                MessageBox.Show("Sửa thông tin mặt hàng thành công");
                LoadGidHH();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình sửa thông tin mặt hàng.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để xóa");
                return;
            }

            var maHH = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            var obj = _repos.GetTbHangHoas().FirstOrDefault(hh=>hh.MaHang == maHH);

            if(obj == null)
            {
                MessageBox.Show("Không tìm thấy mã mặt hàng cần xóa");
            }

            bool isDelete = _repos.Delete(obj);
            if (isDelete)
            {
                MessageBox.Show("Xóa mặt hàng thành công");
                LoadGidHH();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình xóa");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
