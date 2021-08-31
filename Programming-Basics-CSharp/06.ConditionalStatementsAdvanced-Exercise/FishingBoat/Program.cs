using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double priceBoat = 0;


            
            if (fishermen <= 6)
            {

                switch (season)
                {
                    case "Spring":
                        priceBoat = 3000 * 0.9;
                        break;
                    case "Summer":
                        priceBoat = 4200 * 0.9;
                        break;
                    case "Autumn":
                        priceBoat = 4200 * 0.9;
                        break;
                    case "Winter":
                        priceBoat = 2600 * 0.9;
                        break;
                }
            }

            else if (fishermen >= 7 && fishermen <= 11)
            {
                switch (season)
                {
                    case "Spring":
                        priceBoat = 3000 * 0.85;
                        break;
                    case "Summer":
                        priceBoat = 4200 * 0.85;
                        break;
                    case "Autumn":
                        priceBoat = 4200 * 0.85;
                        break;
                    case "Winter":
                        priceBoat = 2600 * 0.85;
                        break;
                }
            }
            else if (fishermen >= 12)
            {
                switch (season)
                {
                    case "Spring":
                        priceBoat = 3000 * 0.75;
                        break;
                    case "Summer":
                        priceBoat = 4200 * 0.75;
                        break;
                    case "Autumn":
                        priceBoat = 4200 * 0.75;
                        break;
                    case "Winter":
                        priceBoat = 2600 * 0.75;
                        break;
                }
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                priceBoat -= priceBoat * 0.05;
            }
           
            if (budget >= priceBoat)
            {
                Console.WriteLine($"Yes! You have {budget-priceBoat:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {priceBoat-budget:f2} leva.");
            }
            
        }
    }
}
