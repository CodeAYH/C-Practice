﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06장;

internal class Return
{
    static int Fibonacci(int n)
    {
        if (n < 2)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
    static void PrintProfile(string name, string phone)
    {
        if (name == "")
        {
            Console.WriteLine("Input the Name");
            return;
        }
    }
}
