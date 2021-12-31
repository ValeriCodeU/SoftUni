using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<Engine> setOfEngines = new HashSet<Engine>();

            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = null;

                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                if (engineData.Length == 2)
                {
                    engine = new Engine(model, power);
                }

                else if (engineData.Length == 3)
                {

                    int displacement;

                    bool isDisplacement = int.TryParse(engineData[2], out displacement);

                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = engineData[2];
                        engine = new Engine(model, power, efficiency);
                    }



                }
                else if (engineData.Length == 4)
                {
                    int displacement = int.Parse(engineData[2]);
                    string efficiency = engineData[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }

                if (engine != null)
                {
                    setOfEngines.Add(engine);
                }
            }



            int m = int.Parse(Console.ReadLine());


            for (int i = 0; i < m; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];

                Engine engine = setOfEngines.First(x => x.Model == carData[1]);


                Car car = null;


                if (carData.Length == 2)
                {
                    car = new Car(model, engine);

                }
                else if (carData.Length == 3)
                {
                    int weight;

                    bool isWeight = int.TryParse(carData[2], out weight);

                    if (isWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        string color = carData[2];
                        car = new Car(model, engine, color);
                    }
                }

                else if (carData.Length == 4)
                {
                    int weight = int.Parse(carData[2]);
                    string color = carData[3];

                    car = new Car(model, engine, weight, color);
                }

                if (car != null)
                {
                    listOfCars.Add(car);
                }
            }

            foreach (var car in listOfCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
