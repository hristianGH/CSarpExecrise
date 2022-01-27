using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> article = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = inputArr[0];
                string content = inputArr[1];
                string author = inputArr[2];
                Article text = new Article(title, content, author);
                article.Add(text);
            }
            string input = Console.ReadLine().ToUpper();
          
            switch (input)
            {
                case "TITLE":
                    article = article.OrderBy(x => x.Title).ToList();
                    break;
                case "CONTENT":
                    article = article.OrderBy(x => x.Content).ToList();
                    break;
                case "AUTHOR":
                    article = article.OrderBy(x => x.Author).ToList();
                    break;
                default:
                    break;
            }
            foreach (var text in article)
            {
                Console.WriteLine(text.ToString());
            }
        }

    }


    class Article
    {
        public Article(string a, string b, string c)
        {
            Title = a;
            Content = b;
            Author = c;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}

