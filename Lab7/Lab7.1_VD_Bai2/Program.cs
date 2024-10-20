using System;
using System.IO;
using System.Text;

namespace Lab7._1_VD_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            bool debug = true;

            Console.WriteLine("\nĐếm số lần xuất hiện của chữ cái trong file:");
            Console.WriteLine("-------------------------------------\n");

            Console.Write("Nhập tên file: ");
            string nameFile = Console.ReadLine();

            string letter;
            do
            {
                Console.Write("Nhập chữ cái cần đếm (1 ký tự): ");
                letter = Console.ReadLine();
            }
            while (letter.Length != 1); 

            if (!File.Exists(nameFile))
            {
                Console.WriteLine("File không tồn tại. Vui lòng kiểm tra lại tên file.");
                return;
            }

            // Mở file và đếm số lần xuất hiện của chữ cái
            StreamReader myfile = File.OpenText(nameFile);
            string line;
            int countLetter = 0;
            char targetChar = letter[0]; // Chuyển chuỗi thành ký tự

            while ((line = myfile.ReadLine()) != null)
            {
                
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == targetChar)
                    {
                        countLetter++;
                    }
                }
            }

            myfile.Close();
            Console.WriteLine("Số lần xuất hiện của chữ cái '{0}' trong file là: {1}", targetChar, countLetter);

            if (debug) Console.WriteLine();
            Console.ReadKey();
        }
    }
}
