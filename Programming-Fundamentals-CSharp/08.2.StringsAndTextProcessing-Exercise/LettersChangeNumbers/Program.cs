using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] operations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal resultNumber = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                string number = "";
                char firstLetter = ' ';
                char lastLetter = ' ';

                for (int j = 0; j < operations[i].Length; j++)
                {
                    if (j == 0)
                    {
                        firstLetter = operations[i][j];
                    }
                    else if (j == operations[i].Length - 1)
                    {
                        lastLetter = operations[i][j];
                    }

                    else if (char.IsDigit(operations[i][j]))
                    {
                        number += operations[i][j];
                    }

                }

                decimal toNumber = decimal.Parse(number);

                if (char.IsLower(firstLetter))
                {
                    int position = firstLetter - 96;
                    resultNumber += toNumber * position;
                }
                else if (char.IsUpper(firstLetter))
                {
                    int position = firstLetter - 64;
                    resultNumber += toNumber / position;
                }
                if (char.IsUpper(lastLetter))
                {
                    int position = lastLetter - 64;
                    resultNumber -= position;
                }
                else if (char.IsLower(lastLetter))
                {
                    int postion = lastLetter - 96;
                    resultNumber += postion;
                }
            }

            Console.WriteLine($"{resultNumber:f2}");
        }
    }
}
