using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            while (command != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] commandAdd = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = commandAdd[0];
                    string forceUser = commandAdd[1];

                    if (!dictionary.ContainsKey(forceSide))
                    {
                        dictionary.Add(forceSide, new List<string>());
                    }                    

                    if (!dictionary.Any(x => x.Value.Contains(forceUser)))
                    {
                        dictionary[forceSide].Add(forceUser);
                    }
                }
                else if (command.Contains("->"))
                {
                    string[] commandEdit = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = commandEdit[0];
                    string forceSide = commandEdit[1];

                    if (!dictionary.ContainsKey(forceSide))
                    {
                        dictionary.Add(forceSide, new List<string>());
                    }

                    if (!dictionary.Any(x => x.Value.Contains(forceUser)))
                    {                        
                        dictionary[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        dictionary = dictionary.Where(v => ! v.Value.Contains(forceUser)).ToDictionary(x => x.Key, x => x.Value);
                        dictionary[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }

                command = Console.ReadLine();
            }

            var final = dictionary.Where(v => v.Value.Count > 0).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in final.OrderByDescending(v => v.Value.Count).ThenBy(k => k.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                Console.Write("! ");
                Console.WriteLine(String.Join("\n! ", item.Value.OrderBy(x => x)));
            }            
        }
    }
}
