using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbersDictionary = new SortedDictionary<double, int>();

            double[] numbers = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbersDictionary.ContainsKey(numbers[i]))
                {
                    numbersDictionary.Add(numbers[i], 0);
                }
                numbersDictionary[numbers[i]]++;
            }

            foreach (var item in numbersDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
