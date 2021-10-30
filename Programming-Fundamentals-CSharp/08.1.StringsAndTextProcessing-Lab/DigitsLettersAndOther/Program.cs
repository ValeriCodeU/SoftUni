﻿using System;
using System.Text;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digit = new StringBuilder();
            StringBuilder letter = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digit.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    letter.Append(text[i]);
                }
                else
                {
                    other.Append(text[i]);
                }
            }

            Console.WriteLine($"{digit} \n{letter} \n{other}");
        }
    }
}
