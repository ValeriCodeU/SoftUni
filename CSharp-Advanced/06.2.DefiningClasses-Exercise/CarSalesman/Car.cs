using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight) : this (model, engine)
        {
            Weight = weight;
        }
        

        public Car(string model, Engine engine, string color) : this (model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine, color)
        {
            Weight = weight;
        }

        public string Model { get; set; }
        public Engine Engine  { get; set; }
        public int? Weight { get; set; }       
        public string Color { get; set; }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            string weightToStr = Weight.HasValue ? Weight.ToString() : "n/a";
            string colorToStr = String.IsNullOrEmpty(Color) ? "n/a" : Color;

            builder
                .AppendLine($"{Model}:")
                .AppendLine($"  {Engine}")
                .AppendLine($"  Weight: {weightToStr}")
                .AppendLine($"  Color: {colorToStr}");

            return builder.ToString().TrimEnd();
        }
    }
}
