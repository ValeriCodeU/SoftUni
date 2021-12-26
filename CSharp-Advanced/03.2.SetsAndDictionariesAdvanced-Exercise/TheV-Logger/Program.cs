using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, List<int>> vloggerSystem = new Dictionary<string, List<int>>();

            Dictionary<string, List<string>> followers = new Dictionary<string, List<string>>();

            while (input[0] != "Statistics")
            {
                if (input[1] == "joined")
                {
                    string vloggerName = input[0];

                    if (!vloggerSystem.ContainsKey(vloggerName) && !followers.ContainsKey(vloggerName))
                    {
                        vloggerSystem.Add(vloggerName, new List<int>());
                        vloggerSystem[vloggerName].Add(0); 
                        vloggerSystem[vloggerName].Add(0);
                        followers.Add(vloggerName, new List<string>());                      
                    }
                }
                else if (input[1] == "followed")
                {
                    string followingName = input[0];
                    string vloggerName = input[2];

                    if (!vloggerSystem.ContainsKey(vloggerName) || !vloggerSystem.ContainsKey(followingName))
                    {
                        input = Console.ReadLine().Split();
                        continue;
                    }

                    if (followingName == vloggerName || followers[vloggerName].Contains(followingName))
                    {
                        input = Console.ReadLine().Split();
                        continue;
                    }

                    if (vloggerSystem.ContainsKey(vloggerName))
                    {
                        vloggerSystem[vloggerName][0]++;
                        vloggerSystem[followingName][1]++;

                        if (followers.ContainsKey(vloggerName))
                        {
                            followers[vloggerName].Add(followingName);
                        }
                    }
                }

                input = Console.ReadLine().Split();
            }

            int count = 0;

            Console.WriteLine($"The V-Logger has a total of {vloggerSystem.Count} vloggers in its logs.");
            foreach (var vlogger in vloggerSystem.OrderByDescending(v => v.Value[0]).ThenBy(v => v.Value[1]))
            {
                count++;
                if (count == 1)
                {
                    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value[0]} followers, {vlogger.Value[1]} following");
                    foreach (var follower in followers[vlogger.Key].OrderBy(v => v))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                else
                {
                    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value[0]} followers, {vlogger.Value[1]} following");
                }
            }
        }
    }
}
