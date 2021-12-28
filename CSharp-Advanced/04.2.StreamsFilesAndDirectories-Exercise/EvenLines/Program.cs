using System;
using System.IO;
using System.Linq;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("../../../text.txt");

            string currentRow = reader.ReadLine();

            int line = 0;

            while (currentRow != null)
            {
                if (line % 2 == 0)
                {
                    string[]resultRow = currentRow.Split().Reverse().ToArray();                    

                    for (int i = 0; i < resultRow.Length; i++)
                    {
                        for (int j = 0; j <resultRow[i].Length; j++)
                        {
                            if (resultRow[i][j] == '-' ||resultRow[i][j] == ',' ||resultRow[i][j] == '.' ||resultRow[i][j] == '!' ||resultRow[i][j] == '?')
                            {
                                resultRow[i] = resultRow[i].Replace(resultRow[i][j], '@');
                            }
                        }
                    }
                    Console.WriteLine(String.Join(" ", resultRow));
                }
                line++;
                currentRow = reader.ReadLine();
            }
        }        
    }
}
