using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class SinhVien
    {
        public string name;
        public string queQuan;
        public int namSinh;
        public double tongKet;

        public SinhVien()
        {
                
        }

        public SinhVien(string name, string queQuan, int namSinh, double tongKet)
        {
            this.name = name;
            this.queQuan = queQuan;
            this.namSinh = namSinh;
            this.tongKet = tongKet;
        }

        public void Nhap()
        {
            Console.Write("Nhập họ tên : "); 
            name = Console.ReadLine();
            Console.Write("Nhập quê quán : ");
            queQuan = Console.ReadLine();
            Console.Write("Nhập năm sinh : ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm tổng kết : ");
            tongKet = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Họ tên : {0}", name);
            Console.WriteLine("Quê quán : {0}", queQuan);
            Console.WriteLine("Năm sinh : {0}", namSinh);
            Console.WriteLine("Tổng kết : {0}", tongKet);
        }


    }
}
