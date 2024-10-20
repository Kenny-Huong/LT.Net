using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BTVN_Bai4
{
    internal class SinhVien
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }

        public override string ToString()
        {
            return $"Họ tên: {HoTen}, Tuổi: {Tuoi}";
        }
    }
}
