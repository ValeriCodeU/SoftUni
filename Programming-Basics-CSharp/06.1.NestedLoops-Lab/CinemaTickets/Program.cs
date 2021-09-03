using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double standartTicketCounter = 0;
            double studentTicketCounter = 0;
            double kidTicketCounter = 0;

            while (input != "Finish")
            {
                int freeSpace = int.Parse(Console.ReadLine());
                double counterSpace = 0;

                string typeTicket = Console.ReadLine();

                while (typeTicket != "End")
                {
                    counterSpace++;
                    switch (typeTicket)
                    {
                        case "standard":
                            standartTicketCounter++;
                            break;
                        case "student":
                            studentTicketCounter++;
                            break;
                        case "kid":
                            kidTicketCounter++;
                            break;
                    }
                    if (counterSpace == freeSpace)
                    {
                        Console.WriteLine($"{input} - {(counterSpace * 100) / freeSpace:f2}% full.");
                        break;
                    }
                    typeTicket = Console.ReadLine();
                }
                if (typeTicket == "End")
                {
                    Console.WriteLine($"{input} - {(counterSpace * 100) / freeSpace:f2}% full.");
                }
                input = Console.ReadLine();
            }
            double totalTickets = studentTicketCounter + standartTicketCounter + kidTicketCounter;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTicketCounter * 100) / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{(standartTicketCounter * 100) / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{(kidTicketCounter * 100) / totalTickets:f2}% kids tickets.");
        }
    }
}
