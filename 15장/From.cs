﻿using System.Runtime.CompilerServices;

namespace _15장
{
    internal class From
    {
        static void MainFrom(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;
            foreach (int n in result)
                Console.WriteLine(n);
        }
    }
}
