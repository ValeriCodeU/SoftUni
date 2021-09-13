using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());

            int[] peopleLine = new int[countOfWagons];

            int sum = 0;

            for (int i = 0; i < countOfWagons; i++)
            {
                peopleLine[i] = int.Parse(Console.ReadLine());
                sum += peopleLine[i];
            }

            for (int i = 0; i < countOfWagons; i++)
            {
                Console.Write(peopleLine[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(sum);
        }
    }
}
