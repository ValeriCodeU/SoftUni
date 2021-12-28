using System;
using System.IO;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create your own directories if you want to test the program, because the task does not work in the main directories of the program
            //ZipFile class is used
            //The folder "ZipFileSource" has been created in the directory "D:\ZipFileSource" => and contains the file from the task - copyMe.png 
            //The folder "ZipFileProblemResult" has been created in the directory "D:\ZipFileProblemResult" => "ZipFileResult.zip" has been created and it is extracted in the same directory
            ZipFile.CreateFromDirectory(@"D:\ZipFileSource", @"D:\ZipFileProblemResult\ZipFileResult.zip");
            ZipFile.ExtractToDirectory(@"D:\ZipFileProblemResult\ZipFileResult.zip", @"D:\ZipFileProblemResult");
        }
    }
}
