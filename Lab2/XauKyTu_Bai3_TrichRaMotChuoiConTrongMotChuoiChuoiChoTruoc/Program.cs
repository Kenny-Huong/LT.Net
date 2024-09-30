using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XauKyTu_Bai3_TrichRaMotChuoiConTrongMotChuoiChuoiChoTruoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Lấy chuỗi con trong C#");
            Console.WriteLine("----------------------");
            string str = "Lấy chuỗi con trong C#";
            Console.WriteLine("Chuỗi ban đầu : "+ str);
            string substr = str.Substring(10);
            Console.WriteLine("Chuỗi con : "+ substr);
            Console.ReadKey();
        }
    }
}
