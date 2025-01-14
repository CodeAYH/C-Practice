﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price: {price}");
        }
    }
    internal class RefReturn
    {

        static void MainRefReturn()
        {
            Product carrot = new();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine(ref_local_price);
            Console.WriteLine(normal_local_price);

            ref_local_price = 200;
            carrot.PrintPrice();
            Console.WriteLine(ref_local_price);
            Console.WriteLine(normal_local_price);
        }
    }
}
