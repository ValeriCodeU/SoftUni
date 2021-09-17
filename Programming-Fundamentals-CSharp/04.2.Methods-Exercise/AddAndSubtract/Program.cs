using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            int sumFirstTwoInt = GetSumOfFirstTwoIntgers(a, b);            

            int finalResult = Substract(sumFirstTwoInt, c);

            Console.WriteLine(finalResult);
        }

        static int Substract(int sumFirstTwoInt, int c)
        {
            int substract = sumFirstTwoInt - c;
            return substract;
        }

        static int GetSumOfFirstTwoIntgers(int a, int b)
            => a + b;
        //int sum = a + b;
        //return sum;       
    }
}
