﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
