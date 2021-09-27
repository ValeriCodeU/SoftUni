using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandTypes = command.Split();

                if (commandTypes[0] == "Add")
                {
                    int element = int.Parse(commandTypes[1]);
                    numbers.Add(element);
                }
                else if (commandTypes[0] == "Insert")
                {
                    int element = int.Parse(commandTypes[1]);
                    int index = int.Parse(commandTypes[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numbers.Insert(index, element);
                    }

                    
                }
                else if (commandTypes[0] == "Remove")
                {
                    int index = int.Parse(commandTypes[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        //command = Console.ReadLine();
                        //continue;
                        
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }


                }
                else if (commandTypes[0] == "Shift")
                {

                    if (commandTypes[1] == "left")
                    {
                        int counter = int.Parse(commandTypes[2]);

                        int temp = 0;

                        for (int i = 0; i < counter; i++)
                        {
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                if (j == 0)
                                {
                                    temp = numbers[0];
                                }
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = temp;
                        }
                    }
                    else if (commandTypes[1] == "right")
                    {
                        int counter = int.Parse(commandTypes[2]);

                        int temp = 0;

                        for (int i = 0; i < counter; i++)
                        {

                            for (int j = numbers.Count - 1; j > 0 ; j--)
                            {
                                if (j == numbers.Count -1)
                                {
                                    temp = numbers[numbers.Count - 1];
                                }

                                numbers[j] = numbers[j - 1];
                            }

                            numbers[0] = temp;                          
                            
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
