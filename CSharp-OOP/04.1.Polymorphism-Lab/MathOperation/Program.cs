using System;

namespace Operations
{
    public class StartUp
    {
        public static void Main()
        {            
            int intResult = MathOperations.Add(2, 3);
            double doubleResult = MathOperations.Add(2.2, 3.3, 5.5);
            decimal decimalResult = MathOperations.Add(2.2m, 3.3m, 4.4m);

            Console.WriteLine(intResult);
            Console.WriteLine(doubleResult);
            Console.WriteLine(decimalResult);
        }
    }
}
