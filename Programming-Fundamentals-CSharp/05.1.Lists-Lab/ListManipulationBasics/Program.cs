using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandTypes = command.Split();

                string action = commandTypes[0];
                int element = int.Parse(commandTypes[1]);

                if (action == "Add")
                {
                    numbers.Add(element);
                }
                else if (action == "Remove")
                {
                    numbers.Remove(element);
                }
                else if (action == "RemoveAt")
                {
                    numbers.RemoveAt(element);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandTypes[2]);
                    numbers.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
