using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int lostCount = int.Parse(Console.ReadLine());
           
            Queue<string> players = new Queue<string>(input);

            int count = 0;

            while (players.Count > 1)
            {
                count++;

                if (count == lostCount)
                {
                    Console.WriteLine($"Removed {players.Dequeue()}");
                    count = 0;
                }
                else
                {
                    string player = players.Dequeue();
                    players.Enqueue(player);
                }               
            }
            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
