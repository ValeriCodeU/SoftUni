﻿using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double dogFoodPrice = dogs * 2.50;
            double otherAnimalsFoodPrice = otherAnimals * 4;

            double allPrice = dogFoodPrice + otherAnimalsFoodPrice;

            Console.WriteLine($"{allPrice} lv.");
        }
    }
}