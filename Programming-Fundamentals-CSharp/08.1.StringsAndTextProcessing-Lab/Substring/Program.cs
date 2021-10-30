using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            string modifyString = Console.ReadLine();

            int index = modifyString.IndexOf(word);

            while (index >= 0)
            {
                modifyString = modifyString.Remove(index, word.Length);
                index = modifyString.IndexOf(word);
            }

            Console.WriteLine(modifyString);
        }
    }
}
