using _12_TDD_BookStore_MainCode;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    class BasketTests
    {
        [Test]
        public void Test_AddBookToBasket_ReturnsListWithNullMember_WhenNoBooksAdded()
        {
            //arrange
            Basket basket = new Basket();

            //act
            List<Book> returnedList = basket.AddBookToBasket(null);

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(1));
            Assert.That(returnedList[0], Is.Null);
        }

        [Test]
        public void Test_AddBookToBasket_ReturnsListWith1Book_When1BookAdded()
        {
            //arrange
            Basket basket = new Basket();
            Book book = new Book();

            //act
            List<Book> returnedList = basket.AddBookToBasket(book);

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(1));
        }

        [Test]
        public void Test_AddBookToBasket_ReturnsCorrectBookObject_When1BookAdded()
        {
            //arrange
            Basket basket = new Basket();
            Book book = new Book();

            //act
            List<Book> returnedList = basket.AddBookToBasket(book);

            //assert
            Assert.That(returnedList[0], Is.EqualTo(book));
        }

        [Test]
        public void Test_AddBookToBasket_ReturnsListWith2Books_When2BooksAdded()
        {
            //arrange
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();

            //act
            List<Book> returnedList = basket.AddBookToBasket(book1);
            returnedList = basket.AddBookToBasket(book2);

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(2));
        }

        [Test]
        public void Test_AddBookToBasket_ReturnsCorrectBookObjects_When2BooksAdded()
        {
            //arrange
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();

            //act
            List<Book> returnedList = basket.AddBookToBasket(book1);
            returnedList = basket.AddBookToBasket(book2);

            //assert
            Assert.That(returnedList[0], Is.EqualTo(book1));
            Assert.That(returnedList[1], Is.EqualTo(book2));
        }

        [Test]
        public void Test_FindAllBooksInBasket_ReturnsEmptyList_WhenNoBooksInList()
        {
            //arrange
            Basket basket = new Basket();

            //act
            List<Book> returnedList = basket.FindAllBooksInBasket();

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(0));
        }

        [Test]
        public void Test_FindAllBooksInBasket_Returns1Book_When1BookInList()
        {
            //arrange
            Basket basket = new Basket();
            Book book = new Book();
            basket.AddBookToBasket(book);

            //act
            List<Book> returnedList = basket.FindAllBooksInBasket();

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(1));
        }

        [Test]
        public void Test_FindAllBookInBasket_ReturnsCorrectBookObject_When1BookInList()
        {
            //arrange
            Basket basket = new Basket();
            Book book = new Book();
            basket.AddBookToBasket(book);

            //act
            List<Book> returnedList = basket.FindAllBooksInBasket();

            //assert
            Assert.That(returnedList[0], Is.EqualTo(book));
        }

        [Test]
        public void Test_FindAllBookInBasket_Returns2Books_When2BooksInList()
        {
            //arrange
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);

            //act
            List<Book> returnedList = basket.FindAllBooksInBasket();

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(2));
        }

        [Test]
        public void Test_FindAllBooksInBasket_ReturnsCorrectBookObjects_When2BooksInList()
        {
            //arrange
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);

            //act
            List<Book> returnedList = basket.FindAllBooksInBasket();

            //assert
            Assert.That(returnedList[0], Is.EqualTo(book1));
            Assert.That(returnedList[1], Is.EqualTo(book2));
        }
    }
}
