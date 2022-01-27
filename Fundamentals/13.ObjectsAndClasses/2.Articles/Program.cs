using System;
using System.Collections.Generic;
using System.Numerics;

namespace _2.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> article = new List<Article>();
            string[] contents = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            string title = contents[0];
            string content = contents[1];
            string author = contents[2];
            Article text = new Article(title, content, author);
            article.Add(text);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                switch (command[0])
                {
                    case "Edit":
                        text.Content = command[1];
                        break;
                    case "ChangeAuthor":
                        text.Author = command[1];
                        
                        break;
                    case "Rename":
                        text.Title = command[1];
                        break;

                }
            }
            foreach (var item in article)
            {

                Console.WriteLine(item.ToString());
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

