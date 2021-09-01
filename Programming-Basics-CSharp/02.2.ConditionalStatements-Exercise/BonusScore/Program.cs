using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoints = int.Parse(Console.ReadLine());

            double bonusPoints = 0.0;

            if (startPoints <= 100)
            {
                bonusPoints = 5;
            }
            else if (startPoints > 100 && startPoints < 1000)
            {
                bonusPoints = startPoints * 0.2;
            }
            else if (startPoints >= 1000)
            {
                bonusPoints = startPoints * 0.1;
            }
            if (startPoints % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (startPoints % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(startPoints + bonusPoints);


        }
    }
}
