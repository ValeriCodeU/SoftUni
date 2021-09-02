using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GOALSTEPS = 10000;

            int totalSteps = 0;

           

            while (totalSteps < GOALSTEPS)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsGoingHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsGoingHome;

                    if (totalSteps < GOALSTEPS)
                    {
                        Console.WriteLine($"{GOALSTEPS - totalSteps} more steps to reach goal.");
                    }
                    break;
                }

                int steps = int.Parse(input);
                totalSteps += steps;



                

                
            }

            if (totalSteps >= GOALSTEPS)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - GOALSTEPS} steps over the goal!");
            }

            //else
            //{
            //    Console.WriteLine($"{GOALSTEPS - totalSteps} more steps to reach goal.");
            //}
        }
    }
}
