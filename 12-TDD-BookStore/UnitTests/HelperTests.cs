using _12_TDD_BookStore_MainCode;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
   public  class HelperTests
    {
        [Test]
        public void Test_AddBook_ReturnsListWithNullMember_WhenNoBooksAdded()
        {
            //arrange
            Helper helper = new Helper();

            //act
            List<Book> returnedList = helper.AddBook(null);

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(1));
            Assert.That(returnedList[0], Is.Null);
        }

        [Test]
        public void Test_AddBook_ReturnsListWith1Book_When1BookAdded()
        {
            //arrange
            Helper helper = new Helper();
            Book book = new Book();

            //act
            List<Book> returnedList = helper.AddBook(book);

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(1));
        }

        [Test]
        public void Test_AddBook_ReturnsCorrectBookObject_When1BookAdded()
        {
            //arrange
            Helper helper = new Helper();
            Book book = new Book();

            //act
            List<Book> returnedList = helper.AddBook(book);

            //assert
            Assert.That(returnedList[0], Is.EqualTo(book));
        }

        [Test]
        public void Test_AddBook_ReturnsListWith2Books_When2BooksAdded()
        {
            //arrange
            Helper helper = new Helper();
            Book book1 = new Book();
            Book book2 = new Book();

            //act
            List<Book> returnedList = helper.AddBook(book1);
            helper.AddBook(book2);

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(2));
        }

        [Test]
        public void Test_AddBook_ReturnsCorrectBookObjects_When2BooksAdded()
        {
            //arrange
            Helper helper = new Helper();
            Book book1 = new Book();
            Book book2 = new Book();

            //act
            List<Book> returnedList = helper.AddBook(book1);
            helper.AddBook(book2);

            //assert
            Assert.That(returnedList[0], Is.EqualTo(book1));
            Assert.That(returnedList[1], Is.EqualTo(book2));
        }

        [Test]
        public void Test_FindAllBooks_ReturnsEmptyList_WhenNoBooksInList()
        {
            //arrange
            Helper helper = new Helper();

            //act
            List<Book> returnedList = helper.FindAllBooks();

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(0));
        }

        [Test]
        public void Test_FindAllBooks_Returns1Book_When1BookInList()
        {
            //arrange
            Helper helper = new Helper();
            Book book = new Book();
            helper.AddBook(book);

            //act
            List<Book> returnedList = helper.FindAllBooks();

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(1));
        }

        [Test]
        public void Test_FindAllBooks_ReturnsCorrectBookObject_When1BookInList()
        {
            //arrange
            Helper helper = new Helper();
            Book book = new Book();
            helper.AddBook(book);

            //act
            List<Book> returnedList = helper.FindAllBooks();

            //assert
            Assert.That(returnedList[0], Is.EqualTo(book));
        }

        [Test]
        public void Test_FindAllBooks_Returns2Books_When2BooksInList()
        {
            //arrange
            Helper helper = new Helper();
            Book book1 = new Book();
            Book book2 = new Book();
            helper.AddBook(book1);
            helper.AddBook(book2);

            //act
            List<Book> returnedList = helper.FindAllBooks();

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(2));
        }

        [Test]
        public void Test_FindAllBooks_ReturnsCorrectBookObjects_When2BooksInList()
        {
            //arrange
            Helper helper = new Helper();
            Book book1 = new Book();
            Book book2 = new Book();
            helper.AddBook(book1);
            helper.AddBook(book2);

            //act
            List<Book> returnedList = helper.FindAllBooks();

            //assert
            Assert.That(returnedList[0], Is.EqualTo(book1));
            Assert.That(returnedList[1], Is.EqualTo(book2));
        }
    }
}
