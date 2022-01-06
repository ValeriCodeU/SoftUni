using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> numbers = new List<int>();
            Action<List<int>> printResult = numbers => Console.WriteLine(String.Join(" ", numbers));

            Predicate<int> isEven = number => number % 2 == 0;

            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }

            string command = Console.ReadLine();

            if (command == "even")
            {
                printResult(numbers.Where(x => isEven(x)).ToList());
            }
            else
            {
                printResult(numbers.Where(x => !isEven(x)).ToList());
            }            
        }
    }
}
