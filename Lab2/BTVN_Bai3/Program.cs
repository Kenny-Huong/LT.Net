using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Menu();
            Console.ReadKey();
        }

        static void Menu()
        {
            int choice;
            Service service = new Service();

            do
            {
                Console.WriteLine("-------------Menu-----------");
                Console.WriteLine("1. Nhập một ma trận số thực gồm n hàng, m cột");
                Console.WriteLine("2. Hiển thị ma trận");
                Console.WriteLine("3. Tìm số âm nhỏ nhất của ma trận ");
                Console.WriteLine("4. Sắp xếp từng cột của ma trận theo thứ tự tăng dần ");
                Console.WriteLine("5. Nhập số nguyên dương k, xóa cột thứ k của ma trận nếu có");
                Console.WriteLine("6. Tính trung bình cộng các phần tử có giá trị chẵn trong ma trận");

                Console.Write("\nMời bạn nhập lựa chọn : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("\n");
                        service.InputMaTran();
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        Console.WriteLine("\nIn ma trận:\n");
                        service.OutputMaTran();
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        service.findSoAmMin();
                        break;
                    case 4:
                        Console.WriteLine("\n");
                        service.SortColums();
                        break;
                    case 5:
                        Console.WriteLine("\n");
                        service.RemoveColumn();
                        break;
                    case 6:
                        service.findEvenNumbers();
                        break;
                    case 0: Environment.Exit(0);
                        break;
                }
            }while (choice != 0);
        }
    }
}
