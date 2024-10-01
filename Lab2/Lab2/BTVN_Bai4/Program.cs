using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai4
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

        public static void Menu()
        {
            int choice;
            Service service = new Service();
            do
            {
                Console.WriteLine("-----------Menu---------");
                Console.WriteLine("1. Nhập một ma trận số thực vuông cấp n(n > 0)");
                Console.WriteLine("2. Hiển thị ma trận");
                Console.WriteLine("3. Tính tổng các phần tử nằm trên đường chéo chính của ma trận");
                Console.WriteLine("4. Tìm số âm lớn nhất trên đường chéo chính của ma trận");
                Console.WriteLine("5. Đếm các phần tử của ma trận có giá trị chia hết cho 3 và 5");
                Console.WriteLine("0. Thoát chương trình\n");

                Console.Write("Mời bạn nhập lựa chọn : "); 
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 0: Environment.Exit(0); break;
                    case 1:
                        service.InputMaTran();
                        break;
                    case 2:
                        Console.WriteLine("In ra ma trận");
                        service.OutputMaTran();
                        Console.WriteLine();
                        break;
                    case 3:
                        service.OutputTongDuongCheoPhu();
                        Console.WriteLine();
                        break;
                    case 4:
                        service.findSoAmMax();
                        Console.WriteLine();
                        break;
                    case 5:
                        service.FindCountChia3Va5();
                        Console.WriteLine();
                        break;

                }

            }while(choice != 0);
        }
    }
}
