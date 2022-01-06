using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, bool> isEvenNumber = x => x % 2 == 0;
            Func<int, bool> isOddNumber = x => x % 2 != 0;

            var evenNumbers = numbers.Where(isEvenNumber).ToArray();
            var oddNumbers = numbers.Where(isOddNumber).ToArray();

            Func<int, int, int> comparer = (x, y) => x.CompareTo(y);

            Array.Sort(evenNumbers, new Comparison<int>(comparer));
            Array.Sort(oddNumbers, new Comparison<int>(comparer));

            List<int> result = new List<int>();

            result.AddRange(evenNumbers);
            result.AddRange(oddNumbers);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
