﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            for (int i = 0; i < numbers.Count / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1 - i];
            }

            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i <= numbers.Count / 2; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
