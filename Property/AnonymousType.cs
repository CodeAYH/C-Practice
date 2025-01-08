using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09장
{
    internal class AnonymousType
    {
        static void MainAnonymousType()
        {
            var a = new { Name = "박상현", Age = 1223 };
            Console.WriteLine($"{a.Name} : {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.WriteLine($"Subject: {b.Subject} , Scores: ");
            foreach (var score in b.Scores)
            {
                Console.Write($"{score}");
            }
            Console.WriteLine();
        }
    }
}
