using System;

namespace CarManufacturer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string commandTire = Console.ReadLine();

            while (commandTire != "No more tires")
            {
                string[] split = commandTire.Split();
                int splitYear = int.Parse(split[0]);
                double splitPressure = double.Parse(split[1]);

                Tire tires = new Tire(splitYear, splitPressure);

                commandTire = Console.ReadLine();
            }

            string commandEngine = Console.ReadLine();

            while (commandEngine != "Engines done")
            {
                string[] split = commandEngine.Split();
                int horsePower = int.Parse(split[0]);
                double cubicCapacity = double.Parse(split[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);

                commandEngine = Console.ReadLine();
            }
        }
    }
}
