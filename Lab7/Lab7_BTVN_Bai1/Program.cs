using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BTVN_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập tên file (bao gồm đường dẫn nếu cần): ");
            string fileName = Console.ReadLine();

            try
            {
                // Kiểm tra xem file có tồn tại không
                if (File.Exists(fileName))
                {
                    // Đọc nội dung file
                    string content = File.ReadAllText(fileName);
                    Console.WriteLine("Nội dung file:");
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine("File không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }

            // Dừng lại trước khi thoát
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
