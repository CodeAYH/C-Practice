using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14장
{
    delegate string Concatenate(string[] args);
    internal class StatementLambda
    {
        static void MainStatementLambda(string[] args)
        {
            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                        result += s;
                    return result;
                };
            Console.WriteLine(concat(args));
        }
    }
}
