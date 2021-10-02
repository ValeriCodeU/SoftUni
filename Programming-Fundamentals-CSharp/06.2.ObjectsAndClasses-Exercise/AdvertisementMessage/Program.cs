using System;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator phrases = new RandomGenerator(new List<string>() { 
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", 
                "I can’t live without this product." });

            RandomGenerator events = new RandomGenerator(new List<string>() { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", "I feel great!" });
            RandomGenerator authtors = new RandomGenerator(new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya",
                "Iva", "Annie", "Eva" });
            RandomGenerator cities = new RandomGenerator(new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" });

           
            Console.WriteLine($"{phrases.GetRandomPhrase()} {events.GetRandomPhrase()} {authtors.GetRandomPhrase()} – {cities.GetRandomPhrase()}.");
        }
    }
}
