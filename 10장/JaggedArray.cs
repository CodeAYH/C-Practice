using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10장
{
    internal class JaggedArray
    {
        static void MainJaggedArray()
        {
            int[][] jag = new int[3][];
            jag[0] = [1, 2, 3, 4, 5];
            jag[1] = [10, 20, 30];
            jag[2] = [100, 200];

            foreach (int[] arr in jag)
            {
                Console.Write($"array Length: {arr.Length}");
                foreach (int e in arr)
                {
                    Console.Write(e);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

            int[][] jag2 = new int[2][]
            {
                new int[] {1000, 2000 },
                new int[4] {6, 7, 8, 9 }
            };

            foreach (int[] arr in jag2)
            {
                Console.Write($"Legnth: {arr.Length}");
                foreach (int e in arr)
                {
                    Console.Write(e);
                }
                Console.WriteLine();
            }
        }
    }
}
