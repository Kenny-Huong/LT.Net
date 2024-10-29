using Lab9_Bai1_vd.Context;
using Lab9_Bai1_vd.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab9_Bai1_vd.Responsitories
{
    internal class MatHangResponsitories
    {
        public bool AddMatHang(TblMatHang matHang)
        {
            if (matHang == null)
            {
                return false;
            }

            try
            {
                using (var dbContext = new DBContext())
                {
                    dbContext.TblMatHang.Add(matHang);
                    dbContext.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi (log lỗi, thông báo người dùng, v.v.)
                return false;
            }
        }

        public List<TblMatHang> GetTblMatHangs()
        {
            using (var dbContext = new DBContext())
            {
                return dbContext.TblMatHang.ToList();
            }
        }

        public bool DeleteMatHang(TblMatHang matHang)
        {
            if (matHang == null || string.IsNullOrWhiteSpace(matHang.MaMh))
            {
                return false;
            }

            try
            {
                using (var dbContext = new DBContext())
                {
                    dbContext.TblMatHang.Remove(matHang);
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

        public bool Update(TblMatHang matHang)
        {
            if (matHang == null || string.IsNullOrWhiteSpace(matHang.MaMh))
            {
                return false;
            }

            try
            {
                using (var dbContext = new DBContext())
                {
                    var existingMH = dbContext.TblMatHang.Find(matHang.MaMh);
                    if (existingMH == null)
                    {
                        return false;
                    }

                    // Cập nhật thông tin mặt hàng, không cần thay đổi MaMh
                    existingMH.TenMh = matHang.TenMh;
                    existingMH.Dvt = matHang.Dvt;

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
