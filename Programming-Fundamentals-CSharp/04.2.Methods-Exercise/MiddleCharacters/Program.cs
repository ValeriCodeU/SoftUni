using System;
using System.Linq;

namespace MiddleCharacters
{
    class Program
    {        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = GetMiddleCharacter(input);
            Console.WriteLine(result);            
        }

        static string GetMiddleCharacter(string input)
        {
            string result = "";

            if (input.Length % 2 != 0)
            {
                

                for (int i = 1; i < input.Length; i++)
                {
                    if (i == (input.Length - 1) / 2)
                    {
                        result = $"{input[i]}";
                        break;
                    }
                }                
            }

            else
            {
                for (int i = 1; i < input.Length; i++)
                {
                    if (i == input.Length / 2)
                    {
                        result = $"{input[i - 1]}{input[i]}";
                        break;
                    }
                }
            }

            return result;
        }
    }
}
