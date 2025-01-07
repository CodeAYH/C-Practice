using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06장;

internal class UsingOut
{
    static void Divide(int a, int b, out int q, out int r)
    {
        q = a / b;
        r = a % b;
    }
    static void MainUsingOut()
    {
        int a = 20;
        int b = 3;

        Divide(a, b, out int c, out int d);
        Console.WriteLine($"{c}, {d}");
            
    }
}
