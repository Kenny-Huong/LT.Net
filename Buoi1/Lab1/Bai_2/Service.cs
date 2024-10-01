using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    public class Service
    {
        List<SinhVien> listSV = new List<SinhVien>();

        public void creatList()
        {
            int n;
            Console.Write("\nNhập số sinh viên muốn thêm : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var SinhVien = new SinhVien();
                SinhVien.Nhap();
                listSV.Add(SinhVien);
            }

            foreach (var item in listSV)
            {
                item.Xuat();
            }
        }


        public void editSV()
        {
            // Sửa thông tin sinh viên

            Console.Write("\nNhập tên sinh viên muốn tìm : ");
            string findName = Console.ReadLine();
            // Linq query
            var findSV2 = from SV in listSV where SV.name == findName select SV;

            // Linq Method
            var findSV = listSV.Where(sv => sv.name == findName).ToList();
            if(findSV.Count == 1)
            {
                findSV[0].Xuat();
                findSV[0].Nhap();
            }else if(findSV.Count > 1)
            {
                Console.WriteLine("Có nhiều sinh viên tên" + findName);
                int choice;

                do
                {
                    Console.WriteLine("-----------Menu-----------");
                    Console.WriteLine("1. Tìm theo quê quán");
                    Console.WriteLine("2. Tìm theo năm sinh");
                    Console.WriteLine("3. Tìm theo điểm tổng kết");
                    Console.WriteLine("0. Thoát chương trình !!!!!!!!!!!!!\n");


                    Console.Write("Vui lòng chọn chức năng : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Nhập địa chỉ :");
                            string addresName = Console.ReadLine();
                            var findAddress = listSV.FirstOrDefault(sv => sv.name == findName && sv.queQuan == addresName);
                            findAddress.Xuat();
                            findAddress.Nhap();
                            
                            break;
                        case 2:
                            Console.Write("Nhập năm sinh :");
                            int  namSinh = Convert.ToInt32(Console.ReadLine());
                            var findNamSinh = listSV.FirstOrDefault(sv => sv.name == findName && sv.namSinh == namSinh);
                            findNamSinh.Xuat();
                            findNamSinh.Nhap();
                            
                            break;
                        case 3:
                            Console.Write("Nhập điểm tổng kết :");
                            double diemTK = Convert.ToInt32(Console.ReadLine());
                            var findDTK = listSV.FirstOrDefault(sv => sv.name == findName && sv.tongKet == diemTK);
                            findDTK.Xuat();
                            findDTK.Nhap(); 
                            
                            break;
                       
                        

                        default:
                            Console.WriteLine("Mời bạn nhập lại");
                            break;
                    }
                }
                while (choice != 0);
            
            }
            Console.WriteLine("Danh sách sinh viên sau khi sửa");
            foreach (var item in listSV)
            {
                item.Xuat();
            }
            

        }

        public void deleteSV()
        {
            Console.Write("\nNhập tên sinh viên muốn xoá : ");

            string deleteSV = Console.ReadLine();
            var findSVDelete = listSV.FirstOrDefault(sv => sv.name == deleteSV);
            listSV.Remove(findSVDelete);

            Console.WriteLine("\nDanh sách sinh viên sau khi xóa");
            foreach (var item in listSV)
            {
                item.Xuat();
            }
        }

        public void findND()
        {
            Console.Write("\nDanh sách SV ở Nam Định : \n");
            foreach (var item in listSV)
            {
                if (item.queQuan == "Nam Định")
                {
                    item.Xuat();
                }
            }
        }

        public void findMaxScore()
        {
            //Đưa ra sinh viên có điểm tổng kết lớn nhất 

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Sinh Vien Điểm Cao nhất");
            var sortSV = listSV.OrderByDescending(sv => sv.tongKet);
            var maxScoreSV = sortSV.First();
            maxScoreSV.Xuat();

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Những sinh viên lớn nhất điểm tk");
            foreach (var item in listSV)
            {

                if (item.tongKet >= 8)
                {

                    item.Xuat();
                }
            }

            Console.ReadKey();

        }
    }

}
