using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyData = new Dictionary<string, List<string>>();
            string[] command = Console.ReadLine().Split("->");

            while (command[0] != "End")
            {
                string companyName = command[0];
                string employeeId = command[1];

                if (!companyData.ContainsKey(companyName))
                {
                    companyData.Add(companyName, new List<string>());
                }
                if (!companyData[companyName].Contains(employeeId))
                {
                    companyData[companyName].Add(employeeId);
                }

                command = Console.ReadLine().Split("->");
            }

            foreach (var item in companyData.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.Write("-- ");
                Console.WriteLine(String.Join("\n-- ", item.Value));
            }
        }
    }
}
