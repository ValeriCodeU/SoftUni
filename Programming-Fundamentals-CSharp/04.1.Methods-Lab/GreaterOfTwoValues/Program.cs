using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (type == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondInt = int.Parse(secondValue);
                Console.WriteLine(GetMax(firstInt, secondInt));
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                Console.WriteLine((char)GetMax(firstChar, secondChar));
            }
            else if (type == "string")
            {
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }

        static string GetMax(string firstValue, string secondValue)
        {
            int result = firstValue.CompareTo(secondValue);
            

            if (result > 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
            

        }

        static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
            
        }
    }
}
