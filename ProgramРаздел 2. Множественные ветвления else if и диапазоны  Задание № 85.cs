using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program85
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите процент заряда повербанка: ");

            if (double.TryParse(Console.ReadLine(), out double charge) && charge >= 0 && charge <= 100)
            {
                // Логика работы с if-else
                if (charge < 25)
                {
                    int leds = 1;
                    Console.WriteLine($"Светится светодиодов: {leds}");
                }
                else if (charge < 50)
                {
                    int leds = 2;
                    Console.WriteLine($"Светится светодиодов: {leds}");
                }
                else if (charge < 75)
                {
                    int leds = 3;
                    Console.WriteLine($"Светится светодиодов: {leds}");
                }
                else
                {
                    int leds = 4;
                    Console.WriteLine($"Светится светодиодов: {leds}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: процент должен быть от 0 до 100.");
            }
        }
    }
}