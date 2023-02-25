using System;
using System.Globalization;

namespace calc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double number1 = 0;
            double number2 = 0;
            try
            {
                number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }

            Console.WriteLine("Введите оператор: +-/*");
            var action = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            try
            {
                number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            if (action == '+')
            {
                Console.WriteLine(number1 + number2);
            }
            else if (action == '-')
            {
                Console.WriteLine(number1 - number2);
            }
          
            else if (action == '*')
            {
                Console.WriteLine(number1 * number2);
            }
            
            else if (action == '/' && number2!= 0)
            {
                Console.WriteLine(number1 / number2);
            }
            
            else if (action == '/' && number2 == 0)
            {
                Console.WriteLine("Нельзя делить на 0");
            }
            
            else 
            {
                Console.WriteLine("Неизвестный оператор");
            }
        }
    }
}