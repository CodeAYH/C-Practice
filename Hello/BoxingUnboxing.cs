using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class BoxingUnboxing
    {
        static void MainBoxingUnboxing()
        {
            int a = 123;
            object b = (object)a;
            int c = (int)b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            double x = 3.1414233;
            object y = x;
            double z = (double)y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
