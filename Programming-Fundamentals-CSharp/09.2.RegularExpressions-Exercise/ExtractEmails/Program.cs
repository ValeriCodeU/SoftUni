using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            string pattern = @"(?<=\s)([A-Za-z0-9]+[\.\-]*[A-Za-z0-9]+)@([A-Za-z]+(([-.]*)[A-Za-z]+)*\.[a-z]{2,})";

            MatchCollection emails = Regex.Matches(input, pattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
