using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());

            int cake = cakeLength * cakeWidth;

            string input = Console.ReadLine();
            int countPieces = 0;

            while (input != "STOP") 
            {
                int numOfPieces = int.Parse(input);
                countPieces += numOfPieces;

                if (countPieces > cake)
                {
                    break;
                }

                input = Console.ReadLine();
            }          
            if (input == "STOP")
            {
                Console.WriteLine($"{cake - countPieces} pieces are left.");
            }

            else
            {
                Console.WriteLine($"No more cake left! You need {countPieces - cake} pieces more.");
            }
        }
    }
}
