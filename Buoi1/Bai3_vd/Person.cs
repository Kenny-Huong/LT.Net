using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_vd
{
    internal class Person
    {
        private int age;

    
        public virtual void LoiChao()
        {
            Console.Write("Hello");
        }
        

        public void SetAge(int n)
        {
            age = n;
        }

        public virtual void ThongBaoTuoi()
        {
            Console.WriteLine("\nMy age is " + age);
        }
    }
}
