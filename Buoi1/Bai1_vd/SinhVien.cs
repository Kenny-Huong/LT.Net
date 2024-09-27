using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_vd
{
    internal class SinhVien
    {
        public string ma;
        public string hoten;
        public string quequan;
        public int khoa;
        Encoding utf8 = Encoding.UTF8;

        public SinhVien()
        {

        }
        public SinhVien(string ma, string hoten, string quequan, int khoa)
        {
            ma = this.utf8.GetString(utf8.GetBytes(ma));
            hoten = this.utf8.GetString(utf8.GetBytes(hoten));
            quequan = this.utf8.GetString(utf8.GetBytes(quequan));

            this.ma = ma;
            this.hoten = hoten;
            this.quequan = quequan;
            this.khoa = khoa;

        }

        public string Ma
        {
            get { return this.ma; }
            set { this.ma = value; }
        }

        public string HoTen
        {
            get { return this.hoten; }
            set { this.hoten = value; }
        }

        public string QueQuan
        {
            get { return this.quequan; }
            set { this.quequan = value; }
        }
        public int Khoa
        {
            get { return this.khoa; }
            set { this.khoa = value; }
        }

        public void TrangThai()
        {
            Console.Write("Trạng thái : ");
            if(this.khoa < 11)
            {
                Console.WriteLine("Đã tốt nghiệp");
            }
            else
            {
                Console.WriteLine("Đang theo học");
            }
        }

        public void HienThi()
        {
            Console.WriteLine("Mã sinh viên : " + this.ma);
            Console.WriteLine("Tên : " + this.hoten);
            Console.WriteLine("Quê quán : " + this.quequan);
            Console.WriteLine("Khoa : " + Convert.ToString(this.khoa));
            TrangThai();

        }
    }
}
