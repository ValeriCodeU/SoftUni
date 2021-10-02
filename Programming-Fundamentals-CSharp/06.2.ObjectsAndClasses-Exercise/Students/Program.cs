using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{

    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> totalStudents = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                totalStudents.Add(new Student(firstName, lastName, grade));
                
             }

            totalStudents = totalStudents.OrderBy(a => a.Grade).ToList();
            totalStudents = totalStudents.OrderByDescending(a => a.Grade).ToList();
            //totalStudents.Reverse();

            foreach (var students in totalStudents)
            {
                Console.WriteLine(students);
            }
        }
    }
}
