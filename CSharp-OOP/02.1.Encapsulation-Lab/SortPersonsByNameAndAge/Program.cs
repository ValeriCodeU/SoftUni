using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{

    public class StartUp
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);              
                
            }

            persons = persons.OrderBy(n => n.FirstName).ThenBy(a => a.Age).ToList();            

            
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

}
