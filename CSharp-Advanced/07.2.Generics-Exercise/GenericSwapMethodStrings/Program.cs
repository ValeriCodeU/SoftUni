using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }

            int[] commandIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.Swap(commandIndexes[0], commandIndexes[1]);

            Console.WriteLine(box);
        }


    }
}
