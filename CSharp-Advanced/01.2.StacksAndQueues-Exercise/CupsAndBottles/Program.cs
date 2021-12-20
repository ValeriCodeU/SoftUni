using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cups = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bottles = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> bottleStack = new Stack<int>(bottles);
            Queue<int> cupQueue = new Queue<int>(cups);

            int wastedWaterLitters = 0;

            while (bottleStack.Count > 0 && cupQueue.Count > 0)
            {
                if (bottleStack.Peek() >= cupQueue.Peek())
                {
                    int currentWastedWater = bottleStack.Pop() - cupQueue.Dequeue();
                    wastedWaterLitters += currentWastedWater;
                }
                else
                {                    
                    int currentCupCapacity = cupQueue.Dequeue() - bottleStack.Pop();
                    cupQueue.Enqueue(currentCupCapacity);

                    for (int i = 0; i < cupQueue.Count - 1; i++)
                    {
                        cupQueue.Enqueue(cupQueue.Dequeue());
                    }
                }
            }

            if (bottleStack.Count == 0 && cupQueue.Count > 0)
            {
                Console.WriteLine($"Cups: {String.Join(" ", cupQueue)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottleStack)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWaterLitters}");
        }
    }
}
