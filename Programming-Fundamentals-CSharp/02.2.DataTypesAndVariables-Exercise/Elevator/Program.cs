using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());

            double totalCourses = Math.Ceiling((double)numberOfPeople / capacityElevator);

            Console.WriteLine(totalCourses);
        }
    }
}
