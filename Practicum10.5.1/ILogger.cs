using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum10._5._1
{
    internal interface ILogger
    {
        void LogEvent(string message);
        void LogError(string message);
    }
}
