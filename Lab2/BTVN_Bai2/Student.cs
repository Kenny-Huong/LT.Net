using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2
{
    internal class Student : Person
    {
        private string name;
        private int age;
        private string nativePlace;
        private String id;

        public Student()
        {
            
        }
        public Student(string name, int age, string nativePlace, string id)
        {
            this.name = name;
            this.age = age;
            this.nativePlace = nativePlace;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string NativePlace { get => nativePlace; set => nativePlace = value; }
        public string Id { get => id; set => id = value; }

        public void Nhap()
        {
            Console.Write("Nhập tên : ");
            name = Console.ReadLine();
            Console.Write("Nhập tuổi : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập quê quán : ");
            nativePlace = Console.ReadLine();
            Console.Write("Nhập id : ");
            id = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"Tên : {name}");
            Console.WriteLine($"Tuổi : {age}");
            Console.WriteLine($"Quê quán : {nativePlace}");
            Console.WriteLine($"Id : {id}");
        }
    }
}
