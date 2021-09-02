using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pasword = Console.ReadLine();

            string inputPassword = Console.ReadLine();

            while (pasword != inputPassword)
            {
                inputPassword = Console.ReadLine();
                
            }

            Console.WriteLine($"Welcome {name}!");
        }
    }
}
