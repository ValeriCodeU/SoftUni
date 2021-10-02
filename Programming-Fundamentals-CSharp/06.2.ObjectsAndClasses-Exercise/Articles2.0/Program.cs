using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <Article> totalArticles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] articles = Console.ReadLine().Split(", ");
                string title = articles[0];
                string content = articles[1];
                string author = articles[2];
                totalArticles.Add(new Article(title, content, author));
            }

            string typeSort = Console.ReadLine();

            if (typeSort == "title")
            {
                totalArticles = totalArticles.OrderBy(a => a.Title).ToList();
            }
            else if (typeSort == "content")
            {
                totalArticles = totalArticles.OrderBy(a => a.Content).ToList();
            }
            else if (typeSort == "author")
            {
                totalArticles = totalArticles.OrderBy(a => a.Author).ToList();
            }

            //Console.WriteLine(String.Join($"{Environment.NewLine}"), atricles);

            foreach (var items in totalArticles)
            {
                Console.WriteLine(items);
            }
        }
    }
}
