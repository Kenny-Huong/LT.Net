using Lab10_BTVN_Bai1_new_.Context;
using Lab10_BTVN_Bai1_new_.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_BTVN_Bai1_new_.Responsitories
{
    internal class SinhVienRespo
    {
        private DBContext dBContext = new DBContext();

        public List<TbSinhVien> GetTbSinhViens()
        {
            return dBContext.TbSinhVien.ToList();
        }

        public bool AddSinhVien(TbSinhVien sinhVien)
        {
            if (sinhVien == null)
            {
                return false;
            }
            var lopHoc = dBContext.TbLop.Find(sinhVien.MaLop);
            if (lopHoc == null)
            {
                MessageBox.Show("Mã lớp học không tồn tại!");
                return false;
            }
            
            try
            {

                dBContext.TbSinhVien.Add(sinhVien);
                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi (log lỗi, thông báo người dùng, v.v.)
                return false;
            }
        }

        public bool UpdateSV(TbSinhVien sinhVien)
        {
            if (sinhVien == null || sinhVien.MaSv == 0)
            {
                return false;
            }
            try
            {
                var existingSV = dBContext.TbSinhVien.Find(sinhVien.MaSv);

                if (existingSV == null)
                {
                    return false;  // Không tìm thấy sinh viên, không thể cập nhật
                }

                // Cập nhật thông tin sinh viên
                existingSV.Ten = sinhVien.Ten;
                existingSV.GioiTinh = sinhVien.GioiTinh;
                existingSV.NgaySinh = sinhVien.NgaySinh;
                existingSV.Sdt = sinhVien.Sdt;
                existingSV.DiaChi = sinhVien.DiaChi;
                existingSV.MaCs = sinhVien.MaCs;
                existingSV.MaLop = sinhVien.MaLop;

                dBContext.SaveChanges();  // Lưu thay đổi vào cơ sở dữ liệu

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi, có thể log lỗi nếu cần
                MessageBox.Show($"Có lỗi trong quá trình sửa thông tin sinh viên: {ex.Message}");
                return false;
            }
        }
        public bool DeleteSV(TbSinhVien sinhVien)
        {
            if (sinhVien == null || sinhVien.MaSv == 0)
            {
                return false;
            }

            try
            {

                var existingKH = dBContext.TbSinhVien.Find(sinhVien.MaSv);
                if (existingKH == null)
                {
                    return false;
                }

                dBContext.TbSinhVien.Remove(existingKH);
                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi
                return false;
            }
        }
    }
}
