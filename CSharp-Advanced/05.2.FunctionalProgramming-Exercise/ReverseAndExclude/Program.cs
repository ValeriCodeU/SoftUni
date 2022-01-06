using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int n = int.Parse(Console.ReadLine());

            Func<int, bool> isNotDivisible = x => x % n != 0;

            numbers = numbers.Where(isNotDivisible).ToArray();

            Action<int[]> printer = numbers => Console.WriteLine(String.Join(" ", numbers));

            printer(numbers);
        }
    }
}
