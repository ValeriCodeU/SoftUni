using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            
            double socialScholarship = minSalary * 0.35;
            double excellentScholarship = averageSuccess * 25;

            if (income < minSalary && averageSuccess >= 5.50)
            {
                if (socialScholarship > excellentScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                }
            }

            else if (income < minSalary && averageSuccess > 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");

            }
            else if (averageSuccess >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
    }
        }
}
