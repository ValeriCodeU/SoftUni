using System;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, bool> iSValidName = x => x.Length <= n;

            foreach (var name in names)
            {
                if (iSValidName(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
