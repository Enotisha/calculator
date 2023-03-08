using System;
using System.Globalization;

namespace calc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var number1 = ReadNumber(out var isSuccess);
            if (isSuccess)
            {
                var action = ReadOperator(out var isSuccessChar);
                if (isSuccessChar)
                {
                    var number2 = ReadNumber(out var isSuccess2);
                    if (isSuccess2)
                    {
                        Calc(number1, number2, action);
                    }
                    else Console.WriteLine("Я упал");
                }
                else Console.WriteLine("Я упал");
            }
            else Console.WriteLine("Я упал");
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
                Console.WriteLine("Некорректный ввод");
                return 0;
            }
        }
            public static char ReadOperator(out bool isSuccess)
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
                Console.WriteLine("Некорректный ввод");
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
            else if (action == '/')
            {
                try
                {
                    Console.WriteLine("Результат: " + number1 / number2);
                }
                catch
                {
                    Console.WriteLine("Нельзя делить на ноль");
                }
            }
            else Console.WriteLine("Я упал");
        }
    }
}