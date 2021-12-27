using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\DellG3\source\repos\StreamsFilesAndDirectories-Lab\SliceAFile";

            string[] files = Directory.GetFiles(directoryPath);

            long totalLength = 0;

            foreach (var file in files)
            {
                totalLength += new FileInfo(file).Length;
            }
            using StreamWriter writer = new StreamWriter("../../../output.txt");
            writer.WriteLine(totalLength / 1024.0 / 1024.0);
        }
    }
}
