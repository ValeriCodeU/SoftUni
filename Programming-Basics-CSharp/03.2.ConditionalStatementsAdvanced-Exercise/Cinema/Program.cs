using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFilm = Console.ReadLine();
            int numOfRows = int.Parse(Console.ReadLine());
            int numOfColomns = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (typeFilm == "Premiere")
            {
                income = numOfRows * numOfColomns * 12;
            }
            else if (typeFilm == "Normal")
            {
                income = numOfRows * numOfColomns * 7.50;
            }
            else if (typeFilm == "Discount")
            {
                income = numOfRows * numOfColomns * 5;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
