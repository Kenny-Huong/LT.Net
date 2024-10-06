using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Bai4
{
    internal class Program
    {
        private static  void A()
        {
            for (int i = 0; i < 200; i++)
                Console.WriteLine(" A ");
        }

        private static void B()
        {
            for (int i = 0; i < 200; i++)
                Console.WriteLine(" B ");
        }

        private static void C()
        {
            for (int i = 0; i < 200; i++)
                Console.WriteLine(" C ");
        }
        private static void D()
        {
            for (int i = 0; i < 200; i++)
                Console.WriteLine(" D ");
        }
        static void Main(string[] args)
        {
            Thread Luong1 = new Thread(A);

        }
    }
}
