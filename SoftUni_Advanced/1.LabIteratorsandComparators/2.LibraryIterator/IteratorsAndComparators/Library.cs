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




    private class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books { get; set; }
        private int currentIndex;
        public LibraryIterator(List<Book> books)
        {
            Reset();
            this.books = new List<Book>(books);
        }
        public Book Current => books[currentIndex];

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex<books.Count)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    }
}
