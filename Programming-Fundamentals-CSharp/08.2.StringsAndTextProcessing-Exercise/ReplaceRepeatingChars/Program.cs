using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int counter = 0;
            int counterOfIndex = -1;            

            for (int i = 0; i < text.Length - 1; i++)
            {

                if (text[i].ToString() == text[i + 1].ToString())
                {
                    counter++;
                }
                if (text[i].ToString() != text[i + 1].ToString())
                {
                    counterOfIndex++;
                    text = text.Remove(counterOfIndex, counter);                    
                    i = counterOfIndex;
                    counter = 0;
                }
            }

            if (counter > 0)
            {
                text = text.Remove(counterOfIndex + 1, counter);
            }

            Console.WriteLine(text);
        }
    }
}
