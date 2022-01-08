using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Wizard wizard = new Wizard("Salah", 1000);

            Console.WriteLine(wizard);
        }
    }
}