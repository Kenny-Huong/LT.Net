using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            List<VeMayBay> listVeMayBay = new List<VeMayBay>();
            int soVe;
            Console.Write("Nhập số lượng vé muốn thêm : ");
            soVe = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < soVe; i++)
            {
                VeMayBay veNew = new VeMayBay();
                veNew.Nhap();
                listVeMayBay.Add(veNew);
            }

            Console.WriteLine("\nDanh sách vé sau khi thêm !");
            foreach (var item in listVeMayBay)
            {
                item.Xuat();
            }

            List<HanhKhach> listHanhKhach  = new List<HanhKhach>();
            int soHK;
            Console.Write("Nhập số lượng khách hàng muốn thêm : ");
            soHK = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < soHK; i++)
            {   
                HanhKhach hanhKhach = new HanhKhach();
                hanhKhach.Nhap();
                listHanhKhach.Add(hanhKhach);

                int choiceVe;
                Console.Write("Nhập số lượng vé muốn mua : ");
                choiceVe = Convert.ToInt32(Console.ReadLine());

                hanhKhach.Bag = new List<VeMayBay>();
                for (int j = 0; j < choiceVe; j++)
                {
                    string tenCBSearch;
                    Console.Write("Nhập tên chuyến bay :");
                    tenCBSearch = Console.ReadLine();

                    VeMayBay veMBFind = listVeMayBay.Find(v => v.TenChuyenBay == tenCBSearch);
                    if ( veMBFind == null )
                    {
                        Console.WriteLine($"Không có loại vé MB {tenCBSearch} này !");
                        continue;
                    }
                    hanhKhach.Bag.Add(veMBFind);
                }

            }

            Console.WriteLine("\nDanh sách hành khách theo chiều giảm dần của tổng tiền !");
            foreach (var item in listHanhKhach.OrderByDescending(kh => kh.tongTien()))
            {
                item.Xuat();
            }


        }
    }
}
