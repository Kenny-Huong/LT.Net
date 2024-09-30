using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            SinhVien sv1 = new SinhVien();
            sv1.Ma = "21103100115";
            sv1.HoTen = "Nguyễn Văn Hướng";
            sv1.QueQuan = "Bắc Ninh";
            sv1.Khoa = 15;

            sv1.HienThi();
            Console.WriteLine("---------------------");
            Console.WriteLine("Sử dụng phương thức của interface cho ra kết quả");
            Nguoi nguoi = sv1;
            nguoi.HienThi();


            Console.ReadKey();
        }
    }
}
