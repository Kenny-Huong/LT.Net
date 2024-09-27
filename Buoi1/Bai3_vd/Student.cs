using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_vd
{
    internal class Student : Person
    {
        public override void LoiChao()
        {
            base.LoiChao();
            Console.Write(" Teacher");
        }
        public void GoToClass()
        {
            Console.WriteLine("I'm going to class");
        }
    }
}
