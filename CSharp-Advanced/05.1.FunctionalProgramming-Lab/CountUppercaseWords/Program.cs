using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            Func<string, bool> upper = x => char.IsUpper(x[0]);

            text = text.Where(upper).ToArray();

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
