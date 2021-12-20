using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> resultNumbers = new Stack<int>();

            int pushNumbers = commands[0];
            int popNumbers = commands[1];
            int checkNumber = commands[2];

            for (int i = 0; i < pushNumbers; i++)
            {
                resultNumbers.Push(numbers[i]);
            }

            for (int i = 0; i < popNumbers; i++)
            {
                resultNumbers.Pop();
            }

            if (resultNumbers.Count > 0)
            {
                if (resultNumbers.Contains(checkNumber))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minNumber = resultNumbers.Min();
                    Console.WriteLine(minNumber);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
