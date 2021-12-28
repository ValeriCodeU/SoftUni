using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream readStream = new FileStream("../../../copyMe.png", FileMode.Open);
            using FileStream writeStream = new FileStream("../../../newCopyMe.png", FileMode.Create);

            byte[] buffer = new byte[4096];

            while (readStream.Read(buffer, 0, buffer.Length) > 0)
            {
                writeStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
