using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07장
{
    class MyClass2
    {
        int a, b, c;

        public MyClass2()
        {
            this.a = 5424;
            Console.WriteLine("MyClass()");
        }

        public MyClass2(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass2(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}, {c})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"{a}, {b}, {c}");
        }

    }
    internal class ThisConstructor
    {
        static void MainThisConstructor()
        {

        }
    }
}
