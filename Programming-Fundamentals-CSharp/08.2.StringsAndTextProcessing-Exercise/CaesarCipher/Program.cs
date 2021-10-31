using System;
using System.Collections.Generic;
using System.Linq;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {            
            string text = Console.ReadLine();

            List<char> finalText = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                int number = text[i];
                char currentSymbol = Convert.ToChar(number + 3);
                finalText.Add(currentSymbol);
            }

            Console.WriteLine(String.Join("", finalText));
        }
    }
}
