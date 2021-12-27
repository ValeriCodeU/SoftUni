using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string currentRow = reader.ReadLine();

                int line = 0;

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    while (currentRow != null)
                    {
                        if (line % 2 != 0)
                        {
                            writer.WriteLine(currentRow);
                        }

                        currentRow = reader.ReadLine();
                        line++;
                    }
                }
            }
        }

        //static void Main()
        //{
        //    string inputFilePath = @"../../../input.txt";
        //    string outputFilePath = @"../../../output.txt";

        //    ExtractOddLines(inputFilePath, outputFilePath);
        //}

        //public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        //{
        //    using StreamReader reader = new StreamReader(inputFilePath);
        //    using StreamWriter writer = new StreamWriter(outputFilePath);

        //    string currentRow = reader.ReadLine();

        //    int line = 0;

        //    while (currentRow != null)
        //    {
        //        if (line % 2 != 0)
        //        {
        //            writer.WriteLine(currentRow);
        //        }

        //        currentRow = reader.ReadLine();
        //        line++;
        //    }
        //}
    }
}
