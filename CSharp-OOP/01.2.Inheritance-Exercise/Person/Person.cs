﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    age = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"Name: {Name}, Age: {Age}");            

            return builder.ToString();
        }
    }
}
