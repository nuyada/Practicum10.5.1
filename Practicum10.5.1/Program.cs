using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum10._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();
            ILogger logger = new ConsoleLogger();
            try
            {
                Console.Write("Введите первое число: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = calculator.Add(num1, num2);
                logger.LogEvent($"Результат сложения: {result}");
            }
            catch (FormatException ex)
            {
                logger.LogError("Ошибка: Введено некорректное значение. Пожалуйста, введите целое число.");
            }
            catch (Exception ex)
            {
                logger.LogError($"Ошибка: {ex.Message}");
            }
            finally
            {
                logger.LogEvent("Калькулятор завершил работу.");
            }
            Console.ReadKey();
        }
    }
}
