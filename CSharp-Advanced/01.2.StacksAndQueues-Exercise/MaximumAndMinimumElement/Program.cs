using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfQueries = int.Parse(Console.ReadLine());

            Stack<int> resultNumbers = new Stack<int>();

            for (int i = 0; i < numOfQueries; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (commands[0] == 1)
                {
                    resultNumbers.Push(commands[1]);
                }
                else if (commands[0] == 2 && resultNumbers.Count > 0)
                {
                    resultNumbers.Pop();
                }
                else if (commands[0] == 3 && resultNumbers.Count > 0)
                {
                    Console.WriteLine(resultNumbers.Max());
                }
                else if (commands[0] == 4 && resultNumbers.Count > 0)
                {
                    Console.WriteLine(resultNumbers.Min());
                }                
            }

            Console.WriteLine(String.Join(", ", resultNumbers));
        }
    }      
    
}
