﻿using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnight = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                if(overnight > 7 && overnight <= 14)
                {
                    studioPrice = studioPrice * 0.95;
                }
                else if (overnight > 14)
                {
                    studioPrice = studioPrice * 0.70;
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }

            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if(overnight > 14)
                {
                    studioPrice = studioPrice * 0.80;
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;

                if (overnight > 14)
                {
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice * overnight:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice* overnight:f2} lv.");           
           


        }
    }
}
