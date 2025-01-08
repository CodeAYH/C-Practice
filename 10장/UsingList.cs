using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10장
{
    internal class UsingList
    {
        static void MainUsingList()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();
            list.Add("abc");
            list.Add("def");

            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();
        }
    }
}
