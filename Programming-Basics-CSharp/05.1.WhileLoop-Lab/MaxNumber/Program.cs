using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {           

            string input = Console.ReadLine();

            int maxNum = int.MinValue;
            
           

            while (input != "Stop")
            {
                
                int number = int.Parse(input);
                input = Console.ReadLine();
                


                if(number > maxNum)
                {
                    maxNum = number;
                }


            }

            Console.WriteLine(maxNum);
        }
    }
}
