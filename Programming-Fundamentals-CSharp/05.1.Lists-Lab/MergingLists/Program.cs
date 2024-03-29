﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultList = new List<int>();            

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    resultList.Add(firstList[i]);
                }
            }

            else
            {
                for (int i = firstList.Count; i < secondList.Count; i++)
                {
                    resultList.Add(secondList[i]);
                }
            }

            Console.WriteLine(String.Join(" ", resultList));
        }
    }
}
