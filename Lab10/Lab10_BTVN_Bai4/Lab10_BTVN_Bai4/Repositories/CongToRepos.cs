using Lab10_BTVN_Bai4.Context;
using Lab10_BTVN_Bai4.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_BTVN_Bai4.Repositories
{
    internal class CongToRepos
    {
        private DBContext dBContext = new DBContext();

        public List<TbCongTo> GetTbCongTos()
        {
            return dBContext.TbCongTo.ToList();
        }

        public bool Add(TbCongTo congTo)
        {
            if (congTo == null)
            {
                return false;
            }
            try
            {

                dBContext.TbCongTo.Add(congTo);
                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi (ví dụ: ghi log hoặc thông báo người dùng)
                return false;
            }
        }
        public bool Update(TbCongTo tbCongTo)
        {
            if (tbCongTo == null || string.IsNullOrWhiteSpace(tbCongTo.MaCongTo))
            {
                return false;
            }
            try
            {

                var existingMH = dBContext.TbCongTo.Find(tbCongTo.MaCongTo);
                if (existingMH == null)
                {
                    return false;
                }

                // Cập nhật thông tin mặt hàng, không cần thay đổi MaMh
                existingMH.TenChuHo = tbCongTo.TenChuHo;
                existingMH.SoCu = tbCongTo.SoCu;
                existingMH.SoMoi = tbCongTo.SoMoi;
                existingMH.DonGia = tbCongTo.DonGia;

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
