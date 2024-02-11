using System;
using System.Collections.Generic;
using System.Collections;

namespace Comparators
{
    class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public void Dispose() { }
        public bool MoveNext()
        {
            return ++this.currentIndex < this.books.Count;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }

        public Book Current
        {
            get
            {
                return this.books[this.currentIndex];
            }
        }

        object IEnumerator.Current => this.Current;
    }
}
