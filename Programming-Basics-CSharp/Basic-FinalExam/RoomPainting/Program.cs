using System;

namespace RoomPainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPaintBoxes = int.Parse(Console.ReadLine());
            int numOfRollsWallpapers = int.Parse(Console.ReadLine());
            double glovesPrice = double.Parse(Console.ReadLine());
            double brushPrice = double.Parse(Console.ReadLine());

            double numOfGloves = Math.Ceiling(numOfRollsWallpapers * 0.35);
            double numOfBrushes = Math.Floor(numOfPaintBoxes * 0.48);


            double totalPricePaintBoxes = numOfPaintBoxes * 21.50;
            double totalRollsWallpapers = numOfRollsWallpapers * 5.20;
            double totalGlovesPrice = numOfGloves * glovesPrice;
            double totalBrushPrice = numOfBrushes * brushPrice;

            double totalPrice = totalPricePaintBoxes + totalRollsWallpapers + totalGlovesPrice + totalBrushPrice;

            double deliveryPrice = totalPrice / 15;

            Console.WriteLine($"This delivery will cost {deliveryPrice:f2} lv.");
        }
    }
}
