using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            for (int i = 0; i < 4; i++)
            {

                if (i == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }


                string inputPass = Console.ReadLine();

                if (password == inputPass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (i == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                if (password != inputPass)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
