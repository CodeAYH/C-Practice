﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class UsingOut
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void MainUsingOut()
        {
            int a = 20;
            int b = 3;

            Divide(a, b, out int c, out int d);

        }
    }
}
