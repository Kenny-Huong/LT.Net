using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai5
{
    internal class Service
    {
        string chuoi;
        public void NhapXuatXau()
        {

            Console.Write("Nhập xâu kí tự : ");
            chuoi = Console.ReadLine();

            Console.WriteLine("\nIn xâu kí tự");
            Console.WriteLine($"Chuỗi vừa nhập là : {chuoi}");
        }

        public void HoaThuong()
        {
            int upperCount = 0;
            int lowerCount = 0;

            foreach (char item in chuoi)
            {
                if (char.IsUpper(item))
                {
                    upperCount++;
                }
                else if (char.IsLower(item))
                {
                    lowerCount++;
                }
            }

            Console.WriteLine($"Có {upperCount} kí tự in hoa trong chuỗi");
            Console.WriteLine($"Có {lowerCount} kí tự in thường trong chuỗi");
        }

        public void DemTu()
        {
            if (string.IsNullOrEmpty(chuoi))
            {
                Console.WriteLine("Chuỗi bạn nhập không chứa từ nào ");
            }
            else
            {
                //Tách chuỗi thành các từ, sử dụng khoảng trắng để phân tách
                string[] words = chuoi.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int wordCount = words.Length;
                Console.WriteLine($"In lại xâu {chuoi}");

                Console.WriteLine($"Số lượng từ trong xâu là {wordCount}");
            }
        }

        public void NguyenPhuAm()
        {
            int nguyenAmCount = 0;
            int phuAmCount = 0;

            //Các kí tự nguyên âm 
            char[] nguyenAm = { 'u', 'e', 'o', 'a', 'i', 'U', 'I', 'E', 'O', 'A' };

            foreach (char item in chuoi)
            {
                if (char.IsLetter(item))
                {
                    //Kiểm tra nếu kí tự là nguyên âm
                    if (Array.Exists(nguyenAm, element => element == item))
                    {
                        nguyenAmCount++;
                    }
                    else
                    {
                        phuAmCount++;
                    }
                }
            }
            
            Console.WriteLine();
            Console.WriteLine($"Số lượng nguyên âm trong xâu : {nguyenAmCount}");
            Console.WriteLine($"Số lượng phụ âm trong xâu : {phuAmCount}");
        }

        public void DemSoLanXuatHienXauCon()
        {
            if (string.IsNullOrEmpty(chuoi))
            {
                Console.WriteLine("Chuỗi chưa được nhập. Vui lòng nhập chuỗi trước.");
                return;
            }

            Console.Write("Nhập chuỗi con: ");
            string xauCon = Console.ReadLine();

            int count = 0;
            int index = chuoi.IndexOf(xauCon);

            while (index != -1)
            {
                count++;
                // Tìm tiếp chuỗi con sau vị trí đã tìm được
                index = chuoi.IndexOf(xauCon, index + xauCon.Length);
            }

            if (count > 0)
            {
                Console.WriteLine($"Chuỗi con '{xauCon}' xuất hiện {count} lần trong chuỗi chính.");
            }
            else
            {
                Console.WriteLine($"Chuỗi con '{xauCon}' không xuất hiện trong chuỗi chính.");
            }
        }

    }
}

