using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hello.Strings
{
    internal class StringModify
    {
        static void MainStringModify()
        {
            WriteLine("ABC".ToLower());
            WriteLine("abc".ToUpper());

            WriteLine("Happy Friday!".Insert(5, "Sunny"));
            WriteLine("I Don't love you".Remove(2, 6));

            WriteLine("No Space".Trim());
            WriteLine(" No Spaces ".TrimStart());
            WriteLine(" No Spaces ".TrimEnd());
        }
    }
}
