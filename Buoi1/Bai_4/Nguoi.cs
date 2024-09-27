using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Nguoi
    {
        string hoTen;
        string gioiTinh;
        int tuoi;

        public Nguoi()
        {
            
        }

        public Nguoi(string hoTen, string gioiTinh, int tuoi)
        {
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.Tuoi = tuoi;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên : ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập giới tính : ");
            GioiTinh= Console.ReadLine();
            Console.Write("Nhập tuổi : ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Họ tên : {HoTen}");
            Console.WriteLine($"Giới tính : {GioiTinh}");
            Console.WriteLine($"Tuổi : {Tuoi}");
        }
    }
}
