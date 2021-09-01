using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double volleyballGames = 0;
            double weekends = 0;

            double sofiaGames = 0;            

            weekends = 48;
            sofiaGames = ((weekends - h) * 3 / 4) + (p * 1.0 * 2 / 3);            
            volleyballGames = sofiaGames + h;

            if (typeYear == "normal")
            {
                Console.WriteLine(Math.Floor(volleyballGames));

                
                
            }
            else if (typeYear == "leap")
            {
                volleyballGames += volleyballGames * 0.15;
                Console.WriteLine(Math.Floor(volleyballGames));
            }



           
        }
    }
}
