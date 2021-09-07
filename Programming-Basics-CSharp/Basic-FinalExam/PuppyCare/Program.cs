using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodKg = int.Parse(Console.ReadLine());

            int foodGrams = foodKg * 1000;

            string input = Console.ReadLine();

            int totalFood = 0;

            while (input != "Adopted")
            {
                int foodEated = int.Parse(input);
                totalFood += foodEated;

                input = Console.ReadLine();
            }            

            if (totalFood <= foodGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodGrams - totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFood - foodGrams} grams more.");
            }
        }
    }
}
