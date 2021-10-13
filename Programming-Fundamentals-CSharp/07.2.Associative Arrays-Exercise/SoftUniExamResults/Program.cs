using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> studentsResult = new Dictionary<string, List<int>>();
            Dictionary<string, List<string>> languageCount = new Dictionary<string, List<string>>();
          
            string input = Console.ReadLine();
            

            while (input != "exam finished")
            {
                string[] command = input.Split("-");

                if (command[1] != "banned")
                {

                    if (!languageCount.ContainsKey(command[1]))
                    {
                        languageCount.Add(command[1], new List<string>());
                       
                    }
                    languageCount[command[1]].Add(command[1]);

                    if (!studentsResult.ContainsKey(command[0]))
                    {
                        studentsResult.Add(command[0], new List<int>());
                    }                    

                    if (studentsResult[command[0]].Count == 0)
                    {
                        studentsResult[command[0]].Add(int.Parse(command[2]));
                    }

                    if (studentsResult[command[0]].Any(v => v < int.Parse(command[2])))
                    {
                        studentsResult[command[0]].RemoveAll(x => x <= int.Parse(command[2]));
                        studentsResult[command[0]].Add(int.Parse(command[2]));
                    }                    
                }
                else
                {
                    if (studentsResult.ContainsKey(command[0]))
                    {
                        studentsResult.Remove(command[0]);
                    }
                }

                input = Console.ReadLine();
                
            }

            Console.WriteLine("Results:");
            foreach (var item in studentsResult.OrderByDescending(v => v.Value.Max()).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value[0]}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageCount.OrderByDescending(v => v.Value.Count).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Count}");
            }
            
           
        }
    }
}
