using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10장
{
    internal class ArraySample2
    {
        static void MainArraySample2()
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 80;
            scores[2] = 80;
            scores[^2] = 80;
            scores[^1] = 80;
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            int sum = 0;

        }
    }
}
