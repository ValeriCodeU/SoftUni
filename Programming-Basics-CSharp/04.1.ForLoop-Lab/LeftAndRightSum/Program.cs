using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 1; i <= n; i++)
            {
                sumLeft = sumLeft + int.Parse(Console.ReadLine());

            }
            for (int i = 1; i <= n; i++)
            {
                sumRight = sumRight + int.Parse(Console.ReadLine());
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine("Yes, sum = " + sumLeft);
            }

            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sumLeft - sumRight));
            }
            


        }
    }
}
