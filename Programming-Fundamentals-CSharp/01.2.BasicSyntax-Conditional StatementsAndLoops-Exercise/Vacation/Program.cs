using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (typeGroup == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (typeGroup == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            double totalPrice = numOfPeople * price;

            if (typeGroup == "Students" && numOfPeople >=30)
            {
                totalPrice *= 0.85;
            }
            else if (typeGroup == "Business" && numOfPeople >= 100)
            {
                totalPrice = totalPrice - (price * 10);
            }
            else if (typeGroup == "Regular" && numOfPeople >= 10 && numOfPeople <= 20)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
