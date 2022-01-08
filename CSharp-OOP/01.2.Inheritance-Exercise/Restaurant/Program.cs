using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Cake cake = new Cake("cake");

            Console.WriteLine(cake.Calories);
        }
    }
}
