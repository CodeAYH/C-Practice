using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hello.Strings
{
    internal class StringFormatDatetime
    {
        static void Main()
        {
            DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

            WriteLine("{0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("{0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-mm-dd tt hh:mm:ss (ddd)"), ciKo);
            WriteLine(dt.ToString("yyyy-mm-dd tt hh:mm:ss (dddd)"), ciKo);
            WriteLine(dt.ToString(ciKo));

            CultureInfo cien = new CultureInfo("en-US");
            WriteLine(dt.ToString("yyyy-mm-dd tt hh:mm:ss (ddd)"), cien);
            WriteLine(dt.ToString("yyyy-mm-dd tt hh:mm:ss (dddd)"), cien);
            WriteLine(dt.ToString(cien));
        }
    }
}
