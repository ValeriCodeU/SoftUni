using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            int sumOfLiters = 0;

            for (int i = 1; i <= numOfLines; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                sumOfLiters += liters;

                if (sumOfLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumOfLiters -= liters;
                    continue;
                }
            }

            Console.WriteLine(sumOfLiters);
        }
    }
}
