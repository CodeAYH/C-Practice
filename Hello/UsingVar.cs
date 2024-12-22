using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class UsingVar
    {
        static void MainUsingVar()
        {
            var a = 20;
            Console.WriteLine($"Type: {a.GetType()} Value: {a}");

            var b = 3.141122;
            Console.WriteLine($"Type: {b.GetType()} Value: {b}");

            var c = "Hello World";
            Console.WriteLine($"Type: {c.GetType()}, Value: {c}");
            var d = new int[] { 10, 20, 30 };
            Console.Write($"Type: {d.GetType()}, Value: ");
            foreach (var e in d)
            {
                Console.Write($"{e}");
            }
            Console.WriteLine();



        }
    }
}
