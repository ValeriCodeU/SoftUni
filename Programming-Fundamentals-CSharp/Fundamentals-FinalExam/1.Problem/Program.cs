using System;

namespace _1.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Done")
            {
                if (command[0] == "Change")
                {
                    text = text.Replace(command[1], command[2]);
                    Console.WriteLine(text);
                }
                else if (command[0] == "Includes")
                {
                    if (text.Contains(command[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command[0] == "End")
                {
                    if (text.Contains(command[1]))
                    {                        
                        string lastString = text.Substring(text.Length - command[1].Length, command[1].Length);
                        if (lastString == command[1])
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command[0] == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command[0] == "FindIndex")
                {
                    int findIndex = text.IndexOf(command[1]);
                    Console.WriteLine(findIndex);
                }
                else if (command[0] == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    string cut = text.Substring(startIndex, length);
                    text = text.Remove(startIndex, length);
                    Console.WriteLine(cut);
                    
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
