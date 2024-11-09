using Lad10_BTVN_Bai3.DomainClass;
using Lad10_BTVN_Bai3.Respositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lad10_BTVN_Bai3
{
    public partial class Form1 : Form
    {
        private DiemHSRepos _repos = new DiemHSRepos();
        public Form1()
        {
            InitializeComponent();
            LoadGid();
        }
        public void LoadGid()
        {
            dataGridView1.Rows.Clear();

            foreach(var stu in _repos.GetTbDiemHocSinhs())
            {
                 dataGridView1.Rows.Add(stu.MaHocSinh, stu.HoTen, stu.DiemToan, stu.DiemViet);
            }

            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHS.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiemToan.Text) ||
                string.IsNullOrWhiteSpace(txtDiemViet.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm.");
                return;
            }
            float diemToan;
            float diemViet;
            if (!float.TryParse(txtDiemToan.Text, out diemToan))
            {
                MessageBox.Show("Điểm Toán phải là 1 số thực");
            }
            if (!float.TryParse(txtDiemViet.Text, out diemViet))
            {
                MessageBox.Show("Điểm Viết phải là 1 số thực");
            }

            var matHang = new TbDiemHocSinh
            {
                MaHocSinh = txtMaHS.Text,
                HoTen = txtHoTen.Text,
                DiemToan = diemToan,
                DiemViet = diemViet
            };

            bool isAdded = _repos.AddHangHoa(matHang);
            if (isAdded)
            {
                MessageBox.Show("Thêm mới thành công");
                LoadGid();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm. Có thể mã đã tồn tại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow  == null)
            {
                MessageBox.Show("Vui lòng chọn 1 mã HS để xóa");
                return;
            }
            var maHS = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            var obj = _repos.GetTbDiemHocSinhs().FirstOrDefault(hh => hh.MaHocSinh == maHS);

            if (obj == null)
            {
                MessageBox.Show("Không tìm thấy mã cần xóa");
            }

            bool isDelete = _repos.Delete(obj);
            if (isDelete)
            {
                MessageBox.Show("Xóathành công");
                LoadGid();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình xóa");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtMaHS.Text = row.Cells[0].Value?.ToString();
                txtHoTen.Text = row.Cells[1].Value?.ToString();
                txtDiemToan.Text = row.Cells[2].Value?.ToString();
                txtDiemViet.Text = row.Cells[3].Value?.ToString();
                
            } 
        }

        private void t(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
