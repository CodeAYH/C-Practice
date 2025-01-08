using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12장
{
    internal class ThrowExpression
    {
        static void MainThrowExpression()
        {
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException();

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                int[] array = new[] { 1, 2, 3 };
                int index = 4;
                int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
