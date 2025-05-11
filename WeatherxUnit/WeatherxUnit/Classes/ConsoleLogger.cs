using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherxUnit.Interfaces;

namespace WeatherxUnit.Classes
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        public void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
    }
}
