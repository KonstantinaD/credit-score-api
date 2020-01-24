namespace _12_TDD_BookStore_MainCode
{
    public class Item
    {
        private static int nextId = 1;
        string title;
        string author;
        string isbn;
        decimal price;
        int numPages;

        public string Title
        {
            get { return title; }
            private set { title = value; }
        }

        public string Author
        {
            get { return author; }
            private set { author = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            private set { isbn = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int NumPages
        {
            get { return numPages; }
            private set { numPages = value; }
        }

        public Item()
        { }

        public Item(string itemTitle, string itemAuthor, string itemIsbn, decimal itemPrice, int numberPages
            )
        {
            Title = itemTitle;
            Author = itemAuthor;
            Isbn = itemIsbn;
            Price = itemPrice;
            NumPages = numberPages;
        }

        public int GenerateId()
        {
            return nextId++;
        }
    }
}
