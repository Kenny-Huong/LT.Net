using Lab9_Bai1_vd.Context;
using Lab9_Bai1_vd.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab9_Bai1_vd.Responsitories
{
    internal class MatHangResponsitories
    {
        private DBContext dbContext = new DBContext();
        public bool AddMatHang(TblMatHang matHang)
        {
            if (matHang == null)
            {
                return false;
            }

            try
            {   
                
                    dbContext.TblMatHang.Add(matHang);
                    dbContext.SaveChanges();
                
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
            
                return dbContext.TblMatHang.ToList();
            
        }
        public List<TblMatHang> GetMatHangByID(string txtNoiDung, string keyWord)
        {
            if (string.IsNullOrEmpty(txtNoiDung))
            {
                return dbContext.TblMatHang.ToList();
            }
            switch (keyWord)
            {
                case "MaMH":
                    return dbContext.TblMatHang.Where(mh => mh.MaMh == txtNoiDung).ToList();
                case "TenMH":
                    return dbContext.TblMatHang.Where(mh => mh.TenMh == txtNoiDung).ToList();

           

                default:
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
               
                    dbContext.TblMatHang.Remove(matHang);
                    dbContext.SaveChanges();
                
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
                
                    var existingMH = dbContext.TblMatHang.Find(matHang.MaMh);
                    if (existingMH == null)
                    {
                        return false;
                    }

                    // Cập nhật thông tin mặt hàng, không cần thay đổi MaMh
                    existingMH.TenMh = matHang.TenMh;
                    existingMH.Dvt = matHang.Dvt;

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
