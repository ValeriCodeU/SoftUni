using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> scale1 = new EqualityScale<int>(10, 6);
            EqualityScale<string> scale2 = new EqualityScale<string>("A", "A");            

            Console.WriteLine(scale1.AreEqual());
            Console.WriteLine(scale2.AreEqual());
        }
    }
}
