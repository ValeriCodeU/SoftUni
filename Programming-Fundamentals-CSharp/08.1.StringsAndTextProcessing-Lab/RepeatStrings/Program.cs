using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                int n = words[i].Length;

                for (int j = 0; j < n; j++)
                {
                    result += words[i];
                }

            }

            Console.WriteLine(result);
        }
    }
}
