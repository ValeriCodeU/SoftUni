using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string typeLocation = "";



            // 1. read the input
            //2. check where programmer - destination
            //3. check how much programmer spend it from the budget

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        budget = budget * 0.30;
                        typeLocation = "Camp";
                        break;
                    case "winter":
                        budget = budget * 0.70;
                        typeLocation = "Hotel";
                        break;

                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        budget = budget * 0.40;
                        typeLocation = "Camp";
                        break;
                    case "winter":
                        budget = budget * 0.80;
                        typeLocation = "Hotel";
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                switch (season)
                {
                    case "summer":
                    case "winter":
                        budget = budget * 0.90;
                        typeLocation = "Hotel";
                        break;
                }
            }

            Console.WriteLine($"Somewhere in { destination}");
            Console.WriteLine($"{typeLocation} - {budget:f2}");
        }
    }
}
