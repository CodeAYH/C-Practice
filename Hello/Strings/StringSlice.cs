﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Hello.Strings
{
    internal class StringSlice
    {
        static void MainStringSlice()
        {
            string greeting = "Good morning";

            WriteLine(greeting.Substring(0, 5));
            WriteLine(greeting.Substring(5));
            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            WriteLine(arr.Length);

            foreach (string element in arr)
            {
                WriteLine(element);
            }

        }
    }
}