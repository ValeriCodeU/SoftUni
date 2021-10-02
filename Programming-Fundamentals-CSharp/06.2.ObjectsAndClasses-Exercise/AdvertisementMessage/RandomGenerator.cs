using System;
using System.Collections.Generic;
using System.Text;

namespace AdvertisementMessage
{
    class RandomGenerator
    {
        public List<string> Phrases { get; set; }

        public RandomGenerator(List<string> phrases)
        {
            Phrases = phrases;
        }
        public string GetRandomPhrase()
        {
            Random random = new Random();

            return Phrases[random.Next(Phrases.Count)];
        }


    }
}
