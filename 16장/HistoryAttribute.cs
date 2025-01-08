using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _16장
{
    [System.AttributeUsage(System.AttributeTargets.Class, 
        AllowMultiple=true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "first release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }

        
    }
    [History("Sean", version = 0.1, changes = "2017-11-01 Created class stub")]
    [History("Bob", version = 0.2, changes = "2020-11-01 Created class stub")]
    class MyClass2
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }
    internal class HistoryAttribute
    {
        static void Main()
        {
            Type type = typeof(MyClass2);
            Attribute[] att = Attribute.GetCustomAttributes(type);

            foreach (Attribute a in att)
            {
                History h = a as History;
                if (h != null)
                {
                    Console.WriteLine($"Ver: {h.version}, {h.GetProgrammer()}," +
                        $"{h.changes}");
                }
            }
        }
    }
}
