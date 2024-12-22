using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class TypePattern
    {
        static void MainTypePattern()
        {
            object foo = 23;
            if (foo is int bar)
            {
                Console.WriteLine(bar);
            }
        }
    }
}
