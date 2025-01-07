using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07장
{
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return Position;
        }

    }
    internal class This
    {
        static void MainThis()
        {
            Employee pooh = new();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
        }
    }
}
