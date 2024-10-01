using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2
{
    internal class Service
    {
        List<Student> listST = new List<Student>();

        public void creatList()
        {
            int n;
            Console.Write("\nNhập số lượng sinh viên cần thêm : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var student = new Student();
                student.Nhap();
                listST.Add(student);
            }


        }

        public void watchList()
        {
            Console.WriteLine("");
            foreach (var item in listST)
            {
                item.Xuat();
            }
        }

        public void findST()
        {
            Console.Write("\nNhập tên sinh viên muốn tìm : ");
            string findName = Console.ReadLine();

            var findSV = listST.Where(sv => sv.Name == findName).ToList();
            findSV[0].Xuat();
        }
    }
}
