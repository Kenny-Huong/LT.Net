using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //List<VanDongVien> listVDV = new List<VanDongVien>();

            //VanDongVien p = new VanDongVien("Nguyễn Văn Hướng",21,"Vat",51.5f,1.7f);
            //p.Xuat();


            //int n;
            //Console.Write("Nhập số lượng VDV cần điền thông tin : ");
            //n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("\nNhập thông tin VDV thứ "+ i+1); 
            //    var v = new VanDongVien();
            //    v.Nhap();
            //    listVDV.Add(v);
            //}

            //foreach (var v in listVDV)
            //{
            //    v.Xuat();
            //}

            int n;
            Console.Write("Nhập số lượng vdv cần nhập thông tin : ");
            n = Convert.ToInt32(Console.ReadLine());

            VanDongVien[] danhSach = new VanDongVien[n];

            danhSach[1] = new VanDongVien("Nguyễn Quang Thiện", 21, "Bóng chuyền", 55.5f, 1.8f);
            danhSach[1].Xuat();

            //Nhập mảng n VDV
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin cho vdv thứ : "+(i+1));
                danhSach[i] = new VanDongVien();
                danhSach[i].Nhap();
            }

            //Xuất mảng
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin cho vdv thứ : " +(i+1));
                
                danhSach[i].Xuat();
            }

            //Sắp xêp theo cân nặng từ thấp đến cao
            Console.WriteLine("\nXắp sếp danh sách theo cân nặng từ thấp đến cao");
            Console.WriteLine("-------------------------------------------------");
            Array.Sort(danhSach, (vdv1,vdv2)=>vdv1.canNang.CompareTo(vdv2.canNang));
            foreach (var v in danhSach)
            {
                v.Xuat();
            }
            Console.ReadKey();
        }
    }
}
