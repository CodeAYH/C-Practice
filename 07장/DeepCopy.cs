using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07장
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newClass = new();
            newClass.MyField1 = this.MyField1;
            newClass.MyField2 = this.MyField2;
            return newClass;
        }
    }
    internal class DeepCopy
    {
        static void MainDeepCopy()
        {
            Console.WriteLine("Shallow COpy");

            {
                MyClass source = new();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} : {target.MyField1}");
                Console.WriteLine($"{source.MyField2} : {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;
                Console.WriteLine($"{source.MyField1} : {target.MyField1}");
                Console.WriteLine($"{source.MyField2} : {target.MyField2}");
            }
        }
    }
}
