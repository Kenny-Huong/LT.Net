using System;
using System.Text;

namespace Bai2_Mang2Chieu_Cong2MaTran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] maTranTong = new int[50, 50];

            Console.WriteLine("\nCộng hai ma trận trong C#");
            Console.WriteLine("--------------------------");
            Console.Write("Nhập kích cỡ của hai ma trận vuông (nhỏ hơn 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra điều kiện về kích thước ma trận
            if (n >= 5 || n <= 0)
            {
                Console.WriteLine("Kích cỡ ma trận phải nhỏ hơn 5 và lớn hơn 0.");
                return;
            }

            Console.WriteLine("\nNhập các phần tử vào trong ma trận đầu tiên:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Phần tử - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nNhập các phần tử vào trong ma trận thứ hai:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Phần tử - [{0},{1}]: ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Cộng hai ma trận
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    maTranTong[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            // In các ma trận
            Console.Clear();
            Console.WriteLine("Ma trận thứ nhất:");
            PrintMatrix(arr1, n);

            Console.WriteLine("\nMa trận thứ hai:");
            PrintMatrix(arr2, n);

            Console.WriteLine("\nMa trận tổng của hai ma trận trên là:");
            PrintMatrix(maTranTong, n);

            Console.WriteLine("\n\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }

        // Phương thức để in ma trận
        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
