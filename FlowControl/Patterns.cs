using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlowControl
{
    class Preschooler { }
    class Underage { }
    class Adult { }
    class Senior { }

    internal class Patterns
    {
        static int CalculateFee(object visitor)
        {
            return visitor switch
            {
                Underage => 100,
                Adult => 500,
                Senior => 200,
                _ => throw new ArgumentException()
            }; 
        }
        static void MainPatterns()
        {
            // Type Pattern
            object foo = 23;
            if (foo is int)
            {
                Console.WriteLine(foo);
            }

            // Constant Pattern
            
            var GetCountryCode = (string nation) => nation switch
            {
                "KR" => 32,
                "US" => 1,
                "UK" => 44,
                _ => throw new ArgumentException()
            };
        }
    }
}
