using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();            
            
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandType = input.Split();

                if (commandType.Length > 1)
                {                    
                    int element = int.Parse(commandType[1]);

                    if (element <= maxCapacity)
                    {
                        wagons.Add(element);
                    }
                    
                }
                else
                {
                    int element = int.Parse(commandType[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + element <= maxCapacity)
                        {
                            wagons[i] += element;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
