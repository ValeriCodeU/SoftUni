using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            DistanceTravelled = 0;
        }       

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double DistanceTravelled { get; set; }

        
        public bool DriveDistance(double amountKm)
        {
            double needFuel = amountKm * FuelConsumptionPerKilometer;

            if (FuelAmount < needFuel)
            {
                return false;
            }

            FuelAmount -= needFuel;
            DistanceTravelled += amountKm;

            return true;
        }
    }
}
