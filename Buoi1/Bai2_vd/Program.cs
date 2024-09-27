using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_vd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Box box1 = new Box();
            Box box2 = new Box();
            double TheTich = 0;

            box1.chieuCao = 6;
            box1.chieuRong = 5;
            box1.chieuDai = 7;

            box2.chieuCao = 10;
            box2.chieuRong = 11;
            box2.chieuDai = 12;

            TheTich = box1.chieuCao * box1.chieuDai * box1.chieuRong;
            Console.WriteLine("Thể tích của Box1 là {0}: ", TheTich);

            TheTich = box2.chieuCao * box2.chieuDai * box2.chieuRong;
            Console.WriteLine("Thể tích của Box1 là {0}: ", TheTich);

            Console.ReadKey();
        }
    }
}
