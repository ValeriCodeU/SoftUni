using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeApartment = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double priceApartmentRest = (days - 1) * 25;
            double pricePresidentApartmentRest = (days - 1) * 35;
            double priceRoomOnePersonRest = (days - 1) * 18;


            if (days < 10)
            {
                switch (typeApartment)
                {
                    case "apartment":
                        priceApartmentRest -= priceApartmentRest * 0.30;
                        break;
                    case "president apartment":
                        pricePresidentApartmentRest -= pricePresidentApartmentRest * 0.10;
                        break;
                    case "room for one person":
                        priceRoomOnePersonRest = priceRoomOnePersonRest * 1;
                        break;

                }

            }
            else if (days >=10 && days <= 15)
            {
                switch (typeApartment)
                {
                    case "apartment":
                        priceApartmentRest -= priceApartmentRest * 0.35;
                        break;
                    case "president apartment":
                        pricePresidentApartmentRest -= pricePresidentApartmentRest * 0.15;
                        break;
                    case "room for one person":
                        priceRoomOnePersonRest = priceRoomOnePersonRest * 1;
                        break;
                }
            }
            else if (days > 15)
            {
                switch (typeApartment)
                {
                    case "apartment":
                        priceApartmentRest -= priceApartmentRest * 0.5;
                        break;
                    case "president apartment":
                        pricePresidentApartmentRest -= pricePresidentApartmentRest * 0.20;
                        break;
                    case "room for one person":
                        priceRoomOnePersonRest = priceRoomOnePersonRest * 1;
                        break;
                }
            }
            if (evaluation == "positive" && typeApartment == "apartment")
            {
                Console.WriteLine($"{priceApartmentRest + priceApartmentRest * 0.25:f2}");
            }
            else if (evaluation == "positive" && typeApartment == "president apartment")
            {
                Console.WriteLine($"{pricePresidentApartmentRest + pricePresidentApartmentRest * 0.25:f2}");
            }
            else if (evaluation == "positive" && typeApartment == "room for one person")
            {
                Console.WriteLine($"{priceRoomOnePersonRest + priceRoomOnePersonRest * 0.25:f2}");
            }
            if (evaluation == "negative" && typeApartment == "apartment")
            {
                Console.WriteLine($"{priceApartmentRest - priceApartmentRest * 0.10:f2}");
            }
            else if (evaluation == "negative" && typeApartment == "president apartment")
            {
                Console.WriteLine($"{pricePresidentApartmentRest - pricePresidentApartmentRest * 0.10:f2}");
            }
            else if (evaluation == "negative" && typeApartment == "room for one person")
            {
                Console.WriteLine($"{priceRoomOnePersonRest - priceRoomOnePersonRest * 0.10:f2}");
            }
        }


    }
}
