using System;
using System.Text;

namespace Bai3_Mang2Chieu_CongDuongCheoChinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            int[,] arr = new int[50, 50];

            Console.WriteLine("\nNhập ma trận và tính tổng đường chéo chính trong C#");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nhập kích cỡ của ma trận vuông (nhỏ hơn 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra điều kiện về kích thước ma trận
            if (n >= 5 || n <= 0)
            {
                Console.WriteLine("Kích cỡ ma trận phải nhỏ hơn 5 và lớn hơn 0.");
                return;
            }

            Console.WriteLine("\nNhập các phần tử vào ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Phần tử - [{0},{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Tính tổng đường chéo chính
            int tongDuongCheoChinh = 0;
            for (int i = 0; i < n; i++)
            {
                tongDuongCheoChinh += arr[i, i];
            }

            // In ma trận
            Console.WriteLine("\nMa trận nhập vào là:");
            PrintMatrix(arr, n);

            // Hiển thị tổng đường chéo chính
            Console.WriteLine("\nTổng các phần tử trên đường chéo chính của ma trận là: {0}", tongDuongCheoChinh);

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
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
