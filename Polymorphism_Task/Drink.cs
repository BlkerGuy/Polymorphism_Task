using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Polymorphism_Task
{
    internal class Drink:Product
    {
        static Drink()
        {
            _count = 0;
        }
        public Drink()
        {
            _count++;
            _no = _count;
        }

        //public double AlcoholPercent;
        //public double AlcoholPercent { get; set; }
        public double AlcoholPercent { get; set; }

        static int _count;

        public int Count { get => _count; }


        public override void showInfo()
        {
            Console.WriteLine($"No:{No} - Name:{Name} - Price:{Price} AlcoholPercent:{AlcoholPercent}");
        }

    }
}
