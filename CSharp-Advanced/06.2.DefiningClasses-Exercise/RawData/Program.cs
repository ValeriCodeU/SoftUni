using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                List<Tire> tires = new List<Tire>();

                for (int j = 5; j < input.Length; j += 2)
                {
                    int tireAge = int.Parse(input[j + 1]);
                    double tirePressure = double.Parse(input[j]);

                    Tire tireArgs = new Tire(tireAge, tirePressure);
                    tires.Add(tireArgs);
                }

                Engine engineArgs = new Engine(engineSpeed, enginePower);
                Cargo cargoArgs = new Cargo(cargoType, cargoWeight);

                Car singleCar = new Car(model, engineArgs, cargoArgs, tires.ToArray());
                cars.Add(singleCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "fragile").Where(x => x.Tires.Any(x => x.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "flammable").Where(x => x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
