using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable

    {

    public List<Book> Books { get; set; }

    public Library(params Book[] books)
    {
        Books = new List<Book>(books);
    }

        public IEnumerator GetEnumerator()
        {
            foreach (var book in Books)
            {
                yield return book.Title;
            }
        }
    }
}
