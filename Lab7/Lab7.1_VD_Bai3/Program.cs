using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1_VD_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nChuyển nội dung file thành chữ hoa trong C# : ");
            Console.WriteLine("------------------------------------------------\n");
            Console.Write("Nhập tên file ban đầu : ");
            string fileName = Console.ReadLine();
            Console.Write("Nhập tên file thứ 2 : ");
            string fileName1 = Console.ReadLine();
            if(File.Exists(fileName))
            {
                StreamReader fileRw = File.OpenText(fileName);
                StreamWriter fileWr = File.CreateText(fileName1);
                string line;

                do
                {
                    line = fileRw.ReadLine();
                    if(line != null)
                    {
                        fileWr.WriteLine(line.ToUpper());
                    }
                }while(line != null);
                fileRw.Close();
                fileWr.Close();

                Console.WriteLine("Chuyển đổi thành công và nội dung đã được ghi vào file thứ 2");
            }
            else
            {
                Console.WriteLine("File ban đầu không tông tại");
            }
            Console.ReadKey();
        }
    }
}
