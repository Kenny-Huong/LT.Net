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

        static void Menu()
        {
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();

            int choice;
            do
            {
                Console.WriteLine("------------Menu----------");
                Console.WriteLine("1. Thêm Sinh viên");
                Console.WriteLine("2. Xuất Danh Sách Sinh Viên");
                Console.WriteLine("3. Sửa Thông Tin Sinh Viên");
                Console.WriteLine("4. Xóa Sinh Viên");
                Console.WriteLine("5. Danh Sách Sinh Viên Thuộc Lớp Học Nhập Từ Bàn Phím");

                Console.WriteLine();
                Console.Write("Nhập lựa chọn của bạn :");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        quanLySinhVien.ThemSinhVien();
                        break;
                    case 2:
                        quanLySinhVien.XuatDSSV();
                        break;
                    case 3:
                        quanLySinhVien.SuaSinhVien();
                        break;
                    case 4:
                        quanLySinhVien.XoaSV();
                        break;
                    case 5:
                        quanLySinhVien.findLopHoc();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }
    }
}
