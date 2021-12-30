using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double totalConsumption = distance * (FuelConsumption / 100.0);

            if (totalConsumption <= FuelQuantity)
            {
                FuelQuantity -= totalConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuelQuantity: {FuelQuantity:f2}";
        }
    }
}
