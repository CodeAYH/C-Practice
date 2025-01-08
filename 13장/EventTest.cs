using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13장
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(String.Format($"{number} : 짝"));
            }
        }
    }
    internal class EventTest
    {
        static public void Myhandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main()
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(Myhandler);

            for (int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
