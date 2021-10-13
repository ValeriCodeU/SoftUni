using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> dictionary = new Dictionary<string, string>();


            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
               
                if (command[0] == "register")
                {
                    string user = command[1];
                    string plateNumber = command[2];

                    if (!dictionary.ContainsKey(user))
                    {
                        dictionary.Add(user, plateNumber);
                        Console.WriteLine($"{user} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }                   

                }
                else if (command[0] == "unregister")
                {
                    string user = command[1];

                    if (dictionary.ContainsKey(user))
                    {
                        dictionary.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }

            foreach (var (key, value) in dictionary)
            {
                Console.WriteLine($"{key} => {value}");
            }
        }
    }
}
