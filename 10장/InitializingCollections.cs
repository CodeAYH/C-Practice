using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10장
{
    internal class InitializingCollections
    {
        static void MainInitializingCollections()
        {
            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
