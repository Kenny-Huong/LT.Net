using NguyenVanHuong_DHTI15A5HN_05112024.Context;
using NguyenVanHuong_DHTI15A5HN_05112024.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHuong_DHTI15A5HN_05112024.Responsitories
{
    internal class KhachHangRepos
    {
        public List<KhachHang>  GetKhachHangs()
        {
            using (var dbContext = new DBContext())
            {
                return dbContext.KhachHang.ToList();
            }
        }

        public bool AddKhachHang(KhachHang khachHang)
        {
            if (khachHang == null)
            {
                return false;
            }

            try
            {
                using (var dbContext = new DBContext())
                {
                    dbContext.KhachHang.Add(khachHang);
                    dbContext.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi (ví dụ: ghi log hoặc thông báo người dùng)
                return false;
            }
        }
        public bool UpdateKhachHang(KhachHang khachHang)
        {
            if (khachHang == null || string.IsNullOrWhiteSpace(khachHang.MaKh))
            {
                return false;
            }

            try
            {
                using (var dbContext = new DBContext())
                {
                    var existingKH = dbContext.KhachHang.Find(khachHang.MaKh);
                    if (existingKH == null)
                    {
                        return false;
                    }

                    // Cập nhật thông tin khách hàng
                    existingKH.TenKh = khachHang.TenKh;
                    existingKH.GioiTinh = khachHang.GioiTinh;
                    existingKH.DiaChi = khachHang.DiaChi;
                    existingKH.DienThoai = khachHang.DienThoai;

                    dbContext.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi
                return false;
            }
        }
        public bool DeleteKhachHang(KhachHang khachHang)
        {
            if (khachHang == null || string.IsNullOrWhiteSpace(khachHang.MaKh))
            {
                return false;
            }

            try
            {
                using (var dbContext = new DBContext())
                {
                    var existingKH = dbContext.KhachHang.Find(khachHang.MaKh);
                    if (existingKH == null)
                    {
                        return false;
                    }

                    dbContext.KhachHang.Remove(existingKH);
                    dbContext.SaveChanges();
                }
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
