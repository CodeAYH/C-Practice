using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12장
{
    class FilterableException : Exception
    {
        public int ErrorNo { get; set; }
    }
    internal class ExceptionFiltering
    {
        static void Main()
        {
            Console.WriteLine("Enter Number Between 0-10");
            string input = Console.ReadLine();
            try
            {
                int num = Int32.Parse(input);

                if (num < 0  || num > 10)
                {
                    throw new FilterableException() { ErrorNo = num };
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            catch (FilterableException e) when (e.ErrorNo < 0)
            {
                Console.WriteLine("Negative input is not allowed");
            }
            catch (FilterableException e) when (e.ErrorNo > 10)
            {
                Console.WriteLine("ERRORNO > 10");
            }
        }
    }
}
