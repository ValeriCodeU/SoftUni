using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person();

                person.Name = name;
                person.Age = age;
                people.Add(person);
            }

            string condition = Console.ReadLine();

            int ageFilter = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = x => true;

            if (condition == "younger")
            {
                filter = x => x.Age < ageFilter;
            }
            else if (condition == "older")
            {
                filter = x => x.Age >= ageFilter;
            }

            var filteredPeople = people.Where(filter);

            string format = Console.ReadLine();

            Func<Person, string> print = x => x.Name + " - " + x.Age;

            if (format == "name age")
            {
                print = x => x.Name + " - " + x.Age;
            }
            else if (format == "name")
            {
                print = x => x.Name;
            }
            else if (format == "age")
            {
                print = x => x.Age.ToString();
            }

            var resultPeople = filteredPeople.Select(print);

            foreach (var personAsString in resultPeople)
            {
                Console.WriteLine(personAsString);
            }
        }
    }
}
