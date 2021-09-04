using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sumOfScores = 0;
            int counter = 0;
            double totalScores = 0;
            int totalCounter = 0;

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                for (int i = 1; i <= n; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    sumOfScores += score;
                    counter++;
                }
                totalScores += sumOfScores;
                totalCounter += counter;
                Console.WriteLine($"{input} - {sumOfScores / counter:f2}.");

                sumOfScores = 0;
                counter = 0;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {totalScores / totalCounter:f2}.");
        }
    }
}
