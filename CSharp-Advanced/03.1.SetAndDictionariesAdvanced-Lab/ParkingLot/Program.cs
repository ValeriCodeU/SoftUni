using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string[] command = Console.ReadLine().Split(", ");

            while (command[0] != "END")
            {
                if (command[0] == "IN")
                {
                    carNumbers.Add(command[1]);
                }
                else if (command[0] == "OUT")
                {
                    carNumbers.Remove(command[1]);
                }

                command = Console.ReadLine().Split(", ");
            }

            if (carNumbers.Count > 0)
            {
                foreach (var item in carNumbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
