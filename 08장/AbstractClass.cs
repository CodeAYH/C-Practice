using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08장
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA();
    }

    class AbstractDerived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("AbstractDerived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
    internal class AbstractClass
    {
        static void MainAbstractClass()
        {

        }
    }
}
