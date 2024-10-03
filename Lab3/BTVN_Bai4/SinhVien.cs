using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai4
{
    internal class SinhVien
    {
        private string maSV;
        private string hoTen;
        private int namSinh;
        private string diaChi;
        private string lopHoc;

        public SinhVien()
        {
            
        }

        public SinhVien(string maSV, string hoTen, int namSinh, string diaChi, string lopHoc)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
            this.lopHoc = lopHoc;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string LopHoc { get => lopHoc; set => lopHoc = value; }
    }
}
