using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOflowGrades = int.Parse(Console.ReadLine());

            
            string taskName = Console.ReadLine();

            int counLowGrades = 0;

            int countAllTasks = 0;

            double grades = 0;

            string lastProblem = "";

            

            while (taskName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                grades += grade;

                countAllTasks++;

                if (grade <= 4)
                {
                    counLowGrades++;

                    if (numOflowGrades == counLowGrades)
                    {
                        Console.WriteLine($"You need a break, {counLowGrades} poor grades.");
                        break;
                    }
                }
                lastProblem = taskName;
                taskName = Console.ReadLine();




            }

            if (taskName == "Enough")
            {
                Console.WriteLine($"Average score: {grades / countAllTasks:f2}");
                Console.WriteLine($"Number of problems: {countAllTasks}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
