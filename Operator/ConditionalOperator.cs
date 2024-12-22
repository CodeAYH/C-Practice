using System;

namespace ConditionalOperator;

class MainApp
{
    static void MainConditionalOperator()
    {
        string result = (10 % 2) == 0 ? "짝수" : "홀수";
        Console.WriteLine(result);
    }
}