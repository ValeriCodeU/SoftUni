using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Console.ReadLine();

            int indexFile = fileName.LastIndexOf("\\");
            int indexExtension = fileName.LastIndexOf(".");

            string lengthToExtenstionFromStart = fileName.Substring(0, indexExtension);

            string extenstion = fileName.Substring(indexExtension + 1, fileName.Length - 1 - lengthToExtenstionFromStart.Length);

            fileName = fileName.Remove(indexExtension + 1, fileName.Length - 1 - lengthToExtenstionFromStart.Length);

            string lengthToFileFromStart = fileName.Substring(0, indexFile);

            string file = fileName.Substring(indexFile + 1, fileName.Length - 1 - 1 - lengthToFileFromStart.Length);

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extenstion}");
        }
    }
}
