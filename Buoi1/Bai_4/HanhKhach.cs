using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class HanhKhach : Nguoi
    {
        List<VeMayBay> bag;

        public HanhKhach()
        {
        }

        public HanhKhach(string hoTen, string gioiTinh, int tuoi, List<VeMayBay> bag = null) : base(hoTen, gioiTinh, tuoi)
        {
            this.Bag = bag;
        }

        internal List<VeMayBay> Bag { get => bag; set => bag = value; }

        public override void Nhap()
        {
            base.Nhap();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số vé khách hàng đặt là : {bag.Count}");
            Console.WriteLine($"Tổng số tiền khách hàng : {tongTien()}");
        }

        public double tongTien()
        {
            double money = 0;
            foreach (VeMayBay item in this.Bag)
            {
                money += item.GiaVe;
            }
            return money;
        }
    }
}
