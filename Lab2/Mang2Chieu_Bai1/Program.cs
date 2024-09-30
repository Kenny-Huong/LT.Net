using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang2Chieu_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3,3];
            Console.WriteLine("\nĐọc và in mảng 2 chiều trong c#: ");

            Console.WriteLine("Nhập các phần tử vào mảng hai chiều:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Phần tử - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nIn mảng hai chiều : ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0}\t", arr1[i, j]);
                }
                Console.WriteLine("\n\n");
                Console.ReadKey();
            }
        }
    }
}
