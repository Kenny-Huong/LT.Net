using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BTVN_Bai5
{
    internal class SinhVienKhoa : SinhVien
    {
        public double DiemKyThuat { get; set; }
        public double DiemCNC { get; set; }

        public SinhVienKhoa(string maSV, string hoTen, string queQuan, int namSinh, double diemKyThuat, double diemCNC)
            : base(maSV, hoTen, queQuan, namSinh)
        {
            DiemKyThuat = diemKyThuat;
            DiemCNC = diemCNC;
        }

        public override void HienThi()
        {
            // Hiển thị thông tin sinh viên khoa, bao gồm cả điểm kỹ thuật và điểm CNC
        }
    }
}
