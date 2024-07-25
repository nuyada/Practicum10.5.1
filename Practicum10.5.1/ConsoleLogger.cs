using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum10._5._1
{
    /// <summary>
    /// Implements the ILogger interface and outputs messages to the console with the appropriate colors.(Реализует интерфейс ILogger и выводит сообщения в консоль с соответствующими цветами.)
    /// </summary>
    internal class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void LogEvent(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
