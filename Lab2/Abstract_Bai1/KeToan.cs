using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bai1
{
    internal class KeToan : NhanVien
    {

        public KeToan()
        {
            this.className = this.GetType().Name;
        }
        public KeToan(string hoTen, int tuoi, string gioiTinh) : base(hoTen, tuoi, gioiTinh)
        {
        }

        public override string chucVu()
        {
            return "Kế toán";
        }

        public override void congViec()
        {
            Console.WriteLine("Kiểm kê ngân sách, chi thu");
        }
    }
}
