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

            string letterPattern = @"[A-Za-z]";
            string punctuationPattern = @"[-,.?!']";

            for (int i = 0; i < line.Length; i++)
            {
                MatchCollection letters = Regex.Matches(line[i], letterPattern);
                MatchCollection punctuations = Regex.Matches(line[i], punctuationPattern);

                result[i] = $"Line {i + 1}: {line[i]} ({letters.Count})({punctuations.Count})";
            }

            File.WriteAllLines("../../../output.txt", result);
        }
    }
}
