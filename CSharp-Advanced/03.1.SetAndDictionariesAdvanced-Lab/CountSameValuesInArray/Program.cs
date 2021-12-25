using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> countDictionary = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!countDictionary.ContainsKey(numbers[i]))
                {
                    countDictionary.Add(numbers[i], 0);
                }
                countDictionary[numbers[i]]++;
            }

            foreach (var number in countDictionary)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
