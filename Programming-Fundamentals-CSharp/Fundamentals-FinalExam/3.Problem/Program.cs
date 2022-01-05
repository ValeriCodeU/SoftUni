using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(":");

            Dictionary<string, List<int>> battle = new Dictionary<string, List<int>>();

            while (command[0] != "Results")
            {
                if (command[0] == "Add")
                {
                    if (!battle.ContainsKey(command[1]))
                    {
                        battle.Add(command[1], new List<int>());
                        battle[command[1]].Add(int.Parse(command[2])); //health
                        battle[command[1]].Add(int.Parse(command[3])); //energy
                    }
                    else
                    {
                        battle[command[1]][0] += int.Parse(command[2]);
                    }                  
                }
                else if (command[0] == "Attack")
                {
                    if (battle.ContainsKey(command[1]) && battle.ContainsKey(command[2]))
                    {
                        battle[command[2]][0] -= int.Parse(command[3]);
                        battle[command[1]][1] -= 1;

                        if (battle[command[2]][0] <= 0)
                        {
                            battle.Remove(command[2]);
                            Console.WriteLine($"{command[2]} was disqualified!");
                        }
                        if (battle[command[1]][1] <= 0)
                        {
                            battle.Remove(command[1]);
                            Console.WriteLine($"{command[1]} was disqualified!");
                        }
                    }
                }
                else if (command[0] == "Delete")
                {
                    if (command[1] == "All")
                    {
                        battle.Clear();
                    }
                    else
                    {
                        battle.Remove(command[1]);
                    }
                }

                command = Console.ReadLine().Split(":");               
            }

            Console.WriteLine($"People count: {battle.Count}");
            foreach (var person in battle.OrderByDescending(v => v.Value[0]).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{person.Key} - {person.Value[0]} - {person.Value[1]}");
            }
        }
    }
}
