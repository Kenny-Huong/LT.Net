using Lab9_Bai1_vd.Context;
using Lab9_Bai1_vd.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab9_Bai1_vd.Responsitories
{
    internal class KhachHangResponsitories
    {
        private DBContext dbContext = new DBContext();
        public bool AddKhachHang(TblKhachHang khachHang)
        {
            if (khachHang == null)
            {
                return false;
            }

            try
            {
  
                    dbContext.TblKhachHang.Add(khachHang);
                    dbContext.SaveChanges();
                
                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi (ví dụ: ghi log hoặc thông báo người dùng)
                return false;
            }
        }

        public List<TblKhachHang> GetTblKhachHangs()
        {
           
                return dbContext.TblKhachHang.ToList();
            
        }
        public List<TblKhachHang> GetKhachHangById(string txtNoiDung, string keyWord)
        {
            if(string.IsNullOrEmpty(txtNoiDung))
            {
                return dbContext.TblKhachHang.ToList();
            }
           switch(keyWord)
            {
                case "MaKH":
                    return dbContext.TblKhachHang.Where(kh => kh.MaKh == txtNoiDung).ToList();
                case "TenKH":
                    return dbContext.TblKhachHang.Where(kh => kh.Hoten == txtNoiDung).ToList();
                                   
                case "SoDT":
                    return dbContext.TblKhachHang.Where(kh => kh.DienThoai == txtNoiDung).ToList();
                
                default:
                    return dbContext.TblKhachHang.ToList();

            }

        }

        public bool UpdateKhachHang(TblKhachHang khachHang)
        {
            if (khachHang == null || string.IsNullOrWhiteSpace(khachHang.MaKh))
            {
                return false;
            }

            try
            {
                
                    var existingKH = dbContext.TblKhachHang.Find(khachHang.MaKh);
                    if (existingKH == null)
                    {
                        return false;
                    }

                    // Cập nhật thông tin khách hàng
                    existingKH.Hoten = khachHang.Hoten;
                    existingKH.Gioitinh = khachHang.Gioitinh;
                    existingKH.Diachi = khachHang.Diachi;
                    existingKH.DienThoai = khachHang.DienThoai;

                    dbContext.SaveChanges();
                
                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi
                return false;
            }
        }

        public bool DeleteKhachHang(TblKhachHang khachHang)
        {
            if (khachHang == null || string.IsNullOrWhiteSpace(khachHang.MaKh))
            {
                return false;
            }

            try
            {
               
                    var existingKH = dbContext.TblKhachHang.Find(khachHang.MaKh);
                    if (existingKH == null)
                    {
                        return false;
                    }

                    dbContext.TblKhachHang.Remove(existingKH);
                    dbContext.SaveChanges();
           
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
