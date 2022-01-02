using System;

namespace GenericCountMethodDoubles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            double element = double.Parse(Console.ReadLine());

            int count = box.Compare(element);            

            Console.WriteLine(count);
        }
    }
}
