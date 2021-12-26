using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setTwo = new HashSet<int>();

            for (int i = 0; i < size[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                setOne.Add(number);
            }

            for (int i = 0; i < size[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                setTwo.Add(number);
            }

            List<int> unique = new List<int>();

            unique = (setOne.Intersect(setTwo)).ToList();

            Console.WriteLine(String.Join(" ", unique));
        }
    }
}
