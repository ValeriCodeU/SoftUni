using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {

                if (!dictionary.ContainsKey(words[i].ToLower()))
                {
                    dictionary.Add(words[i].ToLower(), 0);
                }
                dictionary[words[i].ToLower()]++;
            }

            Dictionary<string, int> dictionary2 = dictionary.Where(i => i.Value % 2 != 0).ToDictionary(p => p.Key, p => p.Value);

            Console.WriteLine(String.Join(" ", dictionary2.Keys));
        }
    }
}
