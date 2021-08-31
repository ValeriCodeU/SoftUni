using System;

namespace GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double priceClothingExtra = double.Parse(Console.ReadLine());

            double priceClothes = extras * priceClothingExtra;
            double decorFilm = budget * 0.10;
            double totalPriceFilm = priceClothes + decorFilm;

            if (extras > 150)
            {
                priceClothes -= priceClothes * 0.1;
                totalPriceFilm = priceClothes + decorFilm;
            }
            

            if (totalPriceFilm > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPriceFilm - budget:f} leva more.");
            }
            else if (totalPriceFilm <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPriceFilm:f2} leva left.");
            }
        }
    }
}
