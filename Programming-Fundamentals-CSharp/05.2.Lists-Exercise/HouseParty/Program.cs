using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];


                if (names.Count == 0 && command.Length < 4)
                {
                    names.Add(name);
                }
                else if (command.Length < 4)
                {
                    for (int j = 0; j < names.Count; j++)
                    {
                        if (names[j] == name)
                        {
                            Console.WriteLine($"{name} is already in the list!");
                            break;

                        }

                        if (j + 1 == names.Count)
                        {
                            names.Add(name);
                            break;
                        }
                    }
                }
                else
                {
                    bool isDeleted = false;
                    //names.RemoveAll(x => x == name);
                    for (int k = 0; k < names.Count; k++)
                    {
                        if (names[k] == name)
                        {
                            names.Remove(name);
                            isDeleted = true;
                            break;
                        }
                    }

                    if (isDeleted == false)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }


        }
    }
}
