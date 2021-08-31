using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());

            double priceSquareMeters = 7.61;
            double allPrice = squareMeters * priceSquareMeters;
            double discountPrice = allPrice * 0.18;
            double finalPrice = allPrice - discountPrice;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discountPrice} lv.");
        }
    }
}
