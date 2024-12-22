using System;

namespace FlowControl;


internal class IfElse
{
    static void MainifElse(string[] args)
    {
        Console.WriteLine("숫자를 입력하세요: ");

        string input = Console.ReadLine();
        int number = Int32.Parse(input);

        if (number < 0)
        {
            Console.WriteLine("-");
        }
        else if (number > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("0");
        }

        if (number % 2 == 0)
        {
            Console.WriteLine("짞수");
        }
        else
        {
            Console.WriteLine("홀수");
        }

        if (number > 0)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("0보다 큰 짝수");
            }
            else
            {
                Console.WriteLine("0보다 큰 홀수");
            }
        }
        else
        {
            Console.WriteLine("0보다 작거나 같은 수");
        }
    }
}
