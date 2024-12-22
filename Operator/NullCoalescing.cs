using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Operator
{
    internal class NullCoalescing
    {
        static void MainNullCoalescing()
        {
            int? num = null;
            WriteLine(num ?? 0);

            num = 99;
            WriteLine(num ?? 0);

            string str = null;
            WriteLine(str ?? "Default");
            str = "Specific";
            WriteLine(str ?? "Default");
        }
    }
}
