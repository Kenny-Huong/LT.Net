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
    public partial class FrTimKiemMH : Form
    {
        MatHangResponsitories _repos = new MatHangResponsitories();
        public FrTimKiemMH()
        {
            InitializeComponent();
            LoadGidMH(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string selectedCriteria = "";

            if (rdMaMH.Checked)
            {
                selectedCriteria = "MaMH";
            }
            else if (rdTenMH.Checked)
            {
                selectedCriteria = "TenKH";
            }


            LoadGidMH(txtNoiDung.Text, selectedCriteria);
        }

        public void LoadGidMH(string txtNoiDung, string keyword)
        {
            dataGridView1.Rows.Clear(); // Xóa các hàng trước khi tải lại dữ liệu

            foreach (var stu in _repos.GetMatHangByID(txtNoiDung, keyword))
            {
                dataGridView1.Rows.Add(stu.MaMh, stu.TenMh, stu.Dvt);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
