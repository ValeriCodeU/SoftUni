using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = n; i <= m; i++)
            {
                int currentNum = i;

                int evenSum = 0;
                int oddSum = 0;
                int counter = 0;

                while (currentNum != 0)
                {
                    int num = currentNum % 10;

                    if (counter % 2 == 0)
                    {
                        evenSum += num;
                    }
                    else
                    {
                        oddSum += num;
                    }
                    currentNum /= 10;
                    counter++;
                }

                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
