using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = x => int.Parse(x);
            Func<int, bool> even = x => x % 2 == 0;
            Func<int, int> order = x => x;

            int[] numbers = Console.ReadLine().Split(", ").Select(parser).Where(even).OrderBy(order).ToArray();

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
