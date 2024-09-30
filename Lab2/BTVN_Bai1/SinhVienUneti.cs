using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai1
{
    abstract class SinhVienUneti
    {
        protected SinhVienUneti(string hoTen, string nghanh)
        {
            this.hoTen = hoTen;
            this.nghanh = nghanh;
        }

        private string hoTen { get; set; }
        private string nghanh {  get; set; }

        public abstract double getDiem();

        public string getXepLoaiHL()
        {
            double diem = getDiem();
            if(diem >= 8.5) return "Giỏi";
            else if (diem >= 6.5) return "Khá";
            else if (diem >= 5) return "Trung bình";
            else return "Yếu";

        }
        
        public void Xuat()
        {
            Console.WriteLine("Họ tên : "+ hoTen);
            Console.WriteLine("Ngành : "+ nghanh);
            Console.WriteLine("Điểm : "+ getDiem());
            Console.WriteLine("Xếp loại học lực : "+ getXepLoaiHL());
        }
    }
}
