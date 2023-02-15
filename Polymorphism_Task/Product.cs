using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Task
{
    internal abstract class Product
    {

        public int No { get => _no; }

       

        protected int _no = 0;
        public string Name;
        public double Price;

        public virtual void showInfo()
        {
            Console.WriteLine($"No:{No} - Name:{Name} - Price:{Price}");
        }
    }
}
