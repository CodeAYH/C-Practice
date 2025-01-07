﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06장
{
    internal class SwapByRef
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void MainSwapByRef(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"{x} , {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"{x} , {y}");
        }
    }
}
