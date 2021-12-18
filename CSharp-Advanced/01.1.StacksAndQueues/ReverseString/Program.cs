using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ReverseString
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversed = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reversed.Push(input[i]);
            }

            while (reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }
        }
    }
}
