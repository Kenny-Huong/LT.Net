using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Free");
            list.Add("Education");

            Console.WriteLine("List ban đầu : ");
            Console.WriteLine("Số phần tử trog List là : {0}", list.Count);
            
            foreach (string item in list)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine();
            list.Insert(0, "HowKteam");

            Console.WriteLine("List sau khi insert : ");
            Console.WriteLine("Số phần tử trog List là : {0}", list.Count);

            foreach(string item in list)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine();
            bool isExists = list.Contains("Ktem")
                if(isExists == false)
            {
                Console.WriteLine("Không tìm thấy chuỗi Kteam trong list");
            }
        }
    }
}
