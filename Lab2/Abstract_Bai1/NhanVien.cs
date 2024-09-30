using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bai1
{
    abstract class NhanVien : Nguoi
    {
        public string hoTen;
        public int tuoi;
        public string gioiTinh;
        public string className;

        protected NhanVien()
        {
            
        }
        protected NhanVien(string hoTen, int tuoi, string gioiTinh)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
        }

        public abstract string chucVu();
        public abstract void congViec();

        public void HienThi()
        {
            System.Console.WriteLine("Lớp dẫn xuất '{4}': {0},{1},{2}, {3}",
                this.hoTen, this.tuoi, this.gioiTinh, this.chucVu(), className);
        }
    }
}
