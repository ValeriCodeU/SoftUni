using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int swapPosition = random.Next(words.Count);
                string temp = words[i];
                words[i] = words[swapPosition];
                words[swapPosition] = temp;

            }

            Console.WriteLine(String.Join("\n", words));
        }
    }
}
