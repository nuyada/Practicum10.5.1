using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum10._5._1
{
    /// <summary>
    /// Implements the ICalculator interface and provides an implementation of the Add method.(Реализует интерфейс ICalculator и предоставляет реализацию метода Add.)
    /// </summary>
    internal class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
