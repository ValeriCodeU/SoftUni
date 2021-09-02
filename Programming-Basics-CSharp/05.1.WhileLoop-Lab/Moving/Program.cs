using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int apartmentSpace = width * length * height;
            int sumOfBoxesVolume = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                
                int numOfBoxes = int.Parse(input);
                

                sumOfBoxesVolume += numOfBoxes;

                if (apartmentSpace < sumOfBoxesVolume)
                {
                    Console.WriteLine($"No more free space! You need {sumOfBoxesVolume - apartmentSpace} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            

            if (input == "Done")
            {
                Console.WriteLine($"{apartmentSpace - sumOfBoxesVolume} Cubic meters left.");
            }
           

            
        }
    }
}
