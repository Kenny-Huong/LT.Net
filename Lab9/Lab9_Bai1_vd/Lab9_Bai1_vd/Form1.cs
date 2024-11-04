using Lab9_Bai1_vd.DomainClass;
using Lab9_Bai1_vd.Responsitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_Bai1_vd
{
    public partial class FrmKhachHang : Form
    {
        KhachHangResponsitories _repos = new KhachHangResponsitories();
        public FrmKhachHang()
        {
           
            InitializeComponent();
            LoadGidKH();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nu");
        }

        public void LoadGidKH()
        {
            Type type = typeof(TblKhachHang);
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

            foreach (var stu in _repos.GetTblKhachHangs())
            {
                dataGridView1.Rows.Add(stu.MaKh, stu.Hoten, stu.Gioitinh, stu.Diachi, stu.DienThoai);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TblKhachHang obj = new TblKhachHang();
            obj.MaKh = txtMaKH.Text;
            obj.Hoten = txtHoTen.Text;
            obj.Gioitinh = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            obj.Diachi = txtDiaChi.Text;
            obj.DienThoai = txtDienThoai.Text;

            _repos.AddKhachHang(obj);
            LoadGidKH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa thông tin");
                return;
            }

            TblKhachHang obj = new TblKhachHang
            {
                MaKh = txtMaKH.Text,
                Hoten = txtHoTen.Text,
                Gioitinh = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "",
                Diachi = txtDiaChi.Text,
                DienThoai = txtDienThoai.Text
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
            //Kiểm tra xem người dùng đã chọn hàng hợp lệ
            if(e.RowIndex >= 0)
            {
                //Lấy thông tin từ hàng được chọn
                var row = dataGridView1.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                // Cập nhật giá trị cho comboBox1
                string gioiTinh = row.Cells[2].Value.ToString();
                comboBox1.SelectedItem = gioiTinh; // Cố gắng tìm và chọn giá trị trong ComboBox
                if (comboBox1.Items.Contains(gioiTinh) == false)
                {
                    comboBox1.SelectedIndex = 1; // Nếu không tìm thấy, không chọn gì
                }
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtDienThoai.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = _repos.GetTblKhachHangs().FirstOrDefault(kh => kh.MaKh == dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _repos.DeleteKhachHang(obj);
            LoadGidKH();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần tìm");
                return;
            }

            // Tìm khách hàng theo mã
            var khachHang = _repos.GetTblKhachHangs().FirstOrDefault(kh => kh.MaKh == maKH);

            if (khachHang != null)
            {
                // Hiển thị thông tin khách hàng tìm thấy trên DataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(khachHang.MaKh, khachHang.Hoten, khachHang.Gioitinh, khachHang.Diachi, khachHang.DienThoai);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với mã này");
                LoadGidKH(); // Hiển thị lại danh sách khách hàng nếu không tìm thấy
            }
        }
    }
}
