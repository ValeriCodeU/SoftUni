using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double allTime = numOfPages / pagesPerHour;
            double hoursPerDay = allTime / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
