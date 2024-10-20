using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1_VD_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\nChương trình ghi file trong C#");
            Console.WriteLine("--------------------------------\n");

            // Mở file để ghi thêm nội dung (append)
            StreamWriter myFile = File.AppendText("file.txt");

            string line;
            string previousLine = null;

            do
            {
                Console.WriteLine("Nhập một câu text (Nhấn Enter hai lần liên tiếp để kết thúc): ");
                line = Console.ReadLine();

                // Kiểm tra nếu người dùng nhấn Enter hai lần liên tiếp
                if (string.IsNullOrEmpty(line) && string.IsNullOrEmpty(previousLine))
                {
                    break; // Thoát khỏi vòng lặp nếu nhấn Enter hai lần liên tiếp
                }


                if (!string.IsNullOrEmpty(line))
                {
                    myFile.WriteLine(line);
                }


                previousLine = line;

            } while (true);


            myFile.Close();
            Console.WriteLine("Nội dung đã được lưu vào file.txt");

            Console.ReadKey();
        }
    }
}
