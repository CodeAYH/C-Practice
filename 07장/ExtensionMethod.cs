using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07장
{
    public static class IntegerExtension
    {
        public  static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
            {
                result = result * myInt;
            }
            return result;

        }
    }
    internal class ExtensionMethod
    {
        static void MaiExtensionMethod()
        {
            Console.WriteLine(3.Square());
            Console.WriteLine(3.Power(4));
            Console.WriteLine(2.Power(10));
        }
    }
}
