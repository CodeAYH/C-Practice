﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14장
{
    internal class FuncTest
    {
        static void MainFuncTest()
        {
            Func<int> func1 = () => 10;
            Console.WriteLine(func1());

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine(func2(4));

            Func<double, double, double> func3 = (x, y) => x / y;
            Console.WriteLine(func3(22, 7));
        }
    }
}
