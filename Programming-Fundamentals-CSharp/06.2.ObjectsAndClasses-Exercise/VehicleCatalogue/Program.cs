using System;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "End")
            {
                string type = command[0];
                string model = command[1];
                string color = command[2];
                int power = int.Parse(command[3]);

                vehicles.Add(new Vehicle(type, model, color, power));

                command = Console.ReadLine().Split(" ");
            }

            string command2 = Console.ReadLine();

            while (command2 != "Close the Catalogue")
            {
                Vehicle vehicle = GetVehicleByModel(vehicles, command2);

                if (vehicle == null)
                {
                    continue;
                }

                if (vehicle.Type == "car")
                {
                    Console.WriteLine($"Type: Car");
                }
                else
                {
                    Console.WriteLine($"Type: Truck");
                }

                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.HorsePower}");

                command2 = Console.ReadLine();
            }

            double carsAveragePower = GetAverageHorsePower(vehicles, "car");
            double trucksAveragePower = GetAverageHorsePower(vehicles, "truck");
            Console.WriteLine($"Cars have average horsepower of: {carsAveragePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAveragePower:f2}.");
        }

        private static double GetAverageHorsePower(List<Vehicle> vehicles, string value)
        {
            double counter = 0;
            double sumPower = 0;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == value)
                {
                    counter++;
                    sumPower += vehicle.HorsePower;
                }
            }

            if (counter == 0)
            {
                return 0;
            }

            return sumPower / counter;
        }

        private static Vehicle GetVehicleByModel(List<Vehicle> vehicles, string model)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Model == model)
                {
                    return vehicle;
                }
                
            }
            return null;
        }
    }
}
