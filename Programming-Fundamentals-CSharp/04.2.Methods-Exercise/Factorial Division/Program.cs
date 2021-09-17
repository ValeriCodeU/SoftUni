using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());


            double firstFactiorial = GetFactorial(firstNum);
            double secondFactiorial = GetFactorial(secondNum);

            double result = firstFactiorial / secondFactiorial;

            Console.WriteLine($"{result:f2}");
        }

        static double GetFactorial(double num)
        {
            double result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
