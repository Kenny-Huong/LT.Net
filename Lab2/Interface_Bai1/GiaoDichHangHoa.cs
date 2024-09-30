using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Bai1
{
    internal class GiaoDichHangHoa : GiaoDich
    {
        private string maHangHoa;
        private string ngay;
        private double soLuong;

        public GiaoDichHangHoa()
        {
            
        }

        public GiaoDichHangHoa(string maHangHoa, string ngay, double soLuong)
        {
            this.maHangHoa = maHangHoa;
            this.ngay = ngay;
            this.soLuong = soLuong;
        }

       
        public void hienThiThongTinGD()
        {
            Console.WriteLine($"Mã hàng hóa : {maHangHoa}");
            Console.WriteLine($"Ngày giao dịch : {ngay}");
            Console.WriteLine($"Số lượng : {soLuong}");
        }

        public double laySoLuong()
        {
            return soLuong;
        }
    }
}
