using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (command == "divide")
            {
                DivideResult(number1, number2);
            }
            else if (command == "multiply")
            {
                MultiplyResult(number1, number2);
            }
            else if (command == "add")
            {
                AddResult(number1, number2);
            }
            else if (command == "substract")
            {
                SubstractResult(number1, number2);
            }
        }

        static void DivideResult(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine(result);
        }

        static void MultiplyResult(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine(result);
        }

        static void AddResult(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }

        static void SubstractResult(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine(result);
        }
    }
}
