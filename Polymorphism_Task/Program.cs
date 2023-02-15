using System;

namespace Polymorphism_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Products List:");

            Store store = new Store();

            store.AddProduct(new Drink() { AlcoholPercent = 20, Name = "Coca Cola Zero 1L", Price = 1.40 });
            store.AddProduct(new Drink() { AlcoholPercent = 30, Name = "Coca Cola 2L", Price = 2.10 });
            store.AddProduct(new Drink() { AlcoholPercent = 40, Name = "Coca Cola 2L", Price = 2.10 });

            var drinks=store.GetDrinkProducts();
            foreach (var item in drinks)
            {
                item.showInfo();
            }
            Console.WriteLine("================================================================");

            store.AddProduct(new Dairy() { FatPercent = 3.2, Name = "Milla SUD 1L", Price = 2.45 });
            store.AddProduct(new Dairy() { FatPercent = 0.3, Name = "Milla AYRAN 1L", Price = 1.99 });

            var dairies = store.GetDairyProducts();
            foreach (var item in dairies)
            {
                item.showInfo();
            }
            Console.WriteLine("================================================================");

            //store.AlcoholPercentLimit();
            //Console.WriteLine($"Drink products Max PercentAlcohol: /*{/*maxPercentAlchol*/}*/");

            var counDairy=store.DairyProductCountLimit();
            Console.WriteLine($"Dairy products Max Count: {counDairy}");
            Drink drink = new Drink();
            Console.WriteLine("-------------------------------------------------------------------");
            var drnks=store.AlcoholPercentLimit();

           
            }

        }
    }
}
