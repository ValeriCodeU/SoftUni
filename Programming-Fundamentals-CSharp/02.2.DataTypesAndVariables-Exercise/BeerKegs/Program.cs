using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double volume = 0;

            double sumOfVolume = 0;

            string biggestKeg = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * (radius * radius) * height;

                if (volume >= sumOfVolume)
                {
                    biggestKeg = model;
                    sumOfVolume = volume;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
