using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGrades = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> gradesDictionary = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numOfGrades; i++)
            {
                string[] student = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = student[0];
                decimal grade = decimal.Parse(student[1]);

                if (!gradesDictionary.ContainsKey(name))
                {
                    gradesDictionary.Add(name, new List<decimal>());
                }

                gradesDictionary[name].Add(grade);
            }

            //gradesDictionary = gradesDictionary.OrderByDescending(v => v.Value.Average()).ToDictionary(k => k.Key, v => v.Value);

            foreach (var student in gradesDictionary)
            {
                Console.Write($"{student.Key} ->");
                foreach (var grade in student.Value)
                {
                    Console.Write($" {grade:f2}");
                }
                Console.WriteLine($" (avg: {student.Value.Average():f2})");
            }
        }
    }
}
