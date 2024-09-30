using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XauKyTu_Bai2_Ktra1ChuoiCoMatTrongChuoiKhacKhong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Kiểm tra chuổi con trong C#");
            Console.WriteLine("----------------------------");

            string str = "Chuỗi con trong C#";
            if (str.Contains("trong"))
            {
                Console.WriteLine("Tìm thấy chuỗi con 'trong'");
            }
            else
            {
                Console.WriteLine("Không tìm thấy chuỗi con 'trong'");


            }
            Console.ReadKey();
        }
    }
}
