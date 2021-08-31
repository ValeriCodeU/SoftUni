using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPricePerKg = double.Parse(Console.ReadLine());
            double quantityBananas = double.Parse(Console.ReadLine());
            double quantityOranges = double.Parse(Console.ReadLine());
            double quantityRaspberries = double.Parse(Console.ReadLine());
            double quantityStrawberries = double.Parse(Console.ReadLine());


            double rassberriesPricePerKg = strawberriesPricePerKg - strawberriesPricePerKg * 0.5;
            double orangesPricePerKg = rassberriesPricePerKg - rassberriesPricePerKg * 0.40;
            double bannansPricePerKg = rassberriesPricePerKg - rassberriesPricePerKg * 0.80;

            double totalStrawberriesPrice = strawberriesPricePerKg * quantityStrawberries;
            double totalRassberiesPrice = rassberriesPricePerKg * quantityRaspberries;
            double totalOrangesPrice = orangesPricePerKg * quantityOranges;
            double totalbannanasPrice = bannansPricePerKg * quantityBananas;

            double totalPrice = totalStrawberriesPrice + totalRassberiesPrice + totalOrangesPrice + totalbannanasPrice;

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
