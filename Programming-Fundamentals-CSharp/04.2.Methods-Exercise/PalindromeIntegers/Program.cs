using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isPalindrome = IsPalindrome(input);

                Console.WriteLine(isPalindrome);               

                input = Console.ReadLine();
            }
        }
        private static bool IsPalindrome(string input)
        {
            string reversedNum = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedNum += input[i];
            }

            bool isPalindrome = reversedNum == input;

            return isPalindrome;
        }
    }
}
