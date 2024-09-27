using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_vd
{
    internal class SinhVienIT : SinhVien
    {
        public SinhVienIT(string ma, string hoten, string quequan, int khoa) : base(ma, hoten, quequan, khoa)
        {
        }

        public new void HienThi()
        {
            Console.WriteLine("Sinh viên IT");
            base.HienThi();
        }
    }
}
