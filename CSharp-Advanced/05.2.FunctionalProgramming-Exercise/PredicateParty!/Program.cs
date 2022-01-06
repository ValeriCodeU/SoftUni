using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            Func<string, string, bool> filterStart = (x, y) => x.StartsWith(y);
            Func<string, string, bool> filterEnd = (x, y) => x.EndsWith(y);
            Func<int, int, bool> filterLength = (x, y) => x == y;

            for (int i = 0; i < people.Count; i++)
            {
                dictionary.Add(people[i], new List<string>());
                dictionary[people[i]].Add(people[i]);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Party!")
                {
                    break;
                }

                if (command[0] == "Remove")
                {
                    if (command[1] == "EndsWith")
                    {
                        foreach (var item in dictionary)
                        {
                            if (filterEnd(item.Key, command[2]))
                            {
                                dictionary.Remove(item.Key);
                            }
                        }
                    }
                    else if (command[1] == "StartsWith")
                    {
                        foreach (var item in dictionary)
                        {
                            if (filterStart(item.Key, command[2]))
                            {
                                dictionary.Remove(item.Key);
                            }
                        }
                    }

                    else if (command[1] == "Length")
                    {
                        foreach (var item in dictionary)
                        {
                            if (filterLength(int.Parse(command[2]), item.Key.Length))
                            {
                                dictionary.Remove(item.Key);
                            }
                        }
                    }
                }

                else if (command[0] == "Double")
                {
                    if (command[1] == "EndsWith")
                    {
                        foreach (var item in dictionary)
                        {
                            if (filterEnd(item.Key, command[2]))
                            {
                                int currentCount = item.Value.Count;

                                for (int i = 0; i < currentCount; i++)
                                {
                                    item.Value.Add(item.Key);
                                }
                            }
                        }

                    }
                    else if (command[1] == "StartsWith")
                    {

                        foreach (var item in dictionary)
                        {
                            if (filterStart(item.Key, command[2]))
                            {
                                int currentCount = item.Value.Count;

                                for (int i = 0; i < currentCount; i++)
                                {
                                    item.Value.Add(item.Key);
                                }
                            }
                        }

                    }
                    else if (command[1] == "Length")
                    {
                        foreach (var item in dictionary)
                        {
                            if (filterLength(int.Parse(command[2]), item.Key.Length))
                            {
                                int currentCount = dictionary[item.Key].Count;

                                for (int i = 0; i < currentCount; i++)
                                {
                                    dictionary[item.Key].Add(item.Key);
                                }
                            }
                        }
                    }
                }
            }

            List<string> resultParty = new List<string>();

            if (dictionary.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                foreach (var nameCollection in dictionary)
                {
                    foreach (var partyName in nameCollection.Value)
                    {
                        resultParty.Add(partyName);
                    }
                }

                Console.WriteLine(String.Join(", ", resultParty) + " are going to the party!");
            }
        }
    }
}
