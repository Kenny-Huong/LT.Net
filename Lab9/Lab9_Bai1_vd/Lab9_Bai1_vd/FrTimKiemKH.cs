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
    public partial class FrTimKiemKH : Form
    {
        KhachHangResponsitories _repos = new KhachHangResponsitories();
        public FrTimKiemKH()
        {
            InitializeComponent();
            LoadGidKH("null", "null");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string selectedCriteria = "";

            if (rdMaKH.Checked)
            {
                selectedCriteria = "MaKH";
            }
            else if (rdTenKH.Checked)
            {
                selectedCriteria = "TenKH";
            }
            else if (rdSoĐT.Checked)
            {
                selectedCriteria = "SoDT";
            }

            LoadGidKH(txtNoiDung.Text, selectedCriteria);

        }

        public void LoadGidKH(string txtNoiDung, string keyword)
        {
            dataGridView1.Rows.Clear(); // Xóa các hàng trước khi tải lại dữ liệu

            foreach (var stu in _repos.GetKhachHangById(txtNoiDung, keyword))
            {
                dataGridView1.Rows.Add(stu.MaKh, stu.Hoten, stu.Gioitinh, stu.Diachi, stu.DienThoai);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
