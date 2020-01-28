using System;

namespace ConsoleApp_19_Collections_OverrideEqualsAndGetHashCode
{
    public class Book
    {
        private string title;
        private string author;


        public Book(string iniTitle, string iniAuthor)
        {
            this.Title = iniTitle;
            this.Author = iniAuthor;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public override bool Equals(object value)
        {
            // Is null?
            if (Object.ReferenceEquals(null, value))
            {
                return false;
            }

            // Is the same object?
            if (Object.ReferenceEquals(this, value))
            {
                return true;
            }

            // Is the same type?
            if (value.GetType() != this.GetType())
            {
                return false;
            }

            return IsEqual((Book)value);
        }

        private bool IsEqual(Book book)
        {
            // An implementation of value equality that use String.Equals 
            return String.Equals(title, book.title)
                    && String.Equals(author, book.author);
        }

        public override int GetHashCode() =>
        new { title, author }.GetHashCode();
    }
}



