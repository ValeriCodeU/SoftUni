using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            string[] matchWords = File.ReadAllLines("../../../words.txt");            
            string text = File.ReadAllText("../../../text.txt");

            List<string> resultList = new List<string>();

            string[] allText = text.Split(new string[] { " ", ",", ".", "-", "!", "?" , "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);           

            for (int i = 0; i < matchWords.Length; i++)
            {
                for (int j = 0; j < allText.Length; j++)
                {
                    if (matchWords[i].ToLower() == allText[j].ToLower())
                    {                       

                        if (!wordsCount.ContainsKey(matchWords[i]))
                        {
                            wordsCount.Add(matchWords[i], 0);
                        }
                        wordsCount[matchWords[i]]++;
                    }
                }                
            }

            foreach (var item in wordsCount)
            {
                string resutText = $"{item.Key} - {item.Value}";
                resultList.Add(resutText);
            }

            File.WriteAllLines("../../../actualResult.txt", resultList);

            resultList.Clear();

            foreach (var item in wordsCount.OrderByDescending(v => v.Value))
            {
                string resultText = $"{item.Key} - {item.Value}";
                resultList.Add(resultText);              
            }           

            File.WriteAllLines("../../../expectedResult.txt", resultList);
        }
    }
}
