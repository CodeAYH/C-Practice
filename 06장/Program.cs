using System;
namespace _06장;

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
internal class Program
{
    
    static void MainProgram(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int result = Calculator.Plus(3, 4);
        Console.WriteLine(result);
        result = Calculator.Minus(5, 1);
        Console.WriteLine(result);
    }
}
