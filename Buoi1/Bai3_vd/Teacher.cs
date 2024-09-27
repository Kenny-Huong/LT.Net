using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_vd
{
    internal class Teacher : Person
    {

        public override void LoiChao()
        {
            base.LoiChao();
            Console.Write(" Student");
        }
        public void GiangDay()
        {
            Console.WriteLine("Start Teaching");
        }

       
    }
}
