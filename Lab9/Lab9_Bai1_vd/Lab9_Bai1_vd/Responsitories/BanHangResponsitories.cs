using Lab9_Bai1_vd.Context;
using Lab9_Bai1_vd.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab9_Bai1_vd.Responsitories
{
    public class BanHangResponsitories
    {
        private DBContext _context;

        

        public BanHangResponsitories()
        {
            _context = new DBContext();
        }

        public bool AddBH(TblBanHang banHang, TblChiTietBanHang ctBanHang)
        {
            if (banHang == null)
            {
                return false;
            }

            try
            {
                _context.TblBanHang.Add(banHang);
                _context.SaveChanges(); 
                ctBanHang.SoHieuHd = banHang.SoHieuHd;
                _context.TblChiTietBanHang.Add(ctBanHang);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (log lỗi, thông báo người dùng, v.v.)
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
                return false;
            }
        }
    }
}
