using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_vd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            SinhVien sv1 = new SinhVien("21103100115","Nguyễn Văn Hướng","Bắc Ninh",9);
            sv1.HienThi();
            Console.WriteLine();

            SinhVien sv2 = new SinhVien("21103111111", "Nguyễn Trọng Bằng", "Bắc Linh", 12);
            sv2.HienThi();
            Console.WriteLine();

            SinhVienIT sv3 = new SinhVienIT("21103100000", "Nguyễn Văn Ninh", "99", 15);
            sv3.HienThi();
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
