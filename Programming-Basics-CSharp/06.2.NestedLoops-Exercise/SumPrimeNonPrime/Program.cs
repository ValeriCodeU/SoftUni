using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int sumOfprimeNum = 0;
            int sumOfNonPrimeNum = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int counter = 0;

                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            counter++;
                        }

                    }
                    if (counter == 2)
                    {
                        sumOfprimeNum += number;
                    }
                    else
                    {
                        sumOfNonPrimeNum += number;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumOfprimeNum}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNum}");
        }
    }
}
