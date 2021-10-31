using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            int sum = 0;

            if (words[0].Length == words[1].Length)
            {
                for (int i = 0; i < words[0].Length; i++)
                {
                    sum += words[0][i] * words[1][i];
                }
              
            }
            else if (words[0].Length < words[1].Length)
            {
                for (int i = 0; i < words[0].Length; i++)
                {
                    sum += words[0][i] * words[1][i];
                }

                for (int i = words[1].Length - 1; i >= words[0].Length; i--)
                {
                    sum += words[1][i];
                }
            }

            else
            {
                for (int i = 0; i < words[1].Length; i++)
                {
                    sum += words[1][i] * words[0][i];
                }

                for (int i = words[0].Length - 1; i >= words[1].Length; i--)
                {
                    sum += words[0][i];
                }
            }
            Console.WriteLine(sum);
        }        
    }
}
