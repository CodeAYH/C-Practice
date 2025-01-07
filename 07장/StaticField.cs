using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07장
{
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    internal class StaticField
    {
        static void MainStaticField()
        {
            Console.WriteLine(Global.Count);

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();
            Console.WriteLine(Global.Count);

        }
    }
}
