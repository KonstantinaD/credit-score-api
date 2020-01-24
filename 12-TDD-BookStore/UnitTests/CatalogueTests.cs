using _12_TDD_BookStore_MainCode;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class CatalogueTests
    {
        [Test]
        public void Test_RemoveBook_ReturnsNull_WhenNoBooksInList()
        {
            //arrange
            Catalogue catalogue = new Catalogue();

            //act
            List<Book> returnedList = catalogue.RemoveBook("");

            //assert
            Assert.That(returnedList, Is.Empty);
        }

        [Test]
        public void Test_RemoveBook_RemovesTheOneBookInList_WhenCalledWithCorrectIsbn()
        {
            //arrange
            Catalogue catalogue = new Catalogue();
            Book book = new Book("", "", "1234", (decimal)20.0, 60);
            catalogue.AddBook(book);

            //act
            List<Book> returnedList = catalogue.RemoveBook("1234");

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(0));
        }


        [Test]
        public void Test_RemoveBook_DoesNotRemoveBook_WhenCalledWithIncorrectIsbn()
        {
            //arrange
            Catalogue catalogue = new Catalogue();
            Book book = new Book("", "", "1234", (decimal)20.0, 60);
            catalogue.AddBook(book);

            //act
            List<Book> returnedList = catalogue.RemoveBook("567");

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(1));
            Assert.That(returnedList[0], Is.EqualTo(book));
        }

        [Test]
        public void Test_RemoveBook_RemovesCorrectBookInListWith2Books_ForIsbnUsed()
        {
            //arrange
            Catalogue catalogue = new Catalogue();
            Book book1 = new Book("title1", "author1", "1234", (decimal)20.0, 60);
            Book book2 = new Book("title2", "author2", "56789", (decimal)50.0, 100);
            catalogue.AddBook(book1);
            catalogue.AddBook(book2);

            //act
            List<Book> returnedList = catalogue.RemoveBook("1234");

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(1));
            Assert.That(returnedList, Has.No.Member(book1));
        }

        [Test]
        public void Test_RemoveBook_DoesNotRemoveBooksInListWith2Books_WhenCalledWithIncorrectIsbns()
        {
            //arrange
            Catalogue catalogue = new Catalogue();
            Book book1 = new Book("title1", "author1", "1234", (decimal)20.0, 60);
            Book book2 = new Book("title2", "author2", "56789", (decimal)50.0, 100);
            catalogue.AddBook(book1);
            catalogue.AddBook(book2);

            //act
            List<Book> returnedList = catalogue.RemoveBook("7890");
            catalogue.RemoveBook("3345");

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(2));
            Assert.That(returnedList[0], Is.EqualTo(book1));
            Assert.That(returnedList[1], Is.EqualTo(book2));
        }

        [Test]
        public void Test_RemoveBook_RemovesBooksInListWith2Books_WhenCalledWithRespectiveIsbns()
        {
            //arrange
            Catalogue catalogue = new Catalogue();
            Book book1 = new Book("title1", "author1", "1234", (decimal)20.0, 60);
            Book book2 = new Book("title2", "author2", "56789", (decimal)50.0, 100);
            catalogue.AddBook(book1);
            catalogue.AddBook(book2);

            //act
            List<Book> returnedList = catalogue.RemoveBook("1234");
            catalogue.RemoveBook("56789");

            //assert
            Assert.That(returnedList.Count, Is.EqualTo(0));
            Assert.That(returnedList, Has.No.Member(book1));
            Assert.That(returnedList, Has.No.Member(book2));
        }
    }
}
