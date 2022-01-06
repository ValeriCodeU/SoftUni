using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            Dictionary<string, Predicate<string>> predicates = new Dictionary<string, Predicate<string>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(";");
                string action = command[0];

                if (action == "Print")
                {
                    break;
                }

                string predicateAction = command[1];
                string value = command[2];
                string keyName = predicateAction + ":" + value;


                if (action == "Add filter")
                {
                    Predicate<string> predicate = GetPredicate(predicateAction, value);

                    predicates.Add(keyName, predicate);
                }


                else if (action == "Remove filter")
                {
                    predicates.Remove(keyName);
                }
            }

            foreach (var item in predicates)
            {
                 people.RemoveAll(item.Value);               
            }


            Console.WriteLine(String.Join(" ", people));
        }

        private static Predicate<string> GetPredicate(string predicateCommand, string value)
        {
            if (predicateCommand == "Starts with")
            {
                return x => x.StartsWith(value);
            }
            else if (predicateCommand == "Ends with")
            {
                return x => x.EndsWith(value);
            }
            else if (predicateCommand == "Contains")
            {
                return x => x.Contains(value);
            }

            int length = int.Parse(value);

            return x => x.Length == length;
        }
    }
}
