using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl;

internal class Switch
{
    static void Switsadasdch()
    {
        Console.WriteLine("Input the Month");
        string day = Console.ReadLine();

        switch (day)
        {
            case "월":
                Console.WriteLine("월");
                break;
            case "화":
                Console.WriteLine("화");
                break;
            default:
                Console.WriteLine("NO");
                break;
        }

        object obj = null;

        string s = Console.ReadLine();
        if (int.TryParse(s, out int out_i))
        {
            obj = out_i;
        }
        else if (float.TryParse(s, out float float_i))
        {
            obj = float_i;
        }
        else
        {
            obj = s;
        }

        switch (obj)
        {
            case int:
                Console.WriteLine("Int");
                break;
            case float:
                Console.WriteLine("float");
                break;
            default:
                Console.WriteLine("No");
                break;
        }
    }
}
