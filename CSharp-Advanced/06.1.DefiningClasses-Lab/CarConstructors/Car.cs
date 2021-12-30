using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; } = "VW";
        public string Model { get; set; } = "Golf";
        public int Year { get; set; } = 2025;
        public double FuelQuantity { get; set; } = 200;
        public double FuelConsumption { get; set; } = 10;
        public Car(string make, string model, int year) 
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumtion) : this (make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumtion;
        }

        public Car()
        {
        }

        public string View()
        {
            return $"{Make} {Model} {Year}";
        }
    }
}
