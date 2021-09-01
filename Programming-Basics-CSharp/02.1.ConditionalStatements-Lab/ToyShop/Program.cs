using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int numOfPuzzles = int.Parse(Console.ReadLine());
            int numOfTalkingDolls = int.Parse(Console.ReadLine());
            int numOfTeddyBears = int.Parse(Console.ReadLine());
            int numOfMinions = int.Parse(Console.ReadLine());            
            int numOfTrucks = int.Parse(Console.ReadLine());

            double pricePuzzles = numOfPuzzles * 2.60;
            double priceTalkingDolls = numOfTalkingDolls * 3;
            double priceTeddyBears = numOfTeddyBears * 4.10;
            double priceMinions = numOfMinions * 8.20;
            double priceTrucks = numOfTrucks * 2;

            double totalPriceToys = pricePuzzles + priceTalkingDolls + priceTeddyBears + priceMinions + priceTrucks;

            int allOrderToys = numOfPuzzles + numOfTalkingDolls + numOfTeddyBears + numOfMinions + numOfTrucks;

            if (allOrderToys >= 50)
            {
                totalPriceToys -= totalPriceToys * 0.25;                
            }

            double totalPriceAfterRent = totalPriceToys - totalPriceToys * 0.10;

            //double winMoney = totalPriceAfterRent - priceExcursion;
            //double lackMoney = priceExcursion - totalPriceAfterRent;

            if (totalPriceAfterRent >= priceExcursion)
            {
                double winMoney = totalPriceAfterRent - priceExcursion;
                Console.WriteLine($"Yes! {winMoney:f2} lv left.");
            }
            else if (totalPriceAfterRent <= priceExcursion)
            {
                double lackMoney = priceExcursion - totalPriceAfterRent;
                Console.WriteLine($"Not enough money! {lackMoney:f2} lv needed.");
            }


        }

        
    }
}
