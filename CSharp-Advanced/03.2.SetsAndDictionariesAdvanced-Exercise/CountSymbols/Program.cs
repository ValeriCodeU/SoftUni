using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> times = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!times.ContainsKey(text[i]))
                {
                    times.Add(text[i], 0);
                }
                times[text[i]]++;
            }

            foreach (var time in times)
            {
                Console.WriteLine($"{time.Key}: {time.Value} time/s");
            }
        }
    }
}
