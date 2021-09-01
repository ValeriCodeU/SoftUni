using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = (Console.ReadLine());
            string passwordSaved = "s3cr3t!P@ssw0rd";

            if (password == passwordSaved)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
