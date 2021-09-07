using System;

namespace PassengersPerFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfAirlines = int.Parse(Console.ReadLine());

            double maxPassangers = 0;

            string bestAir = "";

            for (int i = 1; i <= numOfAirlines; i++)
            {
                string companyName = Console.ReadLine();

                double currentPassangers = 0;
                double counter = 0;

                string input = Console.ReadLine();

                while (input != "Finish")
                {

                    int numOfPassangers = int.Parse(input);
                    currentPassangers += numOfPassangers;
                    counter++;

                    input = Console.ReadLine();
                }

                if (input == "Finish")
                {
                    double averagePassanger = Math.Floor(currentPassangers / counter);
                    Console.WriteLine($"{companyName}: {averagePassanger} passengers.");

                    if (averagePassanger > maxPassangers)
                    {
                        bestAir = companyName;
                        maxPassangers = averagePassanger;
                    }
                }
            }
            Console.WriteLine($"{bestAir} has most passengers per flight: {maxPassangers}");
        }
    }
}