using Lab10_QLThuVien_110824.Context;
using Lab10_QLThuVien_110824.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_QLThuVien_110824.Responsitories
{
    internal class NhanVienRepos
    {
        private DBContext dBContext = new DBContext();
        public List<Nhanvien> GetNhanviens()
        {
            return dBContext.Nhanvien.ToList();
        }
        public bool CheckIfPhoneExists(string phone)
        {
            return dBContext.Nhanvien.Any(nv => nv.DienThoai == phone);
        }

        public bool AddNhanVien(Nhanvien nhanvien)
        {
            if (nhanvien == null)
            {
                return false;
            }
            try
            {

                dBContext.Nhanvien.Add(nhanvien);
                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi (log lỗi, thông báo người dùng, v.v.)
                return false;
            }
        }
       
    }
}
