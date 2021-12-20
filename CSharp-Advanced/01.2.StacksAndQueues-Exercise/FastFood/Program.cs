using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] ordersQuantity = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>();

            for (int i = 0; i < ordersQuantity.Length; i++)
            {
                orders.Enqueue(ordersQuantity[i]);
            }
            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (orders.Peek() <= quantityOfFood)
                {
                    quantityOfFood -= orders.Peek();
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
                    break;
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
