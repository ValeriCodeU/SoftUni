using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();

            for (int i = 0; i < values.Length / 2; i++)
            {
                string temp = values[i];
                values[i] = values[values.Length - 1 - i];
                values[values.Length - 1 - i] = temp;
            }

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }
        }
    }
}
