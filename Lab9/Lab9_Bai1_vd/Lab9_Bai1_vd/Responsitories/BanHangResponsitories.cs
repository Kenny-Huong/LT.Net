using Lab9_Bai1_vd.Context;
using Lab9_Bai1_vd.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        public TblKhachHang GetKhachHangById(string txtNoiDung)
        {
            //Include sẽ nạp data vào Icollection để lấy dữ liệu mà các Icollection chứa id khách hàng 
            //b1: lấy dữ liệu TblKhachHang
            //b2: join vào bảng TblBanHang thông qua nạp dữ liệu (Include) vào Icollection TblBanHang của bảng TblKhachHang
            //b3: join vào TblChiTietBanHang thông qua Mã hiệu HD, và Include data vào Icollection TblChitietBanHang của bảng TblBanHang
            //b4: join TblMatHang thông qua mã mặt hàng , Include data vào Icollection TblMatHang của bảng TblChiTietBanHang
            var khach = _context.TblKhachHang.Include(c => c.TblBanHang) //lấy cả list banHang thông qua mã kh
                 .ThenInclude(c => c.TblChiTietBanHang)//lấy cả list ctbanhang thông qua số hiệu hđ
                 .ThenInclude(c => c.MaMhNavigation)//chỉ lấy mã mh để tìm tên mặt hàng
                 .FirstOrDefault(kh => kh.MaKh == txtNoiDung);
           if(khach != null)
           {
                return khach;
           }
            else
            {
                return null;
            }


           

        }


    }
}
