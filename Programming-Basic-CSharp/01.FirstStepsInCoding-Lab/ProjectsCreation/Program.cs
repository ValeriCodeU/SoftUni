using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int numberProjects = int.Parse(Console.ReadLine());
            int ProjectHours = numberProjects * 3;

            Console.WriteLine($"The architect {architect} will need {ProjectHours} hours to complete {numberProjects} project/s.");
        }
    }
}
