using Lab10_BTVN_Bai4.DomainClass;
using Lab10_BTVN_Bai4.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_BTVN_Bai4
{
    public partial class Form1 : Form
    {
        CongToRepos _repos = new CongToRepos();
        public Form1()
        {
            InitializeComponent();
            LoadGid();
        }

        public void LoadGid()
        {
            dataGridView1.Rows.Clear();

            
            foreach(var stu in _repos.GetTbCongTos())
            {
                int? soTieuThu = stu.SoMoi - stu.SoCu;
                int? thanhTien = soTieuThu * stu.DonGia;
                dataGridView1.Rows.Add(stu.MaCongTo, stu.TenChuHo, stu.SoCu, stu.SoMoi, soTieuThu, thanhTien);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoCongTo.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtSoCu.Text) ||
                string.IsNullOrWhiteSpace(txtSoMoi.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm.");
                return;
            }
            int soMoi;
            int soCu;
            int donGia;
            if(!int.TryParse(txtSoMoi.Text, out soMoi))
            {
                MessageBox.Show("Vui long nhập số mới công tơ hợp lệ");
            }
            if (!int.TryParse(txtSoCu.Text, out soCu))
            {
                MessageBox.Show("Vui long nhập số cũ công tơ hợp lệ");
            }
            if (!int.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Vui long nhập đơn giá hợp lệ");
            }
            var congTo = new TbCongTo
            {
                MaCongTo = txtSoCongTo.Text,
                TenChuHo = txtTen.Text,
                SoCu = soCu,
                SoMoi = soMoi,
                DonGia = donGia
            };

            bool isAdded = _repos.Add(congTo);
            if (isAdded)
            {
                MessageBox.Show("Thêm mới mã công tơ thành công");
                LoadGid();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm mã công tơ. Có thể mã đã tồn tại.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoCongTo.Text))
            {
                MessageBox.Show("Vui lòng chọn mã công tơ để sửa thông tin.");
                return;
            }
            int soMoi;
            int soCu;
            int donGia;
            if (!int.TryParse(txtSoMoi.Text, out soMoi))
            {
                MessageBox.Show("Vui long nhập số mới công tơ hợp lệ");
            }
            if (!int.TryParse(txtSoCu.Text, out soCu))
            {
                MessageBox.Show("Vui long nhập số cũ công tơ hợp lệ");
            }
            if (!int.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Vui long nhập đơn giá hợp lệ");
            }


            var obj = new TbCongTo
            {
                MaCongTo = txtSoCongTo.Text,
                TenChuHo = txtTen.Text,
                SoCu = soCu,
                SoMoi = soMoi,
                DonGia = donGia

            };

            bool result = _repos.Update(obj);
            if (result)
            {
                MessageBox.Show("Sửa thông tin thành công");
                LoadGid();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình sửa thông tin .");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtSoCongTo.Text = row.Cells[0].Value?.ToString();
                txtTen.Text = row.Cells[1].Value?.ToString();
                txtSoCu.Text = row.Cells[2].Value?.ToString();
                txtSoMoi.Text = row.Cells[3].Value?.ToString();
                if (row.Cells[4].Value != null && row.Cells[5].Value != null && Convert.ToInt32(row.Cells[4].Value) != 0)
                {
                    // Lấy giá trị từ cột 5 và cột 4
                    int col5Value = Convert.ToInt32(row.Cells[5].Value);
                    int col4Value = Convert.ToInt32(row.Cells[4].Value);

                    // Thực hiện phép chia và gán vào txtDonGia.Text
                    txtDonGia.Text = (col5Value / (double)col4Value).ToString();
                }
                else
                {
                    // Xử lý trường hợp giá trị không hợp lệ
                    txtDonGia.Text = "N/A";
                }

            }
        }
    }
}
