using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class Library
    {
        Dictionary<string, Book> books = new Dictionary<string, Book>();

        public bool AddBook(Book book)
        {
            if (books.ContainsKey(book.Isbn)) return false;
            books[book.Isbn] = book;
            return true;
        }
    }
}
