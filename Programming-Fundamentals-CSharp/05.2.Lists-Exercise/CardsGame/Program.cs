using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayesCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayesCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool isFirstPlayerChampion = false;
            bool isSecondPlayerChampion = false;


            for (int i = 0; i < firstPlayesCards.Count; i++)
            {
                if (firstPlayesCards[i] > secondPlayesCards[i])
                {
                    int lostCard = secondPlayesCards[i];
                    int winCard = firstPlayesCards[i];
                    firstPlayesCards.Remove(winCard);
                    firstPlayesCards.Add(winCard);
                    firstPlayesCards.Add(lostCard);
                    secondPlayesCards.Remove(lostCard);
                    i -= 1;                    

                    if (secondPlayesCards.Count == 0)
                    {
                        isFirstPlayerChampion = true;
                        break;
                    }
                }

                else if (secondPlayesCards[i] > firstPlayesCards[i])
                {
                    int lostCard = firstPlayesCards[i];
                    int winCard = secondPlayesCards[i];
                    secondPlayesCards.Remove(winCard);
                    secondPlayesCards.Add(winCard);
                    secondPlayesCards.Add(lostCard);
                    firstPlayesCards.Remove(lostCard);
                    i -= 1;

                    if (firstPlayesCards.Count == 0)
                    {
                        isSecondPlayerChampion = true;
                        break;
                    }
                }
                else
                {
                    int firstCard = firstPlayesCards[i];
                    int secondCard = secondPlayesCards[i];

                    firstPlayesCards.Remove(firstCard);
                    secondPlayesCards.Remove(secondCard);
                    i -= 1;

                    if (secondPlayesCards.Count == 0)
                    {
                        isFirstPlayerChampion = true;
                        break;
                    }
                    else if (firstPlayesCards.Count == 0)
                    {
                        isSecondPlayerChampion = true;
                        break;
                    }
                }
            }


            if (isFirstPlayerChampion == true)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayesCards.Sum()}");
            }

            else if (isSecondPlayerChampion == true)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayesCards.Sum()}");
            }
        }
    }
}
