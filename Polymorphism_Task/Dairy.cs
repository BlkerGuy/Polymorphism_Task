using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Polymorphism_Task
{
    internal class Dairy:Product
    {
        static Dairy()
        {
            _count = 0;
        }
        public Dairy()
        {
            _count++;
            _no = _count;
        }


        public double FatPercent;
        static int _count;

        

    }
}
