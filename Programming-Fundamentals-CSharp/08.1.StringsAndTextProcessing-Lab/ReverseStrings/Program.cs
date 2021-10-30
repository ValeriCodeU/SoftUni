using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();


            while (word != "end")
            {
                string result = "";

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }
                Console.WriteLine($"{word} = {result}");
                

                word = Console.ReadLine();
            }
        }
    }
}
