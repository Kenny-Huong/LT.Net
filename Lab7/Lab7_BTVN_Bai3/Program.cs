using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BTVN_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập tên file nguồn (bao gồm đường dẫn nếu cần): ");
            string sourceFileName = Console.ReadLine();

            Console.WriteLine("Nhập tên file đích (bao gồm đường dẫn nếu cần): ");
            string destinationFileName = Console.ReadLine();

            try
            {
                // Kiểm tra xem file nguồn có tồn tại không
                if (File.Exists(sourceFileName))
                {
                    // Đọc nội dung file nguồn
                    string content = File.ReadAllText(sourceFileName);

                    // Ghi nội dung vào file đích
                    File.WriteAllText(destinationFileName, content);

                    Console.WriteLine("Nội dung đã được sao chép từ " + sourceFileName + " sang " + destinationFileName);
                }
                else
                {
                    Console.WriteLine("File nguồn không tồn tại.");
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
