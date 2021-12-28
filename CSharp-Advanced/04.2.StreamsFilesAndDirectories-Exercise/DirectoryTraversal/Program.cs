using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currentDirectoryFiles = Directory.GetFiles("../../../");
            Dictionary<string, Dictionary<string, double>> filesData = new Dictionary<string, Dictionary<string, double>>();

            List<string> result = new List<string>();

            foreach (var file in currentDirectoryFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extensionName = fileInfo.Extension;
                string fileName = fileInfo.Name;
                long sizeFile = fileInfo.Length;
                double sizeInKb = sizeFile / 1024.0;

                if (!filesData.ContainsKey(extensionName))
                {
                    filesData.Add(extensionName, new Dictionary<string, double>());
                }
                filesData[extensionName].Add(fileName, sizeInKb);                
            }

            Dictionary<string, Dictionary<string, double>> sortedDictionary = filesData
                .OrderByDescending(v => v.Value.Count).ThenBy(k => k.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var item in sortedDictionary)
            {
                result.Add(item.Key);

                foreach (var file in item.Value.OrderBy(v => v.Value))
                {
                    result.Add($"--{file.Key} - {file.Value:f3}kb");
                }
            }
            string desktopPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "report.txt");            

            File.WriteAllLines(desktopPath, result);
        }
    }
}
