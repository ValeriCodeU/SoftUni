using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Queue<string> songsQueue = new Queue<string>(input);

            while (songsQueue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.Contains("Play"))
                {
                    songsQueue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    command = command.Remove(0, 4);

                    if (!songsQueue.Contains(command))
                    {
                        songsQueue.Enqueue(command);
                    }
                    else
                    {
                        Console.WriteLine($"{command} is already contained!");
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", songsQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
