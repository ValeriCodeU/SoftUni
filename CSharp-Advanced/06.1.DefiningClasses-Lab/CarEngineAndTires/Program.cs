using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4]
            {
                new Tire(2021, 200),
                new Tire(2020, 150),
                new Tire(2019, 150),
                new Tire(2019, 140),
            };

            Engine engine = new Engine(100, 3000);

            Car car = new Car("Mercedes", "IK", 2021, 250, 9, engine, tires);

            foreach (var tire in car.Tires)
            {
                Console.WriteLine(tire.Year);
            }
        }
    }
}
