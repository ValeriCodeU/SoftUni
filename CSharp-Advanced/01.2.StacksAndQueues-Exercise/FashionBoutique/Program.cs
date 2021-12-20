using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quantityOfClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacityOfRack = int.Parse(Console.ReadLine());
            int capacityConst = capacityOfRack;

            Stack<int> clothesStack = new Stack<int>(quantityOfClothes);

            int countRack = 1;

            while (clothesStack.Count > 0)
            {
                int currentCloths = clothesStack.Pop();
                capacityOfRack -= currentCloths;

                if (capacityOfRack < 0)
                {
                    countRack++;
                    capacityOfRack = capacityConst - currentCloths;
                }                
            }
            Console.WriteLine(countRack);
        }
    }
}
