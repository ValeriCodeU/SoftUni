using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            string joinded = String.Join(" ", arr);

            Console.WriteLine(joinded);
        }
    }
}
