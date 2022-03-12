namespace BookShop
{
    using BookShop.Models;
    using Data;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            // DbInitializer.ResetDatabase(db);
            GetMostRecentBooks(db);
            ;
        }
        static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            command = command.ToUpper();
            var sb = new StringBuilder();

            foreach (var item in context.Books.OrderBy(x => x.Title))
            {
                if (item.AgeRestriction.ToString().ToUpper() == command)
                {
                    sb.AppendLine(item.Title);
                }
            }

            return sb.ToString();

        }
        static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var result = context.Books.Where(x => ((int)x.EditionType) == 2 && x.Copies < 5000).OrderBy(x => x.BookId);
            foreach (var item in result)
            {
                sb.AppendLine(item.Title);
            }
            return sb.ToString();
        }
        static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in context.Books.Where(x => x.Price > 40).OrderByDescending(x => x.Price))
            {
                sb.AppendLine($"{item.Title} - ${item.Price:f2}");
            }
            return sb.ToString();
        }
        static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in context.Books.Where(x => x.ReleaseDate.Value.Year != year).OrderBy(x => x.BookId))
            {
                sb.AppendLine(item.Title);
            }
            System.Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
        static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] arr = input.ToUpper().Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            var books = context.Books.Where(x => x.BookCategories.Any(category => arr.Contains(category.Category.Name.ToUpper())));
            foreach (var item in books.OrderBy(x => x.Title))
            {
                sb.AppendLine(item.Title);
            }

            return sb.ToString();
        }
        static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            StringBuilder sb = new StringBuilder();
            var datee = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var books = context.Books.Where(x => x.ReleaseDate < datee).Select(x => new { x.Title, x.EditionType, x.Price });
            foreach (var item in books)
            {
                sb.AppendLine($"{item.Title} - {item.EditionType} - ${item.Price}");
            }
            return sb.ToString();
        }
        static void GetBookTitlesContaining(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in context.Books.Select(x => x.Title).Where(x => x.Contains(input)).OrderBy(x => x))
            {
                sb.AppendLine(item);
            }
        }
        static void GetBooksByAuthor(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in context.Books.Where(x => x.Author.LastName.ToUpper().StartsWith(input.ToUpper())).Select(x => new { x.Author.FirstName, x.Author.LastName, x.Title }))
            {
                sb.AppendLine($"{item.Title} ({item.FirstName} {item.LastName})");
            }

        }
        static int CountBooks(BookShopContext context, int lengthCheck)
        {
            int counter = context.Books.Where(x => x.Title.Length > lengthCheck).Count();
            return counter;
        }
        static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in context.Authors.Select(x => new { x.FirstName, x.LastName, Sum = x.Books.Sum(x => x.Copies) }).OrderByDescending(x => x.Sum))
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} - {item.Sum}");
            }
            return sb.ToString();
        }
        static void GetTotalProfitByCategory(BookShopContext context)
        {
            foreach (var item in context.Categories.Select(x => new { x.Name, Sum = x.CategoryBooks.Sum(x => x.Book.Price * x.Book.Copies) }).OrderByDescending(x => x.Sum))
            {
                Console.WriteLine($"{item.Name} ${item.Sum:f2}");
            }
        }
        public static void GetMostRecentBooks(BookShopContext context)
        {
            foreach (var item in context.Categories.Select(x => new
            {
                Category = x.Name,
                Books = x.CategoryBooks
                    .Select(b => new { b.Book.Title, b.Book.ReleaseDate })
            }).OrderBy(x => x.Category))
            {
                Console.WriteLine($"--{item.Category}");
                foreach (var book in item.Books.OrderByDescending(x=>x.ReleaseDate).Take(3))
                {
                    Console.WriteLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
                }
            }
        }
    }
}
//12-04-1992
//the title, edition type and price 