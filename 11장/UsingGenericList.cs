using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11장
{
    internal class UsingGenericList
    {
        static void Main()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (int ele in list)
                Console.Write($"{ele}");
            Console.WriteLine();

            list.RemoveAt(2);
            foreach (int ele in list)
                Console.Write(ele);
            Console.WriteLine();

            list.Insert(2, 2);
            foreach (int ele in list)
                Console.Write(ele);
            Console.WriteLine();
        }
    }
}
