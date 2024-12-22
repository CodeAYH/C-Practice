using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class For
    {
        static void MainFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int[] arr = new int[] { 0, 1, 2, 3, 4, 5 };
            foreach (int arr2 in arr)
            {
                Console.WriteLine(arr2);
            }
        }
    }
}
