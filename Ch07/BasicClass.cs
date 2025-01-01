using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07
{
    class Cat
    {
        public string Name;
        public string Color;
        public void Meow()
        {
            Console.WriteLine($"{Name} Meow!");
        }

        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()
        {
            Console.WriteLine("Bye");
        }
    }
    internal class BasicClass
    {
        static void MainBasicClass()
        {
            Cat kitty = new Cat();
            kitty.Color = "white";
            kitty.Name = "Kitty";
            kitty.Meow();
        }
    }
}
