using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            int searchingNum = int.Parse(command[0]);
            int power = int.Parse(command[1]);

            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] == searchingNum)
                {
                    for (int k = j - power; k <= j + power; k++)
                    {

                        if (k < 0 || k >= numbers.Count)
                        {
                            continue;
                        }

                        numbers[k] = 0;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
