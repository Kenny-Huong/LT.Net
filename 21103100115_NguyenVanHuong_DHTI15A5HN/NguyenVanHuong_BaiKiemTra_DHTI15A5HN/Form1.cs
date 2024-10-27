using NguyenVanHuong_BaiKiemTra_DHTI15A5HN.DomainClass;
using NguyenVanHuong_BaiKiemTra_DHTI15A5HN.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NguyenVanHuong_BaiKiemTra_DHTI15A5HN
{
    public partial class Form1 : Form
    {
        NhanVienRepositories _repos = new NhanVienRepositories();

        
        public Form1()
        {

            InitializeComponent();
            LoadGidNV();
            richTextBox1.ReadOnly = true;
            richTextBox1.Enabled = false;

            dataGridView1.CellClick += dataGridView1_CellContentClick;
            
        }
        public void LoadGidNV()
        {
            int stt = 1;
            Type type = typeof(Employees);
            int slThuocTinh = type.GetProperties().Length;
            dataGridView1.ColumnCount = slThuocTinh;
            
            dataGridView1.Columns[0].Name = "Mã NV";
            dataGridView1.Columns[1].Name = "Họ tên";
            dataGridView1.Columns[2].Name = "Năm sinh";
            dataGridView1.Columns[3].Name = "Giới tính";
            dataGridView1.Columns[4].Name = "Bộ phận";
            dataGridView1.Columns[5].Name = "Chức vụ";
            dataGridView1.Columns[6].Name = "Hợp đồng";
            dataGridView1.Columns[7].Name = "Địa chỉ";
            dataGridView1.Columns[8].Name = "URL img";
            dataGridView1.Rows.Clear();

            foreach (var stu in _repos.GetEmployees())
            {
                dataGridView1.Rows.Add(stu.EmployeeId, stu.FullName, stu.BirthYear, stu.Gender, stu.Department, stu.Position, stu.ContractType, stu.Address, stu.ImgUrl);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = _repos.GetEmployees().FirstOrDefault(em => em.EmployeeId == dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _repos.DeleteEmployee(obj);
            LoadGidNV();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Enabled = true;
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                string employeeInfo = $"Mã NV: {row.Cells[0].Value}\n" +
                                      $"Họ tên: {row.Cells[1].Value}\n" +
                                      $"Năm sinh: {row.Cells[2].Value}\n" +
                                      $"Giới tính: {row.Cells[3].Value}\n" +
                                      $"Bộ phận: {row.Cells[4].Value}\n" +
                                      $"Chức vụ: {row.Cells[5].Value}\n" +
                                      $"Hợp đồng: {row.Cells[6].Value}\n" +
                                      $"Địa chỉ: {row.Cells[7].Value}\n";
                                      

                
                richTextBox1.Text = employeeInfo;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string imgUrl = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            pictureBox1.ImageLocation = imgUrl;
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int currentIndex = dataGridView1.CurrentRow.Index;
                if (currentIndex > 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentIndex - 1].Cells[0];
                    DisplayEmployeeInfo(currentIndex - 1); // Hiển thị thông tin lên richTextBox1
                }
            }

        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int currentIndex = dataGridView1.CurrentRow.Index;
                if (currentIndex < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentIndex + 1].Cells[0];
                    DisplayEmployeeInfo(currentIndex + 1); // Hiển thị thông tin lên richTextBox1
                }
            }
        }
       
        private void DisplayEmployeeInfo(int rowIndex)
        {
            richTextBox1.Enabled = true;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string employeeInfo = $"Mã NV: {row.Cells[0].Value}\n" +
                                  $"Họ tên: {row.Cells[1].Value}\n" +
                                  $"Năm sinh: {row.Cells[2].Value}\n" +
                                  $"Giới tính: {row.Cells[3].Value}\n" +
                                  $"Bộ phận: {row.Cells[4].Value}\n" +
                                  $"Chức vụ: {row.Cells[5].Value}\n" +
                                  $"Hợp đồng: {row.Cells[6].Value}\n" +
                                  $"Địa chỉ: {row.Cells[7].Value}\n";
                                 

            richTextBox1.Text = employeeInfo;

            
            string imgUrl = row.Cells[8].Value?.ToString();
            if (!string.IsNullOrEmpty(imgUrl))
            {
                pictureBox1.ImageLocation = imgUrl;
            }
            else
            {
                pictureBox1.Image = null; 
            }
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            LoadGidNV();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

   
}
