using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Menu();
            Console.ReadKey();

        }

        static void Menu()
        {
            Service service = new Service();
            int choice;

            do
            {
                Console.WriteLine("-----------Menu-----------");
                Console.WriteLine("1. Tạo danh sách học sinh");
                Console.WriteLine("2. Sửa thông tin của một học sinh");
                Console.WriteLine("3. Xóa thông tin của 1 học sinh theo tên");
                Console.WriteLine("4. Đưa ra những học sinh có quê quán ở Nam Định");
                Console.WriteLine("5. Đưa ra những học sinh có điểm tổng kết cao nhất");
                Console.WriteLine("0. Thoát chương trình !!!!!!!!!!!!!\n");
               

                Console.Write("Vui lòng chọn chức năng : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1: service.creatList();
                        Console.Clear();
                        break;
                    case 2: service.editSV();
                        break;
                    case 3: service.deleteSV();
                        break;
                    case 4: service.findND(); 
                        break;
                    case 5: service.findMaxScore();
                        break;
                    case 0: Environment.Exit(0);
                        break;

                    default: Console.WriteLine("Mời bạn nhập lại");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
