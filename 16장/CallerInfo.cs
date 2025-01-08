using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _16장
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file="",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member= "")
        {
            Console.WriteLine($"{file} : {line} : {member} : {message}");
        }
    }
    internal class CallerInfo
    {
        static void MainCallerInfo()
        {
            Console.WriteLine("즐거운 프로그래밍!");
        }
    }
}