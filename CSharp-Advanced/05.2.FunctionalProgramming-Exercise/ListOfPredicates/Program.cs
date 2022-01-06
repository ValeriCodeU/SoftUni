using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = Enumerable.Range(1, n).ToList();

            Func<int, int, bool> predicate = (x, y) => x % y == 0;

            foreach (var number in numbers)
            {
                if (dividers.All(x => predicate(number, x)))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
