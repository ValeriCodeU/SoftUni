using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();

            Stack<string> updates = new Stack<string>();

            string lastUpdate = "";

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    text.Append(command[1]);
                    lastUpdate = text.ToString();
                    updates.Push(lastUpdate);
                }
                else if (command[0] == "2")
                {
                    text.Remove(text.Length - int.Parse(command[1]), int.Parse(command[1]));
                    lastUpdate = text.ToString();
                    updates.Push(lastUpdate);
                }
                else if (command[0] == "3")
                {                  
                    string argument = text.ToString();
                    string printElement = argument.Substring(int.Parse(command[1]) - 1, 1);
                    Console.WriteLine(printElement);
                }
                else if (command[0] == "4")
                {
                    if (updates.Count > 0)
                    {
                        updates.Pop();
                       
                        if (updates.Count == 0)
                        {
                            text.Clear();                            
                        }
                        else
                        {
                            text.Clear();
                            text.Append(updates.Peek());
                        }                       
                    }                    
                }
            }
        }
    }
}
