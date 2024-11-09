using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhSachKhachHang_1_Form_1
{
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            
        }

        void goiDuLieu()
        {
            ListViewItem lvi_1 = new ListViewItem();
            lvi_1.Text = "KH_2024_0035";
            lvi_1.SubItems.Add("Nguyễn Văn An");
            lvi_1.SubItems.Add("Nam");
            lvi_1.SubItems.Add("Số 123, Ngõ 14, Tam Trinh");
            lvi_1.SubItems.Add("0912345678");

            lv_DSKhachHang.Items.Add(lvi_1);
        }

        private void btn_GoiDuLieu_Click(object sender, EventArgs e)
        {
            goiDuLieu();
        }
    }
}
