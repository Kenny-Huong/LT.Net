using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Bai2
{
    internal class SinhVien : Nguoi
    {
        private string ma;
        private string hoTen;
        private string queQuan;
        private int khoa;

        public string Ma { get => ma; set => ma = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public int Khoa { get => khoa; set => khoa = value; }

        public SinhVien()
        {
            
        }

        public SinhVien(string ma, string hoTen, string queQuan, int khoa)
        {
            this.ma = ma;
            this.hoTen = hoTen;
            this.queQuan = queQuan;
            this.khoa = khoa;
        }

        

        public void TrangThai()
        {
            Console.Write("Trạng thái : ");
            if(this.khoa < 11)
            {
                Console.WriteLine("Đã tốt nghiệp");
            }else
            {
                Console.WriteLine("Đang theo học");
            }
        }
        public void HienThi()
        {
            Console.WriteLine("Mã sinh viên : "+ this.Ma);
            Console.WriteLine("Họ và tên : "+ this.hoTen);
            Console.WriteLine("Quê quán : "+ this.queQuan);
            Console.WriteLine("Khóa : "+ this.queQuan);
            Console.WriteLine("Khóa : "+ Convert.ToString(this.khoa));
            TrangThai();
        }
    }
}
