using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0;
            string evenOdd = "";
            
            switch (symbol)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;                  
                case "*":
                    result = n1 * n2;                   
                    break;
                case "/":                  
                    
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 / n2;
                        Console.WriteLine($"{n1} {symbol} {n2} = {result:f2}");
                    }
                    break;
                case "%":
                    
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} {symbol} {n2} = {result}");
                    }
                    break;
            }

            if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                if (result % 2 == 0)
                {
                    evenOdd = "even";

                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - {evenOdd}");
                }
                else
                {
                    evenOdd = "odd";
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - {evenOdd}");
                }
                
            }
           



           
        }
    }
}
