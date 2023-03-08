using System;
using System.Globalization;

namespace calc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double number1;
            double number2;
            char action;

            while (true)
            {
                Console.WriteLine("Калькулятор калькулировал, калькулирует и сейчас тоже всё выкалькулировает");
                while (true)
                {
                    number1 = ReadNumber(out var isSuccess);
                    if (isSuccess) break;
                }

                while (true)
                {
                    action = ReadAction(out var isSuccessChar);
                    if (isSuccessChar) break;
                }

                while (true)
                {
                    number2 = ReadNumber(out var isSuccess2);
                    if (isSuccess2) break;
                }

                Calc(number1, number2, action);
            }
        }

        public static double ReadNumber(out bool isSuccess)
        {
            Console.WriteLine("Введите число");
            var str = Console.ReadLine();
            isSuccess = double.TryParse(str, out var number);
            if (isSuccess)
            {
                return number;
            }
            else 
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку");
                return 0;
            }
        }
            public static char ReadAction(out bool isSuccess)
        {
            Console.WriteLine("Введите оператор: +-/*");
            var str = Console.ReadLine();
            isSuccess = char.TryParse(str, out var action)&& (action == '+' || action == '-' || action == '/' || action == '*');
            if (isSuccess)
            {
                return action;
            }
            else 
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку");
                return '#';
            }
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