using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai4
{
    internal class QuanLySinhVien : SinhVien
    {
        ArrayList listSV = new ArrayList();
        
        public void ThemSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool maTrung;

            do
            {
                maTrung = false; // Giả định rằng mã không trùng

                Console.Write("Nhập mã sinh viên : ");
                sv.MaSV = Console.ReadLine(); 

                // Kiểm tra mã sinh viên đã tồn tại chưa
                foreach (SinhVien item in listSV)
                {
                    if (item.MaSV == sv.MaSV)
                    {
                        Console.WriteLine("Mã sinh viên đã tồn tại, vui lòng nhập mã khác.");
                        maTrung = true; // Đánh dấu rằng mã đã trùng
                        break; // Thoát khỏi vòng lặp kiểm tra
                    }
                }
            } while (maTrung); // Lặp lại nếu mã trùng

            Console.Write("Nhập họ tên : ");
            sv.HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh : ");
            sv.NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập địa chỉ : ");
            sv.DiaChi = Console.ReadLine();
            Console.Write("Nhập lớp học : ");
            sv.LopHoc = Console.ReadLine();

            listSV.Add(sv);
            Console.WriteLine("Thêm sinh viên thành công !");
        }

        

        public void XuatDSSV()
        {
            Console.WriteLine("\nDanh sách sinh viên đã nhập");

            foreach (SinhVien item in listSV)
            {
                Console.WriteLine($"Mã SV : {item.MaSV} \nHọ tên : {item.HoTen}" +
                    $" \nNăm sinh : {item.NamSinh} \nĐịa chỉ : {item.DiaChi} \nLớp học : {item.LopHoc}");

                Console.WriteLine("<------------------->");
            }
            Console.WriteLine();
        }

        public void SuaSinhVien()
        {
            Console.Write("Nhập mã sinh viên bạn muốn sửa : ");
            string maSV = Console.ReadLine();
            SinhVien svSua = null;

            foreach (SinhVien item in listSV)
            {
                if(item.MaSV == maSV)
                {
                    svSua = item;
                    break;
                }
            }

            if(svSua != null)
            {

                // Cập nhật thông tin cho sinh viên đã tìm thấy
                Console.Write("Nhập mã sinh viên mới (để giữ nguyên, nhấn Enter): ");
                string maSVMoi = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(maSVMoi))
                    svSua.MaSV = maSVMoi;

                Console.Write("Nhập họ tên mới (để giữ nguyên, nhấn Enter): ");
                string hoTenMoi = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(hoTenMoi))
                    svSua.HoTen = hoTenMoi;

                Console.Write("Nhập năm sinh mới (để giữ nguyên, nhấn Enter): ");
                string namSinhMoi = Console.ReadLine();
                if (int.TryParse(namSinhMoi, out int namSinh))
                    svSua.NamSinh = namSinh;

                Console.Write("Nhập địa chỉ mới (để giữ nguyên, nhấn Enter): ");
                string diaChiMoi = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(diaChiMoi))
                    svSua.DiaChi = diaChiMoi;

                Console.Write("Nhập lớp học mới (để giữ nguyên, nhấn Enter): ");
                string lopHocMoi = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lopHocMoi))
                    svSua.LopHoc = lopHocMoi;

                Console.WriteLine("Sửa thông tin sinh viên thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }


        }
    }
}
