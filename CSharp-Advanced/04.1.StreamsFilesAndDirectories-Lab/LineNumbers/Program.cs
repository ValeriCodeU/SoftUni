using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string currentRow = reader.ReadLine();
                    int count = 1;

                    while (currentRow != null)
                    {
                        writer.WriteLine($"{count}.  {currentRow}");
                        count++;
                        currentRow = reader.ReadLine();
                    }
                }
            }
        }
    }
}
