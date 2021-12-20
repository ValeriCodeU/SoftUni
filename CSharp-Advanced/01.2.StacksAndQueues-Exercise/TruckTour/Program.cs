using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int truckTours = int.Parse(Console.ReadLine());
           
            Queue<string> petrolPumps = new Queue<string>();

            for (int i = 0; i < truckTours; i++)
            {
                string petrolData = Console.ReadLine();
                petrolPumps.Enqueue(petrolData);
            }

            for (int i = 0; i < truckTours; i++)
            {
                bool isCompleteCircle = true;
                int currentPetrol = 0;

                for (int j = 0; j < truckTours; j++)
                {                    
                    int[] petrolParameters = petrolPumps.Peek().Split().Select(int.Parse).ToArray();
                    petrolPumps.Enqueue(petrolPumps.Dequeue());

                    int amountPetrol = int.Parse(petrolParameters[0].ToString());
                    int distance = int.Parse(petrolParameters[1].ToString());

                    currentPetrol += amountPetrol;
                    currentPetrol -= distance;

                    if (currentPetrol < 0)
                    {
                        isCompleteCircle = false;
                    }
                }
                if (isCompleteCircle == true)
                {
                    Console.WriteLine(i);
                    break;
                }
                petrolPumps.Enqueue(petrolPumps.Dequeue());
            }
        }
    }
}
