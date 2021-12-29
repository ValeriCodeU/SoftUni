using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> parserAndVat = x => double.Parse(x) * 1.2;
            
            double[] numbers = Console.ReadLine().Split(", ").Select(parserAndVat).ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
