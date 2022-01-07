using System;
using System.Collections.Generic;
using System.Text;


namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        
        public string RandomString()
        {
            Random randomElement = new Random();

            int index = randomElement.Next(0, Count);

            string listElement = this[index];
            RemoveAt(index);

            return listElement;
        }
    }
}
