using System;
using static System.Console;

namespace Program
{
    internal class MainApp
    {
        static void MainMainApp(String[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello, World");
                return;
            }

            WriteLine("Hello, {0}", args[0]);
        }
    }
}