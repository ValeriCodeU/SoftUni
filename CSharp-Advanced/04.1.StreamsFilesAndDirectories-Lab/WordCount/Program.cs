using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string textLine = reader.ReadLine();

                Dictionary<string, int> counter = new Dictionary<string, int>();
               

                using (StreamReader readerWords = new StreamReader("../../../words.txt"))
                {
                    string inputWords = readerWords.ReadLine();
                    string[] words = inputWords.Split();

                    while (textLine != null)
                    {
                        string[] currentRow = textLine.Split(new char[] { ' ', ',', '.', '-', '!', '?', ':' }, StringSplitOptions.RemoveEmptyEntries);

                        int wordsCount = 0;

                        for (int i = 0; i < words.Length; i++)
                        {
                            for (int j = 0; j < currentRow.Length; j++)
                            {
                                if (words[i] == currentRow[j].ToLower())
                                {
                                    wordsCount++;

                                    if (!counter.ContainsKey(words[i]))
                                    {
                                        counter.Add(words[i], 0);
                                    }
                                    counter[words[i]]++;

                                }
                            }
                        }

                        textLine = reader.ReadLine();
                    }

                    using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                    {
                        foreach (var wordCount in counter.OrderByDescending(v => v.Value))
                        {
                            writer.WriteLine($"{wordCount.Key} - {wordCount.Value}");
                        }
                    }
                }                
            }
        }
    }
}
