using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competetePer30Days = int.Parse(Console.ReadLine());

            double totalFactory = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    double everyThirdDay = Math.Floor((biscuitsPerDay * workers) * 0.75);
                    totalFactory += everyThirdDay;
                }
                else
                {
                    totalFactory += biscuitsPerDay * workers;
                }

                
            }

            Console.WriteLine($"You have produced {totalFactory} biscuits for the past month.");

            if (totalFactory > competetePer30Days)
            {
                double difference = totalFactory - competetePer30Days;
                double percentDiff = difference / competetePer30Days * 100;
                Console.WriteLine($"You produce {percentDiff:f2} percent more biscuits.");
            }
            else
            {
                double differemce = competetePer30Days - totalFactory;
                double percentDiff = differemce / competetePer30Days * 100;
                Console.WriteLine($"You produce {percentDiff:f2} percent less biscuits.");
            }           
        }
    }
}
