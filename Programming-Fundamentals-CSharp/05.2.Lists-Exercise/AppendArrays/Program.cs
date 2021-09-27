using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();

            List<int> result = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                int[] elements = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                foreach (var numbers in elements)
                {
                    result.Add(numbers);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
