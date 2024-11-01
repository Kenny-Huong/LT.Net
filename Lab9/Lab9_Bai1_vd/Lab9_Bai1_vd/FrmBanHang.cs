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
           
            LoadGidBH();
        }
        public void LoadGidBH()
        {
            dataGridView1.Rows.Clear(); // Xóa các hàng trước khi tải lại dữ liệu

            //int stt = 1;

            //foreach (var stu in _repos.AddBH())
            //{
            //    double sum = (stu.SoLuong ?? 0) * (stu.DonGia ?? 0);
            //    dataGridView1.Rows.Add(stt, stu.MaMh, stu.SoLuong, stu.DonGia, sum);
            //    stt++;
            //}
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            var banHang = new TblBanHang
            {
                SoHieuHd = Convert.ToInt32(txtSHHD.Text),
                MaKh = txtMaKH.Text

               
            };
            var ctBanHang = new TblChiTietBanHang
            {
                SoHieuHd = Convert.ToInt32(txtSHHD.Text),
                MaMh = txtMaMH.Text
            };

            bool isAdded = _repos.AddBH(banHang, ctBanHang);
            if (isAdded)
            {
                MessageBox.Show("Thêm mớithành công");
                LoadGidBH();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm . Có thể mã đã tồn tại.");
            }
        }
    }
}
