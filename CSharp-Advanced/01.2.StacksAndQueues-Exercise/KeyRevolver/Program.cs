using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int missionPrice = int.Parse(Console.ReadLine());

            Stack<int> bulletStack = new Stack<int>(bullets);
            Queue<int> lockQueue = new Queue<int>(locks);

            int countSize = 0;            
            int totalBullet = bulletStack.Count;

            while (bulletStack.Count > 0 && lockQueue.Count > 0)
            {
                countSize++;
               
                if (bulletStack.Peek() <= lockQueue.Peek())
                {
                    lockQueue.Dequeue();
                    bulletStack.Pop();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    bulletStack.Pop();
                    Console.WriteLine("Ping!");
                }

                if (countSize >= sizeGunBarrel && bulletStack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    countSize = 0;
                }
            }

            if (bulletStack.Count == 0 && lockQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {lockQueue.Count}");
            }
            else
            {
                int bulletsMoney = (totalBullet - bulletStack.Count) * bulletPrice;
                int totalMoneyEarned = missionPrice - bulletsMoney;
                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${totalMoneyEarned}");                
            }
        }
    }
}
