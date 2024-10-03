namespace Bai1_vd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            long s = 0;
            for (int i = 1; i <= n; i++) s += i;
            txtTong.Text = s.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
