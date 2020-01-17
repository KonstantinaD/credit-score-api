using System;

namespace ConsoleApp_05_OperatorOverloading
{
    public class Book
    {
        private string title;
        private string author;
        private int numPages;

        public Book() { }
        public Book(string bookTitle, string bookAuthor, int numberOfPages)
        {
            title = bookTitle;
            author = bookAuthor;
            numPages = numberOfPages;
        }

        public string Title
        {
            get { return this.title;  }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public int NumPages
        {
            get { return numPages; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number Of Pages cannot be zero/negative");
                }
                else
                {
                    numPages = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format(" {0}, {1}, {2} ", title, author, numPages);
        }

        // Overload + operator to add two book objects.
        public static Book operator +(Book book1, Book book2)
        {
            Book newBook = new Book();
            newBook.title = book1.title + " and " + book2.title;
            newBook.author = book1.author + " and " + book2.author;
            newBook.numPages = book1.numPages + book2.numPages;

            return newBook;
        }

    }

}
