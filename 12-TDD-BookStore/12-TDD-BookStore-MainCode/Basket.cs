using System.Collections.Generic;

namespace _12_TDD_BookStore_MainCode
{
    public class Basket
    {
        private readonly List<Book> books = new List<Book>();

        public List<Book> AddBookToBasket(Book book)
        {
            books.Add(book);

            return books;
        }

        public List<Book> FindAllBooksInBasket()
        {
            return books;
        }
    }
}
