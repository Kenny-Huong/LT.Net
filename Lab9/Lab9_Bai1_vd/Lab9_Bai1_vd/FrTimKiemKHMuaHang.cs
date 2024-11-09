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
    public partial class FrTimKiemKHMuaHang : Form
    {
        BanHangResponsitories _repos = new BanHangResponsitories();
        public FrTimKiemKHMuaHang()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadGidKH(txtMaKH.Text);

        }

        public void LoadGidKH(string txtNoiDung)
        {
            dataGridView1.Rows.Clear(); // Xóa các hàng trước khi tải lại dữ liệu

            // Lấy khách hàng theo mã
            var khachHang = _repos.GetKhachHangById(txtNoiDung);

            if (khachHang != null)
            {
               
              
                txtTenKH.Text = khachHang.Hoten;
                // Lặp qua các đơn hàng và chi tiết bán hàng để hiển thị (nếu có)
                foreach (var banHang in khachHang.TblBanHang)
                {
                    var ngayMua = banHang.NgayMuaBan;
                    foreach (var chiTiet in banHang.TblChiTietBanHang)
                    {
                        // Lấy tên mặt hàng từ MaMhNavigation
                        var tenMatHang = chiTiet.MaMhNavigation?.TenMh; // Giả sử TenMatHang là thuộc tính của TblMatHang

                        // Ví dụ, bạn có thể thêm thông tin chi tiết bán hàng vào DataGridView
                        dataGridView1.Rows.Add(chiTiet.SoHieuHd,ngayMua, tenMatHang, chiTiet.SoLuong, chiTiet.DonGia);
                    }
                }
            }
        }
    }
}
