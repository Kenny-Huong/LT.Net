using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            SinhVienCNTT sv = new SinhVienCNTT("Nguyễn Văn Hướng ", "Công nghệ thông tin", 7.5);
            sv.Xuat();

            Console.ReadKey();
        }
    }
}
