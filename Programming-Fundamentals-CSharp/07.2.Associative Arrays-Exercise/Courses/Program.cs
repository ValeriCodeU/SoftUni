using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" : ");

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            while (command[0] != "end")
            {
                string courseName = command[0];
                string student = command[1];

                if (!dictionary.ContainsKey(courseName))
                {
                    dictionary.Add(courseName, new List<string>());
                }

                dictionary[courseName].Add(student);

                command = Console.ReadLine().Split(" : ");
            }

            foreach (var item in dictionary.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
               
                var result = item.Value.OrderBy(x => x).ToList();

                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine($"-- {result[i]}");
                }
            }            
        }
    }
}
