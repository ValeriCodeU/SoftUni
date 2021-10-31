using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < builder.Length; i++)
            {
                if (builder[i] == '>')
                {
                    int strength = int.Parse(builder[i + 1].ToString());
                    strength += count;

                    while (char.IsLetterOrDigit(builder[i + 1]) && strength > 0)
                    {
                        builder = builder.Remove(i + 1, 1);
                        strength--;

                        if (builder.Length <= i + 1)
                        {
                            break;
                        }
                    }

                    if (strength > 0)
                    {
                        count += strength;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            Console.WriteLine(builder);

        }
    }
}
