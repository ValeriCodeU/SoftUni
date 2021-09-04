﻿using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());

            int row = 1;
            int currentNum = 1;
            bool isEqual = false;

            while (isEqual == false)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(currentNum + " ");
                    currentNum++;

                    if (currentNum > targetNum)
                    {
                        isEqual = true;
                        break;
                    }
                }
                Console.WriteLine();
                row++;
            }
        }
    }
}
