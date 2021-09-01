using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOddPosition = 0;
            int sumEvenPosition = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if(i % 2 != 0)
                {
                    sumEvenPosition += currentNum;
                }

                else
                {
                    sumOddPosition += currentNum;
                }

                
            }

            if (sumEvenPosition == sumOddPosition)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumEvenPosition);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sumEvenPosition - sumOddPosition));
            }

            
        }
    }
}
