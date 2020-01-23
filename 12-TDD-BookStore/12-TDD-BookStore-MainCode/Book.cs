namespace _12_TDD_BookStore_MainCode
{
    public class Book : Item
    {
        public Book()
        { }

        public Book(string title, string author, string isbn, decimal price, int numPages) : base(title, author, isbn, price, numPages)
        { }

    }
}
