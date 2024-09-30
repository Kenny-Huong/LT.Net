using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2
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
            Service service = new Service();
            int choice;

            do
            {
                Console.WriteLine("-------------Menu-------------");
                Console.WriteLine("1. Tạo danh sách sinh viên");
                Console.WriteLine("2. In ra màn hình danh sách sinh viên");
                Console.WriteLine("3. Tìm sinh viên theo tên");


                Console.Write("\nVui lòng chọn chức năng :");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1: service.creatList(); break;
                    case 2: service.watchList(); break;
                    case 3: service.findST(); break;

                }
            } while (choice != 0);

        }
    }

}


