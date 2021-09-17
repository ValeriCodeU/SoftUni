using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            int result = GetVowelsCount(text);
            Console.WriteLine(result);
        }

        static int GetVowelsCount(string text)
        {
            
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'o' || text[i] == 'i' || text[i] == 'u')
                {
                    counter++;
                }
            }

            int result = counter;
            return result;
        }
    }
}
