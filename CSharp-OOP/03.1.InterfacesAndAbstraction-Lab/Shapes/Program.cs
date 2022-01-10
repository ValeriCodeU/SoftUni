using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IDrawable rectangle = new Rectangle(10, 5);

            rectangle.Draw();

            IDrawable circle = new Circle(10);

            circle.Draw();           
        }
    }
}
