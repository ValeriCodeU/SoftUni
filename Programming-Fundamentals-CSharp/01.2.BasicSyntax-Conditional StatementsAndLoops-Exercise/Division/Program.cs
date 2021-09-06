using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());            

            int resultNum = 0;

            if (num % 10 == 0)
            {
                resultNum = 10;
            }
            else if (num % 7 == 0)
            {
                resultNum = 7;
            }
            else if (num % 6 == 0)
            {
                resultNum = 6;
            }
            else if (num % 3 == 0)
            {
                resultNum = 3;
            }
            else if (num % 2 == 0)
            {
                resultNum = 2;
            }

            else
            {
                Console.WriteLine("Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {resultNum}");
        }
    }
}
