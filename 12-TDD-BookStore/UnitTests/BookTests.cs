using _12_TDD_BookStore_MainCode;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Test_BookConstructorShouldSetProperties_ReturnsBookProperties_AfterCreatingBookObject()
        {
            // Arrange
            string title = "Microsoft Visual C# Step by Step";
            string author = "John Sharp";
            string isbn = "1234 5678 9012b";
            decimal price = (decimal)19.99;
            int totalPages = 800;

            // Act
            Book book = new Book(title, author, isbn, price, totalPages);

            // Assert
            Assert.IsInstanceOf<Book>(book);
        }

        [Test]
        public void Test_ShouldUpdatePriceProperty_AfterChangingPriceFieldOFBookObject()
        {
            // Arrange
            string title = "Microsoft Visual C# Step by Step";
            string author = "John Sharp";
            string isbn = "1234 5678 9012b";
            decimal price = (decimal)19.99;
            int totalPages = 800;

            Book book = new Book(title, author, isbn, price, totalPages);

            // Act
            decimal newPrice = (decimal)50.00;
            book.Price = newPrice;

            // Assert
            Assert.That(book.Price, Is.EqualTo(newPrice));
        }

        [Test]
        public void Test_PropertyId_IsOne_AfterCreatingBookObject()
        {
            // Arrange
            Book book1 = new Book("Microsoft Visual C# Step by Step", "John Sharp", "1234 5678 9012b", (decimal)19.99, 800);

            // Act
            int actualId = book1.GenerateId();

            // Assert
            Assert.That(actualId, Is.EqualTo(1));
        }

        [Test]
        public void Test_PropertyId_IsTwoForTheSecondBook_AfterCreatingTwoBookObjects()
        {
            // Arrange
            Book book1 = new Book("Microsoft Visual C# Step by Step", "John Sharp", "1234 5678 9012b", (decimal)19.99, 800);
            Book book2 = new Book("Java", "Javier", "000 5678 9012b", (decimal)30.00, 400);

            // Act
            int actualId = book2.GenerateId();

            // Assert
            Assert.That(actualId, Is.EqualTo(2));
        }
    }
}
