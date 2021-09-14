using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double height = int.Parse(Console.ReadLine());

            double resultArea = RectangleArea(width, height);
            Console.WriteLine(resultArea);
        }
        private static double RectangleArea(double width, double height)
        {
            double resultArea = width * height;
            return resultArea;
        }
    }
}
