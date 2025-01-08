using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07장
{
    class Base2
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived2 : Base2
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived");
        }
    }
    internal class MethodHiding
    {
        static void MainMethodHiding()
        {

        }
    }
}
