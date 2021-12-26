using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, string> uni = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "end of contests")
            {
                string contest = input[0];
                string password = input[1];

                if (!uni.ContainsKey(contest))
                {
                    uni.Add(contest, password);
                }

                input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
            }

            string[] resultContest = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);

            while (resultContest[0] != "end of submissions")
            {

                string contest = resultContest[0];
                string password = resultContest[1];
                string username = resultContest[2];
                int points = int.Parse(resultContest[3]);

                if (uni.ContainsKey(contest) && uni[contest] == password)
                {
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                    }
                    if (!students[username].ContainsKey(contest))
                    {
                        students[username].Add(contest, 0);
                    }

                    if (students[username][contest] < points && students[username].ContainsKey(contest))
                    {
                        students[username][contest] = points;
                    }
                }

                resultContest = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            int bestResult = int.MinValue;
            string bestStudent = "";
            

            foreach (var student in students)
            {
                int sum = 0;
                foreach (var points in student.Value)
                {
                    sum += points.Value;
                }

                if (sum > bestResult)
                {
                    bestResult = sum;
                    bestStudent = student.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestResult} points.");
            Console.WriteLine("Ranking");
            foreach (var student in students.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{student.Key}");
                foreach (var result in student.Value.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"#  {result.Key} -> {result.Value}");
                }
            }
        }
    }
}
