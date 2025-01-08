using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12장
{
    internal class Throw
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
            {
                Console.WriteLine(arg);
            }
            else
            {
                throw new Exception("Arg가 10보다 큽니다.");
            }
        }
        static void MainThrow()
        {
            try
            {
                DoSomething(1);
                DoSomething(3);
                DoSomething(5);
                DoSomething(11);
                DoSomething(113);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
