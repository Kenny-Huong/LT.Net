using NguyenVanHuong_DHTI15A5HN_05112024.DomainClass;
using NguyenVanHuong_DHTI15A5HN_05112024.Responsitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NguyenVanHuong_DHTI15A5HN_05112024
{
    public partial class Form1 : Form
    {
        KhachHangRepos _repos = new KhachHangRepos();
        public Form1()
        {
            InitializeComponent();
            cbo_GioiTinh.Items.Add("Nam");
            cbo_GioiTinh.Items.Add("Nữ");
            
        }
        public void LoadGidKH()
        {
            Type type = typeof(KhachHang);
            int slThuocTinh = type.GetProperties().Length;
            dataGridView1.ColumnCount = slThuocTinh;

            dataGridView1.Columns[0].Name = "Mã KH";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Name = "Họ tên";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Name = "Giới tính";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Name = "Địa chỉ";
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Name = "Điện thoại";
            dataGridView1.Columns[4].Width = 200;

            dataGridView1.Rows.Clear();

            foreach (var stu in _repos.GetKhachHangs())
            {
                // Kiểm tra xem tất cả thuộc tính của khách hàng đều có dữ liệu hợp lệ
                if (!string.IsNullOrEmpty(stu.MaKh) &&
                    !string.IsNullOrEmpty(stu.TenKh) &&
                    !string.IsNullOrEmpty(stu.GioiTinh) &&
                    !string.IsNullOrEmpty(stu.DiaChi) &&
                    !string.IsNullOrEmpty(stu.DienThoai))
                {
                    dataGridView1.Rows.Add(stu.MaKh, stu.TenKh, stu.GioiTinh, stu.DiaChi, stu.DienThoai);
                }
            }
        }

        private void btn_GoiDuLieu_Click(object sender, EventArgs e)
        {
            LoadGidKH();
        }

        private void lv_DSKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang obj = new KhachHang();
            if (string.IsNullOrWhiteSpace(txt_MaKhachHang.Text) ||
                string.IsNullOrWhiteSpace(txt_HoTen.Text) ||
                cbo_GioiTinh.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
                string.IsNullOrWhiteSpace(txt_DienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Thông báo");
                return;
            }
            obj.MaKh = txt_MaKhachHang.Text;
            obj.TenKh = txt_HoTen.Text;
            obj.GioiTinh = cbo_GioiTinh.SelectedItem != null ? cbo_GioiTinh.SelectedItem.ToString() : "";
            obj.DiaChi = txt_DiaChi.Text;
            obj.DienThoai = txt_DienThoai.Text;

            MessageBox.Show("Thêm khách hàng thành công", "Thông báo by Kenny");
            _repos.AddKhachHang(obj);
            LoadGidKH();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txt_MaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa thông tin");
                return;
            }

            KhachHang obj = new KhachHang
            {
                
                TenKh = txt_HoTen.Text,
                GioiTinh = cbo_GioiTinh.SelectedItem != null ? cbo_GioiTinh.SelectedItem.ToString() : "",
                DiaChi = txt_DiaChi.Text,
                DienThoai = txt_DienThoai.Text
            };

            //Gọi phương thức sủa thông tin khách hàng
            bool result = _repos.UpdateKhachHang(obj);

            if (result)
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
                LoadGidKH();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình sửa thông tin khách hàng");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKhachHang.Enabled=false;
            //Kiểm tra xem người dùng đã chọn hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                //Lấy thông tin từ hàng được chọn
                var row = dataGridView1.Rows[e.RowIndex];
                txt_MaKhachHang.Text = row.Cells[0].Value.ToString();
                txt_HoTen.Text = row.Cells[1].Value.ToString();
                // Cập nhật giá trị cho comboBox1
                string gioiTinh = row.Cells[2].Value.ToString();
                cbo_GioiTinh.SelectedItem = gioiTinh; // Cố gắng tìm và chọn giá trị trong ComboBox
                if (cbo_GioiTinh.Items.Contains(gioiTinh) == false)
                {
                    cbo_GioiTinh.SelectedIndex = 1; // Nếu không tìm thấy, không chọn gì
                }
                txt_DiaChi.Text = row.Cells[3].Value.ToString();
                txt_DienThoai.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = _repos.GetKhachHangs().FirstOrDefault(kh => kh.MaKh == dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _repos.DeleteKhachHang(obj);
            LoadGidKH();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
