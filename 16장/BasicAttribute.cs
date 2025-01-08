using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16장
{
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()을 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine($"I'm Old");
        }

        public void NewMethod()
        {
            Console.WriteLine("New MEthod");
        }
    }
    internal class BasicAttribute
    {
    }
}
