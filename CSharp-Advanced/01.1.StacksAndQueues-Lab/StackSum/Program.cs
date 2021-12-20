using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine().ToLower();

            Stack<int> result = new Stack<int>(numbers);
            
            while (input != "end")
            {
                string[] command = input.Split();

                if (command[0] == "add")
                {
                    int firstNum = int.Parse(command[1]);
                    int secondNum = int.Parse(command[2]);

                    result.Push(firstNum);
                    result.Push(secondNum);
                }
                else if (command[0] == "remove")
                {
                    int deleteCount = int.Parse(command[1]);

                    if (deleteCount > result.Count)
                    {
                        input = Console.ReadLine().ToLower();
                        continue;
                    }

                    for (int i = 0; i < deleteCount; i++)
                    {
                        result.Pop();
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {result.Sum()}");
        }
    }
}
