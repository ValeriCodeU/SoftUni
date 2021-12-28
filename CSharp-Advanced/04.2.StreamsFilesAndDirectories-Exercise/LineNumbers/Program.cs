using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = File.ReadAllLines("../../../text.txt");
            string[] result = new string[line.Length];

            for (int i = 0; i < line.Length; i++)
            {
                int letterCount = 0;
                int punctCount = 0;

                string currentLine = line[i];

                foreach (var item in currentLine)
                {
                    if (char.IsLetter(item))
                    {
                        letterCount++;
                    }
                    else if (char.IsPunctuation(item))
                    {
                        punctCount++;
                    }
                }
               
                result[i] = $"Line {i + 1}: {line[i]} ({letterCount})({punctCount})";
            }           

            File.WriteAllLines("../../../output.txt", result);
        }
    }
}
