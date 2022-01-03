using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();

            List<string> newDeck = new List<string>().ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Ready")
            {
                if (command[0] == "Add")
                {
                    string card = command[1];

                    if (cards.Contains(card))
                    {
                        newDeck.Add(card);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }

                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    string card = command[1];

                    if (!cards.Contains(card) || index < 0 || index > newDeck.Count)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        newDeck.Insert(index, card);
                    }
                }
                else if (command[0] == "Remove")
                {
                    string card = command[1];

                    if (newDeck.Contains(card))
                    {
                        newDeck.Remove(card);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command[0] == "Swap")
                {
                    string firstCard = command[1];
                    string secondCard = command[2];

                    for (int i = 0; i < newDeck.Count; i++)
                    {
                        if (newDeck[i] == firstCard)
                        {
                            newDeck[i] = secondCard;
                        }
                        else if (newDeck[i] == secondCard)
                        {
                            newDeck[i] = firstCard;
                        }
                    }
                }
                else if (command[0] == "Shuffle")
                {
                    newDeck.Reverse();
                }
                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ", newDeck));
        }
    }
}
