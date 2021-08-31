using System;

namespace OnTimeForTheExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int arivalHourExam = int.Parse(Console.ReadLine());
            int arivalMinutesExam = int.Parse(Console.ReadLine());

            int startExamTime = 0;
            int studentTime = 0;
            int timeDifference = 0;

            startExamTime = hourExam * 60 + minutesExam;
            studentTime = arivalHourExam * 60 + arivalMinutesExam;

            timeDifference = startExamTime - studentTime;

            if (timeDifference > 30)
            {
                Console.WriteLine("Early");

                if (timeDifference >= 60)
                {
                    Console.WriteLine($"{timeDifference / 60}:{timeDifference % 60:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }
            }
            else if (timeDifference < 0)
            {
                Console.WriteLine("Late");
                timeDifference = Math.Abs(timeDifference);

                if (timeDifference >= 60)
                {
                    Console.WriteLine($"{timeDifference / 60}:{timeDifference % 60:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{timeDifference} minutes after the start");
                }
            }
            else
            {
                Console.WriteLine("On time");

                if (timeDifference > 0)
                {
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }
            }        
        }
    }
}
