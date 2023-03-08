using System;
using System.Globalization;

namespace calc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double num1;
            double num2;
            char action;

            while (true)
            {
                while (!ReadNumberNewTopMethod(out num1))
                {
                    Console.WriteLine("Некорректный ввод. Повторите попытку");
                }

                while (!ReadAction(out action))
                {
                    Console.WriteLine("Некорректный ввод. Повторите попытку");
                }

                while (!ReadNumberNewTopMethod(out num2))
                {
                    Console.WriteLine("Некорректный ввод. Повторите попытку");
                }
                Calc(num1, num2, action);
            }
        }

        private static bool ReadNumberNewTopMethod(out double number)
        {
            Console.WriteLine("Введите число");
            var str = Console.ReadLine();
            return double.TryParse(str, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out number);
        }
        
        private static bool ReadAction(out char action)
        {
            Console.WriteLine("Введите оператор: +-/*");
            var str = Console.ReadLine();
            return char.TryParse(str, out action) && (action == '+' || action == '-' || action == '/' || action == '*');
        }
        public static void Calc(double number1, double number2, char action)
        {
            if (action == '+')
            {
                Console.WriteLine("Результат: " + (number1 + number2));
            }
            else if (action == '-')
            {
                Console.WriteLine("Результат: " + (number1 - number2));
            }
            else if (action == '*')
            {
                Console.WriteLine("Результат: " + number1 * number2);
            }
            
            else if (action == '/' && number2 == 0)
            {
                Console.WriteLine("Нельзя делить на ноль");
            }
            else if (action == '/')
            {
                Console.WriteLine("Результат: " + number1 / number2);
            }
            else Console.WriteLine("Я упал");
        }
    }
}