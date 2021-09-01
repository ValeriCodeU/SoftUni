using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;

                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
            }
            int diff = sum - maxNum;

            if (diff == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNum);
            }
            else
            {
                int result = Math.Abs(diff - maxNum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + result);
            }
        }
    }
}
