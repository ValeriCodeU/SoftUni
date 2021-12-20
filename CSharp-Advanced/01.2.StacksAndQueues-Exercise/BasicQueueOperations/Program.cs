using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> resultNumbers = new Queue<int>();

            int addCountNumbers = commands[0];
            int removeCountNumbers = commands[1];
            int checkNumber = commands[2];

            for (int i = 0; i < addCountNumbers; i++)
            {
                resultNumbers.Enqueue(numbers[i]);
            }

            for (int i = 0; i < removeCountNumbers; i++)
            {
                resultNumbers.Dequeue();
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
