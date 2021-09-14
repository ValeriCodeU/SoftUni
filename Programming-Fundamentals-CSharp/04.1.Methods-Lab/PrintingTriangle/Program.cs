using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
                

            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }

        static void PrintTriangle(int number)
        {           


            for (int i = 1; i <= number; i++)
            {
                PrintNumbers(i);
            }

            for (int i = number - 1; i >= 1; i--)
            {
                PrintNumbers(i);
            }
        }

        private static void PrintNumbers(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
