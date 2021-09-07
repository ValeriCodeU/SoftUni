using System;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int numOfPeople = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double price = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (timeOfDay == "day")
                {
                    price = 10.50;
                }
                else if (timeOfDay == "night")
                {
                    price = 8.40;
                }
            }

            if (month == "june" || month == "july" || month == "august")
            {
                if (timeOfDay == "day")
                {
                    price = 12.60;
                }
                else if (timeOfDay == "night")
                {
                    price = 10.20;
                }
            }

            if (numOfPeople >= 4)
            {
                price = price - price * 0.10;

                if (hours >= 5)
                {
                    price = price - price * 0.5;
                }
            }

            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {price * numOfPeople * hours:f2}");
        }
    }
}
