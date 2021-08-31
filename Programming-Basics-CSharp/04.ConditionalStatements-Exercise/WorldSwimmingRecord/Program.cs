using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSeconds = double.Parse(Console.ReadLine());

            double allTime = distanceMeters * timeSeconds;
            double delayTime = Math.Floor(distanceMeters / 15);

            allTime = allTime + delayTime * 12.5;

            if (allTime < record)
            {                
                Console.WriteLine($"Yes, he succeeded! The new world record is {allTime:f2} seconds.");
            }          
            else if (allTime >= record)
            {
                double lackTime = allTime - record;
                Console.WriteLine($"No, he failed! He was {lackTime:f2} seconds slower.");
            }
            
            


        }
    }
}
