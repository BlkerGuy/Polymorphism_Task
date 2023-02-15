using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Polymorphism_Task
{
    internal class Store
    {
        public Product[] Products=new Product[0];


        public void AddProduct(Product products)
        {
            if (products is Drink)
            {
                Drink drink = (Drink)products;

                if (drink.AlcoholPercent<=40)
                {
                    Array.Resize(ref Products, Products.Length + 1);
                    Products[Products.Length - 1] = products ;
                }
                else
                {
                    throw new Exception("AlcoholPercent must be low from 40%");
                }
            }
            else if (products is Dairy )
            {
                Dairy dairy = (Dairy)products;

                    Array.Resize(ref Products, Products.Length + 1);
                    Products[Products.Length - 1] = products;
            }

        }

        public Product[] AlcoholPercentLimit()
        {
            Product[] arrD = new Product[0];
            foreach (var item in Products)
            {
                if (item is Drink)
                {
                    Array.Resize(ref arrD, arrD.Length + 1);
                    arrD[arrD.Length - 1] = (Drink)item; ;
                }
            }
            return arrD;
        }
        public int DairyProductCountLimit()
        {
            byte count = 0;

            foreach (var item in Products)
            {
                if (item is Dairy)
                {
                    count++;
                }
            }
            return count;
        }
        public Product[] GetDrinkProducts()
        {
            Product[] drinPrdct = new Product[0];
            if (drinPrdct!=null)
            {
                foreach (var item in Products)
                {
                    if (item is Drink)
                    {
                        Array.Resize(ref drinPrdct, drinPrdct.Length + 1);
                        drinPrdct[drinPrdct.Length - 1] = item as Drink;
                    }
                }
                return drinPrdct;
            }
            

            return null;
        }

        public Product[] GetDairyProducts()
        {
            Product[] dairyPrdct = new Product[0];
            if (dairyPrdct != null)
            {
                foreach (var item in Products)
                {
                    if (item is Dairy)
                    {
                        Array.Resize(ref dairyPrdct, dairyPrdct.Length + 1);
                        dairyPrdct[dairyPrdct.Length - 1] = item as Dairy;
                    }
                }
                return dairyPrdct;
            }
            return null;
        }

        public bool HasProductByNo(Product no)
        {
                foreach (var item in Products)
                {
                    if (item is Drink )
                    {

                    if (no.No==item.No)
                        {
                            return true;
                        }
                    }
                }
            return false;
        }















    }


}
