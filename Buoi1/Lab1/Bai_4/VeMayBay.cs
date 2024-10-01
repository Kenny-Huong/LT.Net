using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class VeMayBay
    {
        private string tenChuyenBay;
        private DateTime ngayBay;
        private double giaVe;

        public VeMayBay()
        {
            
        }

        public VeMayBay(string tenChuyenBay, DateTime ngayBay, double giaVe)
        {
            this.TenChuyenBay = tenChuyenBay;
            this.NgayBay = ngayBay;
            this.GiaVe = giaVe;
        }

        public string TenChuyenBay { get => tenChuyenBay; set => tenChuyenBay = value; }
        public DateTime NgayBay { get => ngayBay; set => ngayBay = value; }
        public double GiaVe { get => giaVe; set => giaVe = value; }

        public void Nhap()
        {
            Console.Write("Nhập tên chuyến bay: ");
            tenChuyenBay = Console.ReadLine();

            bool validDate = false;
            while (!validDate)
            {
                Console.Write("Nhập ngày bay (dd/MM/yyyy): ");
                string input = Console.ReadLine();
                validDate = DateTime.TryParse(input, out ngayBay);

                if (!validDate)
                {
                    Console.WriteLine("Ngày nhập không hợp lệ. Vui lòng nhập lại.");
                }
            }

            Console.Write("Nhập giá vé: ");
            giaVe = Convert.ToDouble(Console.ReadLine());
        }


        public void Xuat()
        {
            Console.WriteLine($"Tên chuyến bay : {tenChuyenBay}");
            Console.WriteLine($"Ngày bay : {ngayBay}");
            Console.WriteLine($"Gía vé : {giaVe}");
        }
    }
}
