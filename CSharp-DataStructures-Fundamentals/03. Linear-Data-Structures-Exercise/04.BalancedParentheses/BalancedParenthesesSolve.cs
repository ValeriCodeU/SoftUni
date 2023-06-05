namespace Problem04.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class BalancedParenthesesSolve : ISolvable
    {
        public bool AreBalanced(string parentheses)
        {

            if (parentheses.Length % 2 == 1 || String.IsNullOrWhiteSpace(parentheses))
            {
                return false;
            }

            var stack = new Stack<char>(parentheses.Length / 2);

            for (int i = 0; i < parentheses.Length; i++)
            {
                var currentChar = parentheses[i];
                char expectedChar = default;

                if (currentChar == ')')
                {
                    expectedChar = '(';
                }
                else if (currentChar == ']')
                {
                    expectedChar = '[';

                }
                else if (currentChar == '}')
                {
                    expectedChar = '{';

                }
                else
                {
                    stack.Push(currentChar);
                }



                if (expectedChar == default)
                {
                    continue;
                }

                if (stack.Pop() != expectedChar)
                {
                    return false;
                }

            }

            return stack.Count == 0;
        }
    }
}
