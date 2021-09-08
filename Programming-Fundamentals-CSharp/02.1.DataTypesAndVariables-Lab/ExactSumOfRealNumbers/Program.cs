using System;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal exactNum = decimal.Parse(Console.ReadLine());

                sum += exactNum;
            }

            Console.WriteLine(sum);
        }
    }
}
