using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BTVN_Bau2
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

                    // Tách các từ và đếm
                    string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    int wordCount = words.Length;

                    Console.WriteLine("Số từ trong file: " + wordCount);
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
