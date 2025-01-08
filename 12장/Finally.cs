using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12장
{
    internal class Finally
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide Error");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() end");
            }
        }

        static void MainFinally()
        {
            try
            {
                Console.Write("제수 입력");
                String temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.Write("피제수 입력");
                int divisor = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program Down");
            }
        }
    }
}
