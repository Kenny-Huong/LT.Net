using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Interface trong C#");
            Console.WriteLine("Ví dụ minh họa InterFace");
            Console.WriteLine("-------------------------");

            GiaoDichHangHoa t1 = new GiaoDichHangHoa("001","08/09/2003",2003);
            GiaoDichHangHoa t2 = new GiaoDichHangHoa("002","08/10/2003",23213);

            t1.hienThiThongTinGD();
            t2.hienThiThongTinGD();

            Console.ReadKey();
        }
    }
}
