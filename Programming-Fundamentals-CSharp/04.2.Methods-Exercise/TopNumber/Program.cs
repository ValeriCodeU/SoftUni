using System;
using System.Collections.Generic;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsDivisible(i) && ContainOdd(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static bool ContainOdd(int i)
        {
            while (i > 0)
            {

                if (i % 2 == 1)
                {
                    return true;
                }

                i /= 10;
            }

            return false;

        }

        private static bool IsDivisible(int i)
        {
            int sum = 0;

            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }

            bool isDivisible = sum % 8 == 0;
            return isDivisible;
        }
    }
}
