using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> expressions = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "(")
                {
                    expressions.Push(i.ToString());
                }
                else if (input[i].ToString() == ")")
                {
                    int startIndex = int.Parse(expressions.Pop());
                    string sub = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(sub);
                }
            }
        }
    }
}
