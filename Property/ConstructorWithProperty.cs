using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWithProperty
{
    class BirthdayInfo2
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    internal class ConstructorWithProperty
    {
        static void MainConstructorWithProperty()
        {
            BirthdayInfo2 birth = new BirthdayInfo2
            {
                Name = "서현",
                Birthday = new DateTime(1991, 6, 28),
            };

            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Birthday.ToShortTimeString());
            Console.WriteLine(birth.Age);
                }
    }
}
