using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BTVN_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();
            string filePath = "danhSachSinhVien.bin";

            // Nhập danh sách sinh viên
            Console.WriteLine("Nhập vào số lượng sinh viên: ");
            int soLuong = int.Parse(Console.ReadLine());

            for (int i = 0; i < soLuong; i++)
            {
                SinhVien sinhVien = new SinhVien();
                Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");

                Console.Write("Họ tên: ");
                sinhVien.HoTen = Console.ReadLine();

                Console.Write("Tuổi: ");
                sinhVien.Tuoi = int.Parse(Console.ReadLine());

                danhSachSinhVien.Add(sinhVien);
            }

            // Lưu danh sách sinh viên vào tệp nhị phân
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, danhSachSinhVien);
            }

            // Hiển thị danh sách sinh viên từ tệp nhị phân
            Console.WriteLine("\nDanh sách sinh viên từ tệp nhị phân:");
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<SinhVien> sinhVienList = (List<SinhVien>)formatter.Deserialize(fs);
                foreach (var sv in sinhVienList)
                {
                    Console.WriteLine(sv);
                }
            }

            // Dừng lại trước khi thoát
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
