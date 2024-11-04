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
                // vì một hóa đơn có thể mua được nhiều mặt hàng
                //nên kiểm tra hóa đơn đã được tạo hay chưa
                if (_context.TblBanHang.FirstOrDefault(e => e.SoHieuHd == banHang.SoHieuHd)==null) 
                {
                    _context.TblBanHang.Add(banHang);
                    _context.SaveChanges();
                }
                //nếu tạo rồi thì bỏ qua không phải tạo mới cho bảng tblBanHang nữa
               
                ctBanHang.SoHieuHd = banHang.SoHieuHd;
                if(_context.TblChiTietBanHang.FirstOrDefault(e => e.SoHieuHd == banHang.SoHieuHd && e.MaMh == ctBanHang.MaMh) != null)
                {
                    MessageBox.Show("Vui lòng cập nhập số lượng mặt hàng muốn mua trong hóa đơn!");
                    return false;
                }        
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
        public List<TblChiTietBanHang> ListMatHang(int SoHieuHoaDon)
        {
            var lstMH = _context.TblChiTietBanHang.Where(e => e.SoHieuHd == SoHieuHoaDon).ToList();
            if (lstMH.Count > 0)
            {
                return lstMH;
            }
            return null;
        }

       
    }
}
