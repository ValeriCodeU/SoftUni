using System;
using System.Numerics;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberToString = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();

            int remainder = 0;

            if (numberToString == "0" || multiplier == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(numberToString[i].ToString());

                int result = currentDigit * multiplier + remainder;

                int addToBuilder = result % 10;

                remainder = result / 10;

                builder.Insert(0, addToBuilder);
            }

            if (remainder > 0)
            {
                builder.Insert(0, remainder);
            }

            Console.WriteLine(builder);
        }
    }
}
