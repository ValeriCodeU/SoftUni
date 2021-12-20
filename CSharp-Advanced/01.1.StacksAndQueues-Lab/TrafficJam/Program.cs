using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carPass = int.Parse(Console.ReadLine());

            Queue<string> trafficJam = new Queue<string>();

            string command = Console.ReadLine();

            int countPass = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carPass; i++)
                    {
                        if (trafficJam.Count > 0)
                        {
                            Console.WriteLine($"{trafficJam.Dequeue()} passed!");
                            countPass++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    trafficJam.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{countPass} cars passed the crossroads.");
        }        
    }
}
