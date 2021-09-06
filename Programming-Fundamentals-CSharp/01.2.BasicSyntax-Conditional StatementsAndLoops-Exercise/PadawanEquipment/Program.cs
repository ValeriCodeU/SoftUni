using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double singleSabrePrice = double.Parse(Console.ReadLine());
            double singleRobePrice = double.Parse(Console.ReadLine());
            double singleBeltPrice = double.Parse(Console.ReadLine());

            double equipmentPrice = singleBeltPrice * (countOfStudents - (countOfStudents / 6)) + singleRobePrice * countOfStudents + singleSabrePrice * Math.Ceiling(countOfStudents * 1.1);            

            if (equipmentPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {equipmentPrice- amountOfMoney:f2}lv more.");
            }
        }
    }
}
