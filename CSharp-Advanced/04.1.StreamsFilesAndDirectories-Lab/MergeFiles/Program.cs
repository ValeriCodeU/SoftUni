using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader readerInput1 = new StreamReader("../../../input1.txt");
            
            List<int> numbers = new List<int>();

            string line1 = readerInput1.ReadLine();

            while (line1 != null)
            {               
                numbers.Add(int.Parse(line1));
                line1 = readerInput1.ReadLine();
            }

            using StreamReader readerInput2 = new StreamReader("../../../input2.txt");

            string line2 = readerInput2.ReadLine();

            while (line2 != null)
            {
                numbers.Add(int.Parse(line2));
                line2 = readerInput2.ReadLine();
            }

            using StreamWriter writer = new StreamWriter("../../../output.txt");

            foreach (var number in numbers.OrderBy(v => v))
            {
                writer.WriteLine(number);
            }
        }
    }
}
