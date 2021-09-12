using System;
using System.Linq;

namespace SplitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] splitted = Console.ReadLine().Split();

            int[] numbers = new int[splitted.Length];

            for (int i = 0; i < splitted.Length; i++)
            {
                numbers[i] = int.Parse(splitted[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }           
        }
    }
}
