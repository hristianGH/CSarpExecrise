using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Library
{
    public class Book:
        IComparable<Book> 
        ,IComparer<Book>
    {
        public Book(string name, int year, params string[] authors)
        {
            Title = name;
            Year = year;
            Authors = authors;
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public string[] Authors { get; set; }

        public int Compare(Book x, Book y)
        {
            //if (x.Title.CompareTo(y.Title)!=0)
            //{
            //    return x.Title.CompareTo(y.Title);
            //}
            //return x.Year.CompareTo(y.Year);
            return x.CompareTo(y);
        }

        public int CompareTo(Book otherBook)
        {
            var result = this.Year.CompareTo(otherBook.Year);
            if (result==0)
            {
                return Title.CompareTo(otherBook.Title);
            }
            return result;
        }

        public override string ToString()
        {
            return $"Titile {Title} Year {Year}  // {string.Join(", ",Authors)}";
        }
    }


}
