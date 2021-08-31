using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.0;
            double discount = 0.0;
            double addPrice = 0.0;

            switch (flower)
            {
                case "Roses":
                    price = 5;
                    if (numOfFlowers > 80)
                    {
                        discount = 0.10;
                    }
                    break;
                case "Dahlias":
                    price = 3.80;
                    if (numOfFlowers > 90)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Tulips":
                    price = 2.80;
                    if (numOfFlowers > 80)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Narcissus":
                    price = 3;
                    if (numOfFlowers < 120)
                    {
                        addPrice = 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = 2.50;
                    if (numOfFlowers < 80)
                    {
                        addPrice = 0.20;
                    }
                    break;

                    

                   
            }
            double totalPrice = numOfFlowers * price;
            totalPrice -= totalPrice * discount;
            totalPrice += totalPrice * addPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flower} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
