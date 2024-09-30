using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XauKyTu_Bai1_KT2Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("So sánh chuỗi trong C#");
            Console.WriteLine("-----------------------");

            string str1 = "So sánh chuỗi trong C#";
            string str2 = "So sánh chuỗi trong Csharp";

            if(String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " và " + str2 + " là giống nhau");
            }
            else
            {
                Console.WriteLine(str1 + " và " + str2 + " không giống nhau");
            }

            Console.ReadKey();
        }
    }
}
