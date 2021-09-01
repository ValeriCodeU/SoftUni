using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string unit = Console.ReadLine();
            string unitForConvert = Console.ReadLine();
            

            if (unit == "mm")
            {
                num = num / 1000;
            }
            else if (unit == "cm")
            {
                num = num / 100;
            }
            if (unitForConvert == "mm")
            {
                num = num * 1000;
            }
            else if (unitForConvert == "cm")
            {
                num = num * 100;
            }
           

            //if (unit == "m" && unitForConvert == "cm")
            //{
            //    num = num * 100;
            //}
            //else if (unit == "mm" && unitForConvert == "m")
            //{
            //    num = num / 1000;
            //}
            //else if (unit =="cm" && unitForConvert == "mm")
            //{
            //    num = num * 10;
            //}

            Console.WriteLine($"{num:f3}");
        }

        

    }
}
