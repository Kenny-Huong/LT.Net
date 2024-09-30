using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bai1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            GiamDoc giamDoc = new GiamDoc("Nguyễn Văn Hướng",34,"Nam");
            System.Console.WriteLine("Lớp dẫn xuất 'Giám đốc' : {0},{1},{2},{3}",
            giamDoc.hoTen, giamDoc.tuoi, giamDoc.gioiTinh, giamDoc.chucVu());

            KeToan keToan = new KeToan("Nguyễn Văn Bằng", 21, "Nam");
            System.Console.WriteLine("Lớp dẫn xuất 'Kế toán' : {0},{1},{2},{3}",
            keToan.hoTen, keToan.tuoi, keToan.gioiTinh, keToan.chucVu());

            Console.ReadKey();


        }
    }
}
