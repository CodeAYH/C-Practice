﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07장
{
    internal class Tuple
    {
        static void MainTuple()
        {
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1} : {a.Item2}");

            var b = (Name: "박상현", Age: 17);
            Console.WriteLine($"{b.Name} : {b.Age}");

            var (name, age) = b;
            Console.WriteLine($"{name}, {age}");

            var (name2, age2) = ("박문수", 34);
            Console.WriteLine(name2);
            Console.WriteLine(age2);

        }
    }
}
