using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai5
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
                Console.WriteLine("-------Menu---------");
                Console.WriteLine("1. Nhập vào một xâu kí tự sau đó hiển thị xâu vừa nhập ra màn hình ");
                Console.WriteLine("2. Đếm xem trong xâu có bn chữ thường, bn chữ hoa");
                Console.WriteLine("3. Đếm số từ trong xâu vừa nhập ");
                Console.WriteLine("4. Đếm số phụ âm và nguyên âm trong xâu");
                Console.WriteLine("5. Nhập vào một xâu con và đếm xem số lần xuất hiện của xâu con trong xâu đã nhập ở trên");

                Console.Write("\nMời nhập lựa chọn của bạn : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.NhapXuatXau();
                        Console.WriteLine();
                        break;
                    case 2:
                        service.HoaThuong();
                        Console.WriteLine();
                        break;
                    case 3:
                        service.DemTu();
                        Console.WriteLine();
                        break;
                    case 4:
                        service.NguyenPhuAm();
                        Console.WriteLine();
                        break;
                    case 5:
                        service.DemSoLanXuatHienXauCon();
                        Console.WriteLine();
                        break ;
                }

            } while (choice != 0);

        }
    }
}
