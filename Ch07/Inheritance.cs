using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }
        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{this.Name}.BaseMethod()");
        }
    }

    class Dervied : Base
    {
        public Dervied(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }

        ~Dervied()
        {
            Console.WriteLine($"{this.Name}.~Dervied");
        }

        public void DerviedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }
    internal class Inheritance
    {
        static void MainInheritance()
        {
            Base a = new Base("A");
            a.BaseMethod();

            Dervied d = new Dervied("D");
            d.BaseMethod();
            d.DerviedMethod();
            return;
        }
    }
}
