using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string command = Console.ReadLine();
            int counter = 0;
            string key = "";

            while (command != "stop")
            {               
                counter++;

                if (counter % 2 != 0)
                {
                    key = command;
                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, 0);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }                
                else if (counter % 2 == 0)
                {
                    dictionary[key] += int.Parse(command);
                }

                command = Console.ReadLine();

            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
