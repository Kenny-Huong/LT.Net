using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_vd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            Console.WriteLine("--------Thong Tin Sinh Vien -------");
            Student myStudent = new Student();
            myStudent.LoiChao();
            myStudent.SetAge(21);
            myStudent.ThongBaoTuoi();
            myStudent.GoToClass();

            Console.WriteLine("--------Thong Tin Giang Vien -------");

            Teacher myTeacher = new Teacher();
            myTeacher.LoiChao();
            myTeacher.SetAge(30);
            myTeacher.ThongBaoTuoi();
            myTeacher.GiangDay();


            if (debug)
            {
                Console.ReadLine();
                Console.ReadKey();
            }
        }
    }
}
