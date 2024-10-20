using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7_BTVN_Bai5
{
    public partial class Form1 : Form
    {
        private List<SinhVienKhoa> danhSachSinhVien = new List<SinhVienKhoa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromFile(); // Nạp dữ liệu khi form mở
        }

        private void LoadDataFromFile()
        {
            string filePath = "SVCK.data";
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        string maSV = parts[0];
                        string hoTen = parts[1];
                        string queQuan = parts[2];
                        int namSinh = int.Parse(parts[3]);
                        double diemKyThuat = double.Parse(parts[4]);
                        double diemCNC = double.Parse(parts[5]);

                        SinhVienKhoa svKhoa = new SinhVienKhoa(maSV, hoTen, queQuan, namSinh, diemKyThuat, diemCNC);
                        danhSachSinhVien.Add(svKhoa);
                    }
                }
                HienThiDanhSachSinhVien(); // Gọi phương thức để hiển thị dữ liệu trong ListView
            }
        }

        private void HienThiDanhSachSinhVien()
        {
            listView1.Items.Clear();
            
            foreach (var sv in danhSachSinhVien)
            {
                ListViewItem item = new ListViewItem(sv.MaSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.QueQuan);
                item.SubItems.Add(sv.NamSinh.ToString());
                item.SubItems.Add(sv.DiemKyThuat.ToString());
                item.SubItems.Add(sv.DiemCNC.ToString());

                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Đóng chương trình
        }

        private void listView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện click vào ListView (nếu cần)
        }
        private void EnableTextBoxes()
        {
            txtMaSV.Enabled = true;
            txtHoTen.Enabled = true;
            txtQueQuan.Enabled = true;
            txtNamSinh.Enabled = true;
            txtDiemKyThuat.Enabled = true;
            txtDiemCNC.Enabled = true;
        }

        private void DisableTextBoxes()
        {
            txtMaSV.Enabled = false;
            txtHoTen.Enabled = false;
            txtQueQuan.Enabled = false;
            txtNamSinh.Enabled = false;
            txtDiemKyThuat.Enabled = false;
            txtDiemCNC.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                EnableTextBoxes();  // Kích hoạt các hộp nhập liệu
                btnThem.Text = "Lưu"; // Đổi tên nút thành "Lưu"
            }
            else if (btnThem.Text == "Lưu")
            {
                // Lấy thông tin từ các hộp nhập liệu
                string maSV = txtMaSV.Text;
                string hoTen = txtHoTen.Text;
                string queQuan = txtQueQuan.Text;
                int namSinh = int.Parse(txtNamSinh.Text);
                double diemKyThuat = double.Parse(txtDiemKyThuat.Text);
                double diemCNC = double.Parse(txtDiemCNC.Text);

                // Tạo đối tượng sinh viên mới và thêm vào danh sách
                SinhVienKhoa newSV = new SinhVienKhoa(maSV, hoTen, queQuan, namSinh, diemKyThuat, diemCNC);
                danhSachSinhVien.Add(newSV);
                HienThiDanhSachSinhVien();

                // Lưu sinh viên mới vào tệp
                using (StreamWriter sw = new StreamWriter("SVCK.data", true))
                {
                    sw.WriteLine($"{maSV};{hoTen};{queQuan};{namSinh};{diemKyThuat};{diemCNC}");
                }

                DisableTextBoxes(); // Vô hiệu hóa các hộp nhập liệu sau khi lưu
                btnThem.Text = "Thêm"; // Đổi tên nút lại thành "Thêm"
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin sinh viên đã nhập đủ chưa
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtQueQuan.Text) ||
                string.IsNullOrWhiteSpace(txtNamSinh.Text) ||
                string.IsNullOrWhiteSpace(txtDiemKyThuat.Text) ||
                string.IsNullOrWhiteSpace(txtDiemCNC.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.", "Thông báo");
                return;
            }

            // Nếu đủ thông tin, thêm sinh viên mới
            if (btnThem.Text == "Thêm")
            {
                SinhVienKhoa sv = new SinhVienKhoa(
                    txtMaSV.Text,
                    txtHoTen.Text,
                    txtQueQuan.Text,
                    int.Parse(txtNamSinh.Text),
                    double.Parse(txtDiemKyThuat.Text),
                    double.Parse(txtDiemCNC.Text)
                );
                danhSachSinhVien.Add(sv);
                HienThiDanhSachSinhVien();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
            }
            else if (btnThem.Text == "Lưu")
            {
                // Cập nhật thông tin sinh viên đã chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[1].Text = txtHoTen.Text;
                selectedItem.SubItems[2].Text = txtQueQuan.Text;
                selectedItem.SubItems[3].Text = txtNamSinh.Text;
                selectedItem.SubItems[4].Text = txtDiemKyThuat.Text;
                selectedItem.SubItems[5].Text = txtDiemCNC.Text;

                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo");
                btnThem.Text = "Thêm"; // Sau khi cập nhật thì đổi nút Lưu về Thêm
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Hiển thị thông tin sinh viên đã chọn lên các textbox
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtMaSV.Text = selectedItem.SubItems[0].Text;
                txtHoTen.Text = selectedItem.SubItems[1].Text;
                txtQueQuan.Text = selectedItem.SubItems[2].Text;
                txtNamSinh.Text = selectedItem.SubItems[3].Text;
                txtDiemKyThuat.Text = selectedItem.SubItems[4].Text;
                txtDiemCNC.Text = selectedItem.SubItems[5].Text;

                // Kích hoạt lại các textbox để sửa
                EnableTextBoxes();
                btnThem.Text = "Lưu"; // Đổi tên nút thành "Lưu" để cập nhật
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Xóa sinh viên khỏi danh sách và cập nhật ListView
                    int selectedIndex = listView1.SelectedIndices[0];
                    danhSachSinhVien.RemoveAt(selectedIndex);
                    listView1.Items.RemoveAt(selectedIndex);
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                // Hiển thị thông tin sinh viên đã chọn lên các TextBox
                txtMaSV.Text = selectedItem.SubItems[0].Text;
                txtHoTen.Text = selectedItem.SubItems[1].Text;
                txtQueQuan.Text = selectedItem.SubItems[2].Text;
                txtNamSinh.Text = selectedItem.SubItems[3].Text;
                txtDiemKyThuat.Text = selectedItem.SubItems[4].Text;
                txtDiemCNC.Text = selectedItem.SubItems[5].Text;

                EnableTextBoxes();
                btnThem.Text = "Cập nhật"; // Đổi nút thành "Cập nhật"
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa.", "Thông báo");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Cập nhật thông tin sinh viên
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[1].Text = txtHoTen.Text;
                selectedItem.SubItems[2].Text = txtQueQuan.Text;
                selectedItem.SubItems[3].Text = txtNamSinh.Text;
                selectedItem.SubItems[4].Text = txtDiemKyThuat.Text;
                selectedItem.SubItems[5].Text = txtDiemCNC.Text;

                // Cập nhật thông tin sinh viên trong danh sách
                SinhVienKhoa sv = danhSachSinhVien.FirstOrDefault(s => s.MaSV == selectedItem.SubItems[0].Text);
                if (sv != null)
                {
                    sv.HoTen = txtHoTen.Text;
                    sv.QueQuan = txtQueQuan.Text;
                    sv.NamSinh = int.Parse(txtNamSinh.Text);
                    sv.DiemKyThuat = double.Parse(txtDiemKyThuat.Text);
                    sv.DiemCNC = double.Parse(txtDiemCNC.Text);
                }

                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo");

                // Vô hiệu hóa các TextBox và đưa nút về trạng thái ban đầu
                DisableTextBoxes();
                btnThem.Text = "Thêm"; // Đổi nút về trạng thái ban đầu
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để cập nhật.", "Thông báo");
            }
        }


        private void btnSinhVienTruot_Click(object sender, EventArgs e)
        {
            // Xóa các mục hiện có trong ListView
            listView1.Items.Clear();

            // Duyệt qua danh sách sinh viên và hiển thị những sinh viên có điểm nhỏ hơn 5
            foreach (var sv in danhSachSinhVien)
            {
                if (sv.DiemKyThuat < 5 || sv.DiemCNC < 5)
                {
                    ListViewItem item = new ListViewItem(sv.MaSV);
                    item.SubItems.Add(sv.HoTen);
                    item.SubItems.Add(sv.QueQuan);
                    item.SubItems.Add(sv.NamSinh.ToString());
                    item.SubItems.Add(sv.DiemKyThuat.ToString());
                    item.SubItems.Add(sv.DiemCNC.ToString());

                    listView1.Items.Add(item);
                }
            }
        }

        private void LuuDataToFile()
        {
            string filePath = "SVCK.data";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var sv in danhSachSinhVien)
                {
                    string line = $"{sv.MaSV};{sv.HoTen};{sv.QueQuan};{sv.NamSinh};{sv.DiemKyThuat};{sv.DiemCNC}";
                    sw.WriteLine(line);
                }
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var sv in danhSachSinhVien)
            {
                double diemTrungBinh = (sv.DiemKyThuat + sv.DiemCNC) / 2;
                if (diemTrungBinh < 5)
                {
                    ListViewItem item = new ListViewItem(sv.MaSV);
                    item.SubItems.Add(sv.HoTen);
                    item.SubItems.Add(sv.QueQuan);
                    item.SubItems.Add(sv.NamSinh.ToString());
                    item.SubItems.Add(sv.DiemKyThuat.ToString());
                    item.SubItems.Add(sv.DiemCNC.ToString());
                    item.SubItems.Add(diemTrungBinh.ToString());

                    listView1.Items.Add(item);
                }
            }
        }
    }
}
