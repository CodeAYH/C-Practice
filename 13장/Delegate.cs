﻿namespace _13장
{
    internal class Delegate2
    {
        delegate int MyDelegate(int a, int b);

        class Calculator
        {
            public int Plus(int a, int b)
            {
                return a + b;
            }

            public static int Minus(int a, int b)
            {
                return a - b;
            }
        }
        static void MainDelegate(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(5, 2));
        }
    }
}
