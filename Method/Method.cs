﻿namespace Method;
class Calculator
{
    public static int Plus(int a, int b)
    {
        return a + b;
    }

    public static int Minus(int a, int b)
    {
        return a - b;
    }
}
internal class Method
{
    
    static void MainMethod(string[] args)
    {
        int result = Calculator.Plus(3, 4);
        Console.WriteLine(result);

        result = Calculator.Minus(5, 2);
        Console.WriteLine(result);
    }
}
