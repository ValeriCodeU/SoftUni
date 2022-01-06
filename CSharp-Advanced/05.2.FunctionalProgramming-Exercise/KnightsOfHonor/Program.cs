using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>> sirNames = name => name.ForEach(name => Console.WriteLine("Sir " + name));

            List<string> names = Console.ReadLine().Split().ToList();

            sirNames(names);
        }
    }
}
