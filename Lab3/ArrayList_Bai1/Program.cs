using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ví dụ minh họa ArrayList trong C#");
            Console.WriteLine("--------------------------------");
            ArrayList al = new ArrayList();
            Console.WriteLine("\nChèn một vài phần tử vào ArrayList : ");
            al.Add(23);
            al.Add(08);
            al.Add(09);
            al.Add(11);
            al.Add(32);
            al.Add(26);
            Console.WriteLine("\nDung lượng của Arraylist :{0}", al.Capacity);
            Console.WriteLine("Số phần tử trong ArrayList :{0}", al.Count);
            Console.WriteLine("\nHiển thị các phần tử trong Arraylist : ");
            
            foreach (int i in al) Console.WriteLine(i + " ");

            Console.WriteLine();
            Console.WriteLine("\nSắp xếp và hiển thị ArrayList sau khi đã sắp xếp : ");
            al.Sort();
                foreach (int i in al) Console.WriteLine(i+" ");
                Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("====================================");
            Console.WriteLine("Bài 1 : ");
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("damimo");

            foreach (var item in list) Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
