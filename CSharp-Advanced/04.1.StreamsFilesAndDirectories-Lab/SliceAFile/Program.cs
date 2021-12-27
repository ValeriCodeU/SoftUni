using System;
using System.IO;

namespace SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream fileStream = new FileStream("../../../slice.txt", FileMode.OpenOrCreate);

            var partSize = (int)Math.Ceiling(fileStream.Length / 4.0);

            for (int i = 0; i < 4; i++)
            {
                byte[] buffer = new byte[partSize];
                fileStream.Read(buffer);

                using FileStream writer = new FileStream($"../../../Part-{i + 1}.txt", FileMode.OpenOrCreate);
                writer.Write(buffer);
            }
        }
    }
}
