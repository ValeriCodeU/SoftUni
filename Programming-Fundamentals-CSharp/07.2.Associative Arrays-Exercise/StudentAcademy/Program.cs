using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                    
                }
                students[studentName].Add(grade);

            }            

            //var final = students.First(kvp => kvp.Value.Sum() / kvp.Value.Count <= 4.50);

            foreach (var item in students.Where(x => x.Value.Average() < 4.50))
            {
                students.Remove(item.Key);
            }

            foreach (var item in students.OrderByDescending(v => v.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
