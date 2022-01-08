﻿using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                string[] animalData = Console.ReadLine().Split();
                string name = animalData[0];
                int age = int.Parse(animalData[1]);
                string gender = animalData[2];

                if (age < 0)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                if (input == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    animals.Add(cat);
                }
                else if (input == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    animals.Add(kitten);
                }
                else if (input == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    animals.Add(tomcat);
                }
                else if (input == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    animals.Add(dog);
                }
                else if (input == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    animals.Add(frog);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name}");
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine($"{animal.ProduceSound()}");
            }

        }
    }
}

