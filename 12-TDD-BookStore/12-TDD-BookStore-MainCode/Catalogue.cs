using System.Collections.Generic;

namespace _12_TDD_BookStore_MainCode
{
    public class Catalogue
    {
        private readonly List<Book> books = new List<Book>();

        public List<Book> AddBook(Book book)
        {
            books.Add(book);

            return books;
        }

        public List<Book> FindAllBooks()
        {
            return books;
        }

        public List<Book> RemoveBook(string isbn)
        {
            books.RemoveAll(book => book.Isbn == isbn);

            return books;
        }
    }
}
