using System;
using System.Text.RegularExpressions;

namespace _2.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int successPass = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"U\$(?<username>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-Za-z]{5,}[0-9]+)P@\$";

                Match registration = Regex.Match(input, pattern);

                if (registration.Success)
                {
                    successPass++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {registration.Groups["username"]}, Password: {registration.Groups["password"]}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {successPass}");
        }
    }
}
