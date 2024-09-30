using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai1
{
    internal class SinhVienCNTT : SinhVienUneti
    {
        private double diem;

        public SinhVienCNTT(string hoTen, string nghanh, double diem) : base(hoTen, nghanh)
        {
            this.diem = diem;
        }

        public override double getDiem()
        {
            return diem;
        }


    }
}
