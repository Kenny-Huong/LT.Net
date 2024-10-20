using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BTVN_Bai5
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public int NamSinh { get; set; }


        public SinhVien(string maSV, string hoTen, string queQuan, int namSinh)
        {
            MaSV = maSV;
            HoTen = hoTen;
            QueQuan = queQuan;
            NamSinh = namSinh;
        }

        

        public virtual void HienThi()
        {
            //Console.WriteLine($"Mã sinh viên : {maSV}");
            //Console.WriteLine($"Họ tên : {hoTen}");
            //Console.WriteLine($"Quên quán  : {queQuan}");
            //Console.WriteLine($"Năm sinh : {namSinh}");
        }
    }
}
