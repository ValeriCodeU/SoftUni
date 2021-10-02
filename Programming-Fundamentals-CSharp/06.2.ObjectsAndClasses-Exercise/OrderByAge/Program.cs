using System;
using System.Collections.Generic;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> students = new List<Person>();

            string[] input = Console.ReadLine().Split();
 
            while (input[0] != "End")
            {
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person student = new Person();

                student.Name = name;
                student.ID = id;
                student.Age = age;

                students.Add(student);

                input = Console.ReadLine().Split();
            }

            for (int i = 0; i < students.Count; i++)
            {
                int minIndex = i;
                for (int j = i; j < students.Count; j++)
                {
                    if (students[j].Age < students[minIndex].Age )
                    {
                        minIndex = j;
                    }
                }

                Person temp = students[minIndex];
                students[minIndex] = students[i];
                students[i] = temp;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }
        }
    }
}
