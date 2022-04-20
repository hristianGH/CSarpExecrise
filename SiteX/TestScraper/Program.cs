using System;
using System.Threading.Tasks;
using AngleSharp;

namespace TestScraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);
            Parallel.For(35_438_900, 35_439_900, (i) =>
            {

                Scraper(context, i);
            });

            //(TI  - )(.*\s)+?(PG  - ) Title
            //(AB  - )(.*\s)+?(FAU - ) for abstract
        }

        private static void Scraper(IBrowsingContext context, int id)
        {


            var document = context.OpenAsync($"https://pubmed.ncbi.nlm.nih.gov/{id}/").GetAwaiter().GetResult();

            var name = document.QuerySelector(".heading-title");
            var desc = document.QuerySelector(".abstract-content");
            var idLink = document.QuerySelector(".id-link");

            var currLink = document.BaseUrl;

            if (name != null && desc != null && idLink != null)
            {
                Console.WriteLine($"{id} works");
            }
            else
            {
                Console.WriteLine($"{id} DOESNT WORK");
            }
        }
    }
}
