using System;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Action<string[]> action = x => Console.WriteLine(String.Join("\n", x));

            string[] input = Console.ReadLine().Split();

            action(input);
        }
    }
}
