using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        protected Animal(string name, string favouriteFood)
        {
            Name = name;
            FavoriteFood = favouriteFood;
        }

        public string Name { get; }

        public string FavoriteFood { get; }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavoriteFood}";
        }
    }
}
