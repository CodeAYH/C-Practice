using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10장
{
    internal class InitializingArray
    {
        static void MainInitializingArray()
        {
            string[] array1 = new string[3] { "hello", "Hello", "Hal" };
            Console.WriteLine("Array1...");
            foreach (string greeting in array1)
            {
                Console.WriteLine(greeting);
            }

            string[] array2 = new string[] { "Hello", "hello" };
            Console.WriteLine("\nArray2...");
            foreach (string greeting in array2)
            {
                Console.WriteLine(greeting);
            }

            string[] array3 = { "Hello", "Hello", "Hal" };
            Console.WriteLine("\nArray3...");
            foreach (string greeting in array3)
            {
                Console.WriteLine(greeting);
            }

        }
    }
}
