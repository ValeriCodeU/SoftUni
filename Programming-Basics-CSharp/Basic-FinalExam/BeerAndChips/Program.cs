using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string fanName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numOfBeers = int.Parse(Console.ReadLine());
            int numOfChips = int.Parse(Console.ReadLine());

            double totalBeerPrice = numOfBeers * 1.20;

            double totalChipsPrice = Math.Ceiling((totalBeerPrice * 0.45) * numOfChips);

            double totalPrice = totalBeerPrice + totalChipsPrice;


            if (totalPrice <= budget)
            {
                Console.WriteLine($"{fanName} bought a snack and has {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{fanName} needs {totalPrice - budget:f2} more leva!");
            }
        }
    }
}
