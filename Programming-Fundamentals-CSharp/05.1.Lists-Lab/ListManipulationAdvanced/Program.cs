using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            int counter = 0;

            while (command != "end")
            {
                string[] commandTypes = command.Split();

                string action = commandTypes[0];

                if (action == "Add")
                {
                    int element = int.Parse(commandTypes[1]);
                    numbers.Add(element);
                    counter++;
                }
                else if (action == "Remove")
                {
                    int element = int.Parse(commandTypes[1]);
                    numbers.Remove(element);
                    counter++;
                }
                else if (action == "RemoveAt")
                {
                    int element = int.Parse(commandTypes[1]);
                    numbers.RemoveAt(element);
                    counter++;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandTypes[2]);
                    int element = int.Parse(commandTypes[1]);
                    numbers.Insert(index, element);
                    counter++;
                }
                else if (action == "Contains")
                {
                    int element = int.Parse(commandTypes[1]);
                    bool isContain = true;
                    isContain = numbers.Contains(element);

                    if (isContain == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }                    
                }
                else if (action == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");                            
                        }                        
                    }
                    Console.WriteLine();
                }
                else if (action == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        
                    }
                    Console.WriteLine();
                }
                else if (action == "GetSum")
                {
                    int totalSum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        totalSum += numbers[i];
                    }

                    Console.WriteLine(totalSum);
                }
                else if (action == "Filter")
                {
                    string @operator = commandTypes[1];
                    int element = int.Parse(commandTypes[2]);

                    if (@operator == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > element)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (@operator == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= element)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (@operator == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= element)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (@operator == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < element)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }

            if (counter > 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }            
        }       
    }
}
