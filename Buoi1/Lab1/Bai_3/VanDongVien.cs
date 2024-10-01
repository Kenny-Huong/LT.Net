using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class VanDongVien
    {
        public string hoTen;
        public int tuoi;
        public string monThiDau;
        public float canNang;
        public float chieuCao;

        public VanDongVien()
        {
            
        }

        public VanDongVien(string hoTen, int tuoi, string monThiDau, float canNang, float chieuCao)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.monThiDau = monThiDau;
            this.canNang = canNang;
            this.chieuCao = chieuCao;
        }

        public void Nhap()
        {
            Console.Write("Nhập họ và tên : ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập tuổi : ");
            tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập môn thi đấu : ");
            monThiDau = Console.ReadLine();
            Console.Write("Nhập cân nặng : ");
            canNang = float.Parse(Console.ReadLine());
            Console.Write("Nhập chiều cao : ");
            chieuCao = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            
            Console.WriteLine("Họ tên : {0}", hoTen);
            Console.WriteLine("Tuổi : {0}", tuoi);
            Console.WriteLine("Môn Thi Đấu : {0}", monThiDau);
            Console.WriteLine("Cân nặng : {0}", canNang + "kg");
            Console.WriteLine("Chiều cao : {0}", chieuCao + "m");
        }

        
    }
}
