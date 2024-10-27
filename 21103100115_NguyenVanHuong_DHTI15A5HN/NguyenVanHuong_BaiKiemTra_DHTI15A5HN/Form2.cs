using NguyenVanHuong_BaiKiemTra_DHTI15A5HN.DomainClass;
using NguyenVanHuong_BaiKiemTra_DHTI15A5HN.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVanHuong_BaiKiemTra_DHTI15A5HN
{
    
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        NhanVienRepositories _repos = new NhanVienRepositories();
        public Form2()
        {
            InitializeComponent();
            comboBoxGioiTinh.Items.Add("Nam");
            comboBoxGioiTinh.Items.Add("Nữ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            txtMaNV.Text = "";
            txtTen.Text = "";
            txtBoPhan.Text = "";
            txtChucVu.Text = "";
            txtHopDong.Text = "";
            txtDiaChi.Text = "";
        }
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            
            Employees obj = new Employees();
            obj.EmployeeId = txtMaNV.Text;
            obj.FullName = txtTen.Text;
            obj.BirthYear = dateTimePicker1.Value;
            obj.Gender = comboBoxGioiTinh.SelectedItem?.ToString();
            obj.Department = txtBoPhan.Text;
            obj.Position = txtChucVu.Text;
            obj.Address = txtDiaChi.Text;
            obj.ImgUrl = filePath;

            _repos.AddEmployee(obj);

            form1.LoadGidNV();
            Clear();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.EmployeeId = txtMaNV.Text;
            obj.FullName = txtTen.Text;
            obj.BirthYear = dateTimePicker1.Value;
            obj.Gender = comboBoxGioiTinh.SelectedItem?.ToString();
            obj.Department = txtBoPhan.Text;
            obj.Position = txtChucVu.Text;
            obj.Address = txtDiaChi.Text;

            _repos.AddEmployee(obj);
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public string filePath;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // Đường dẫn khởi động
                openFileDialog.Filter = "Image files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*"; // Bộ lọc file
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file đã chọn
                    filePath = openFileDialog.FileName;

                    // Gán đường dẫn vào PictureBox để hiển thị hình ảnh
                    pictureBox1.ImageLocation = filePath; // Hoặc pictureBox1.Image = Image.FromFile(filePath);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
