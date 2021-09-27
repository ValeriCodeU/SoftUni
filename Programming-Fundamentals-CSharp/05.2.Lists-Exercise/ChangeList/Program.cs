using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandType = command.Split();

                if (commandType[0] == "Delete")
                {
                    int element = int.Parse(commandType[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.Remove(element); 
                            i -= 1;
                        }
                    }
                    //вариант 2: С Linq спестява цикъла
                    //numbers.RemoveAll(x => x == element);
                }
                else if (commandType[0] == "Insert")
                {
                    int element = int.Parse(commandType[1]);
                    int index = int.Parse(commandType[2]);

                    numbers.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
