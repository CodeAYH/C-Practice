using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19장
{
    class SideTask2
    {
        int count;
        public SideTask2(int count)
        { this.count = count; }

        public void KeepAlive()
        {
            try
            {
                Thread.SpinWait(10000000);
                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("COunt 0");
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resource");
            }
        }
    }
    internal class InterruptingThread
    {
        static void MainInterruptingThread()
        {
            SideTask2 task = new SideTask2(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            t1.Start();

            Thread.Sleep(100);

            t1.Interrupt();

            t1.Join();
        }
    }
}
