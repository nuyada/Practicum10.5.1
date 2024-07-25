using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum10._5._1
{
    /// <summary>
    /// Defines the LogError and LogEvent methods for logging errors and events.(Определяет методы LogError и LogEvent для логирования ошибок и событий.)
    /// </summary>
    internal interface ILogger
    {
        void LogEvent(string message);
        void LogError(string message);
    }
}
