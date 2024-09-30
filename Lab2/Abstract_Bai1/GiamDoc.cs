using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bai1
{
    internal class GiamDoc : NhanVien
    {
        public GiamDoc()
        {
            this.className = this.GetType().Name;
        }
        public GiamDoc(string hoTen, int tuoi, string gioiTinh) : base(hoTen, tuoi, gioiTinh)
        {
        }

        public override string chucVu()
        {
            return "Giám đốc";
        }

        public override void congViec()
        {
            Console.WriteLine("Ban hành quyết định, chỉ ra đường lối chiến lược kinh doanh");
        }
    }
}
