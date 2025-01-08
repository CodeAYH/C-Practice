using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06장
{
    internal class NamedParameters
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"{name}, {phone}");
        }
    }
}
