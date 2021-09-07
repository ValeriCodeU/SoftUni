using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string kindOfPerson = "";

            if (age >=0 && age <=2)
            {
                kindOfPerson = "baby";
            }
            else if (age >=3 && age <=13)
            {
                kindOfPerson = "child";
            }
            else if (age >=14 && age <=19)
            {
                kindOfPerson = "teenager";
            }
            else if (age >=20 && age <=65 )
            {
                kindOfPerson = "adult";
            }
            else if (age >=66)
            {
                kindOfPerson = "elder";
            }

            Console.WriteLine(kindOfPerson);
        }
    }
}
