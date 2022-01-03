using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> biscuits = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "No")
            {
                if (command[0] == "OutOfStock")
                {
                    for (int i = 0; i < biscuits.Count; i++)
                    {
                        if (biscuits[i] == command[1])
                        {
                            biscuits[i] = "None";
                        }
                    }
                }
                else if (command[0] == "Required")
                {
                    if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < biscuits.Count)
                    {
                        int index = int.Parse(command[2]);
                        string biscuit = command[1];

                        if (biscuits[index] != "None")
                        {
                            biscuits[index] = biscuit;
                        }
                    }
                }
                else if (command[0] == "Last")
                {
                    string biscuit = command[1];
                    biscuits.Add(biscuit);
                }

                command = Console.ReadLine().Split();
                
            }

            biscuits.RemoveAll(item => item == "None");

            Console.WriteLine(String.Join(" ", biscuits));
        }
    }
}
