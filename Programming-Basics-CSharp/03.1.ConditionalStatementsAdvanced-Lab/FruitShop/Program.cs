using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (fruit == "banana")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = quantity * 2.50;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = quantity * 2.70;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                
            }
            else if (fruit == "apple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = quantity * 1.20;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = quantity * 1.25;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                
            }
            else if (fruit == "orange")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = quantity * 0.85;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = quantity * 0.90;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                
            }
            else if (fruit == "grapefruit")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = quantity * 1.45;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = quantity * 1.60;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                           
                }
                
            }
            else if (fruit == "kiwi")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = quantity * 2.70;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = quantity * 3.00;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
               
            }
            else if (fruit == "pineapple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = quantity * 5.50;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = quantity * 5.60;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                
            }
            else if (fruit == "grapes")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = quantity * 3.85;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = quantity * 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }              



            }
            else
            {
                Console.WriteLine("error");
            }
            if (price > 0)
            {
                Console.WriteLine($"{price:f2}");
            }



        }
    }
}
