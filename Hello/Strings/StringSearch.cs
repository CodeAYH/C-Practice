using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hello.Strings
{
    internal class StringSearch
    {
        static void MainStringSearch()
        {
            string greeting = "Good Mornings";
            WriteLine(greeting);
            WriteLine();

            // IndexOf
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            // LastIndexOf
            WriteLine(greeting.LastIndexOf("Good"));
            WriteLine(greeting.LastIndexOf('o'));

            // StartsWith
            WriteLine(greeting.StartsWith("Good"));
            WriteLine(greeting.StartsWith('o'));

            // EndsWith
            WriteLine(greeting.EndsWith("Good"));
            WriteLine(greeting.EndsWith("Mornings"));

            // Contains
            WriteLine(greeting.Contains("Evening"));
            WriteLine(greeting.Contains("Morning"));

            // Replace
            WriteLine(greeting.Replace("Morning", "Evening"));
            
        }
    }
}
