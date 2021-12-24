using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);


        }
        public string Title { get; set; }
        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }

        public int CompareTo(Book otherBook)
        {
            int result = this.Year.CompareTo(otherBook.Year);
            if (this.Year == otherBook.Year)
            {
                result = this.Title.CompareTo(otherBook.Title);
            }

            return result;
        }
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }


    }

    
}

