using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stackParentheses = new Stack<char>();
            bool isSuccess = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    stackParentheses.Push(input[i]);
                    continue;
                }
                else if (stackParentheses.Count == 0)
                {
                    isSuccess = false;
                    break;
                }
                else if ((input[i] == '}' && stackParentheses.Peek() == '{') || (input[i] == ']' && stackParentheses.Peek() == '[') || (input[i] == ')' && stackParentheses.Peek() == '('))
                {
                    isSuccess = true;
                    stackParentheses.Pop();
                }
                else
                {
                    isSuccess = false;
                    break;
                }
            }

            if (isSuccess == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
