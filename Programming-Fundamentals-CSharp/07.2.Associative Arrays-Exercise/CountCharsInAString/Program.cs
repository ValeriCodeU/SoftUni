using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string oneWord = words[i];

                for (int j = 0; j < oneWord.Length; j++)
                {
                    char letter = oneWord[j];
                    if (!dictionary.ContainsKey(letter))
                    {
                        dictionary.Add(letter, 0);
                    }
                    dictionary[letter]++;
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
