using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            string result = GetSymbols(a, b);
            Console.WriteLine(result);
        }

        static string GetSymbols(char a, char b)
        {
            string result = "";

            if (a < b)
            {
                for (char i = a; i < b; i++)
                {
                    if (i == a)
                    {
                        continue;
                    }
                    else
                    {
                        result += i + " ";
                    }
                }

                return result;
            }

            else
            {
                for (char i = b; i < a; i++)
                {
                    if (i == b)
                    {
                        continue;
                    }
                    else
                    {
                        result += i + " ";
                    }

                }

                return result;
            }
        }
    }
}
