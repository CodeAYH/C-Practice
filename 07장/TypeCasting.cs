using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07장
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }
    internal class TypeCasting
    {
        static void MainTypeCasting()
        {
            Mammal mammal = new Dog();
            Dog dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();
            Cat cat = mammal2 as Cat;
            if (cat != null)
            {
                cat.Meow();
            }

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
            {
                cat2.Meow();
            }
            else
            {
                Console.WriteLine("Cat2 is not a cat");
            }
        }
    }
}
