using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> result = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result.Enqueue(numbers[i]);
                }
            }
            
            while (result.Count > 0)
            {
                if (result.Count == 1)
                {
                    Console.WriteLine(result.Dequeue());
                }
                else
                {
                    Console.Write($"{result.Dequeue()}{", "}");
                }                
            }
        }
    }
}
