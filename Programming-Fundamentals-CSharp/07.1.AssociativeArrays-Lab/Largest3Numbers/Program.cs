using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse). OrderByDescending(n => n).ToList();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).Take(3).ToArray();
           
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
