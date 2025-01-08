using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08장
{
    interface ILogger3
    {
        void WriteLog(string message);
        void WriteError(string error)
        {
            WriteLog($"Error: {error}");
        }
    }

    class ConsoleLogger3 : ILogger3
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                $"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }
    internal class DefaultImplementation
    {
    }
}
