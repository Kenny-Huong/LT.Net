using Lab10_BTVN_Bai2.Context;
using Lab10_BTVN_Bai2.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_BTVN_Bai2.Repositories
{
    internal class HangHoaRepos
    {
        private DBContext dBContext = new DBContext();

        public List<TbHangHoa> GetTbHangHoas()
        {
            return dBContext.TbHangHoa.ToList();
        }

        public bool AddHangHoa(TbHangHoa hangHoa)
        {
            if (hangHoa == null)
            {
                return false;
            }
            try
            {

                dBContext.TbHangHoa.Add(hangHoa);
                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi (ví dụ: ghi log hoặc thông báo người dùng)
                return false;
            }
        }
        public bool Update(TbHangHoa hangHoa)
        {
            if (hangHoa == null || string.IsNullOrWhiteSpace(hangHoa.MaHang))
            {
                return false;
            }
            try
            {

                var existingMH = dBContext.TbHangHoa.Find(hangHoa.MaHang);
                if (existingMH == null)
                {
                    return false;
                }

                // Cập nhật thông tin mặt hàng, không cần thay đổi MaMh
                existingMH.TenHang = hangHoa.TenHang;
                existingMH.DonVi = hangHoa.DonVi;
                existingMH.DonGia = hangHoa.DonGia;
                existingMH.SoLuong = hangHoa.SoLuong;

                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi
                return false;
            }
        }
        public bool Delete(TbHangHoa hangHoa)
        {
            if(hangHoa == null || string.IsNullOrWhiteSpace(hangHoa.MaHang))
            {
                return false;
            }
            try
            {
                var findHH = dBContext.TbHangHoa.Find(hangHoa.MaHang);
                if(findHH == null)
                {
                    return false;
                }

                dBContext.TbHangHoa.Remove(findHH);
                dBContext.SaveChanges();
                return true;
            }catch (Exception)
            {
                return false;
            }
        }
    }
}
