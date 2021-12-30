using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; } 
        public string Model { get; set; } 
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
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

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumtion, Engine engine, Tire[] tires) 
            : this (make, model, year, fuelQuantity, fuelConsumtion)
        {
            Engine = engine;
            Tires = tires;             
        }

        

        //public string View()
        //{
        //    return $"{Make} {Model} {Year}";
        //}

    }
}
