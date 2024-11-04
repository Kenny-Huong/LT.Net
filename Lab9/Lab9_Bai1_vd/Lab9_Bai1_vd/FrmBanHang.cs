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
    public partial class FrmBanHang : Form
    {
        BanHangResponsitories _repos = new BanHangResponsitories();
        
        public FrmBanHang()
        {
            InitializeComponent();
           
           
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var banHang = new TblBanHang();
            var ctBanHang = new TblChiTietBanHang();
            if (!string.IsNullOrWhiteSpace(txtMaKH.Text) &&
            !string.IsNullOrWhiteSpace(txtDonGia.Text) &&
            !string.IsNullOrWhiteSpace(txtSHHD.Text) &&
            !string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                banHang.SoHieuHd = Convert.ToInt32(txtSHHD.Text);
                banHang.MaKh = txtMaKH.Text;
                banHang.NgayMuaBan = dateTimePicker1.Value;

                ctBanHang.SoHieuHd = Convert.ToInt32(txtSHHD.Text);
                ctBanHang.MaMh = txtMaMH.Text;
                ctBanHang.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                ctBanHang.DonGia = Convert.ToInt32(txtDonGia.Text); 
            }
            else
            {
                LoadGidBH(Convert.ToInt32(txtSHHD.Text));
                return;
            }



            bool isAdded = _repos.AddBH(banHang, ctBanHang);
            if (isAdded)
            {
                MessageBox.Show("Thêm mớithành công");
                LoadGidBH(banHang.SoHieuHd);
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm . Có thể mã đã tồn tại.");
            }
        }
        public void LoadGidBH(int SoHieuHoaDon)
        {
            dataGridView1.Rows.Clear(); // Xóa các hàng trước khi tải lại dữ liệu

            int stt = 1;
            //List<TblChiTietBanHang> lst = null;
            //if (txtSHHD.Text != null)
            //{
            //    lst = _repos.ListMatHang(SoHieuHoaDon);
            //}

            foreach (var stu in _repos.ListMatHang(SoHieuHoaDon))
            {
                double sum = (stu.SoLuong ?? 0) * (stu.DonGia ?? 0);
                dataGridView1.Rows.Add(stt, stu.MaMh, stu.SoLuong, stu.DonGia, sum);
                stt++;
            }
        }
    }
}
