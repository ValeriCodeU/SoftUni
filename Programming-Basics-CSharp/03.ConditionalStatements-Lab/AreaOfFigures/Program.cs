using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFigure = Console.ReadLine();          



            if (typeFigure == "square")
            {
                double sideLength = double.Parse(Console.ReadLine());
                double areaSquare = sideLength * sideLength;
                Console.WriteLine($"{areaSquare:f3}");
                
            }
            else if (typeFigure == "rectangle")
            {
                double sideParallelLength = double.Parse(Console.ReadLine());
                double sidePerpendicularLenth = double.Parse(Console.ReadLine());
                double areaRectangle = sideParallelLength * sidePerpendicularLenth;
                Console.WriteLine($"{areaRectangle:f3}");
            }
            else if (typeFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areaCircle = Math.PI * radius * radius;
                Console.WriteLine($"{areaCircle:f3}");

            }
            else if (typeFigure == "triangle")
            {
                double sideLength = double.Parse(Console.ReadLine());
                double heighOnTheSide = double.Parse(Console.ReadLine());
                double areaTriangle = sideLength * heighOnTheSide /2;
                Console.WriteLine($"{areaTriangle:f3}");
            }          
            

           
            
            

            

            
            
            
            

            
        }
        
    }
}
