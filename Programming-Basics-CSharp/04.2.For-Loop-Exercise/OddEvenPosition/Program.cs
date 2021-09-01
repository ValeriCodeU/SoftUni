using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double oddSum = 0;
            double maxOdd = double.MinValue;
            double minOdd = double.MaxValue;
            double maxEven = double.MinValue;
            double minEven = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNum;

                    if (currentNum > maxEven)
                    {
                        maxEven = currentNum;
                    }

                    if (currentNum < minEven)
                    {
                        minEven = currentNum;
                    }
                }
                else
                {
                    oddSum += currentNum;

                    if (currentNum > maxOdd)
                    {
                        maxOdd = currentNum;
                    }

                    if (currentNum < minOdd)
                    {
                        minOdd = currentNum;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (n >= 1)
            {
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (n >= 2)
            {
                Console.WriteLine($"EvenMin={minEven:f2},");
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
