using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicalCompounds = Console.ReadLine().Split();

                for (int j = 0; j < chemicalCompounds.Length; j++)
                {
                    periodicTable.Add(chemicalCompounds[j]);
                }
            }

            Console.WriteLine(String.Join(" ", periodicTable));
        }
    }
}
