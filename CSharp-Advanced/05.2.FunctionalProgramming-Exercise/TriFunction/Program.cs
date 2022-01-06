using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> filterValidator = (name, sumOfChars) => name.Sum(x => x) >= sumOfChars;

            Func<List<string>, int, Func<string, int, bool>, string> filterResult = (collection, number, func)
                => collection.FirstOrDefault(x => filterValidator(x, number));

            string foundName = filterResult(names, n, filterValidator);

            Console.WriteLine(foundName);           
        }        
    }
}
