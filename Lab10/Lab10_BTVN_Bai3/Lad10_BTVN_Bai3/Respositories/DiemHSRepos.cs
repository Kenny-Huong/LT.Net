using Lad10_BTVN_Bai3.Context;
using Lad10_BTVN_Bai3.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lad10_BTVN_Bai3.Respositories
{
    internal class DiemHSRepos
    {
        private DBContext dBContext = new DBContext();

        public List<TbDiemHocSinh> GetTbDiemHocSinhs()
        {
            return dBContext.TbDiemHocSinh.ToList();
        }
        public bool AddHangHoa(TbDiemHocSinh tbDiemHocSinh)
        {
            if (tbDiemHocSinh == null)
            {
                return false;
            }
            try
            {

                dBContext.TbDiemHocSinh.Add(tbDiemHocSinh );
                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Xử lý lỗi (ví dụ: ghi log hoặc thông báo người dùng)
                return false;
            }
        }
        public bool Delete(TbDiemHocSinh tbDiemHocSinh)
        {
            if (tbDiemHocSinh == null || string.IsNullOrWhiteSpace(tbDiemHocSinh.MaHocSinh))
            {
                return false;
            }
            try
            {
                var findHH = dBContext.TbDiemHocSinh.Find(tbDiemHocSinh.MaHocSinh);
                if (findHH == null)
                {
                    return false;
                }

                dBContext.TbDiemHocSinh.Remove(findHH);
                dBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
