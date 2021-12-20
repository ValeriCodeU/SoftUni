using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            //string input = Console.ReadLine();

            Stack<string> result = new Stack<string>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                result.Push(array[i]);
            }

            while (result.Count > 1)
            {
                string lastElement = result.Pop();
                string expression = result.Pop();
                string secondElemenet = result.Pop();

                if (expression == "+")
                {
                    int resultSum = int.Parse(lastElement) + int.Parse(secondElemenet);
                    lastElement = resultSum.ToString();
                    result.Push(lastElement);
                }
                else
                {
                    int resultSub = int.Parse(lastElement) - int.Parse(secondElemenet);
                    lastElement = resultSub.ToString();
                    result.Push(lastElement);
                }
            }

            Console.WriteLine(result.Peek());
        }
    }
}
