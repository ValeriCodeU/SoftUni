using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();           

            string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            string[] phoneNumbers = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(", ", phoneNumbers));
        }
    }
}
