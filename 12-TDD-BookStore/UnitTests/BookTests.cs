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
        public void Test_PropertyId_ReturnsValuesIncrementedBy1_AfterCreating4BookObjects()
        {
            // Arrange
            Book book1 = new Book("Microsoft Visual C# Step by Step", "John Sharp", "1234 5678 9012b", (decimal)19.99, 800);
            Book book2 = new Book("Java", "Javier", "000 5678 9012b", (decimal)30.00, 400);
            Book book3 = new Book("Java book", "Javi", "123 5678 9012b", (decimal)40.00, 200);
            Book book4 = new Book("Java basics", "Jav", "789 5678 9012b", (decimal)50.00, 100);

            // Act
            int actualId1 = book1.GenerateId();
            int actualId2 = book2.GenerateId();
            int actualId3 = book3.GenerateId();
            int actualId4 = book4.GenerateId();

            // Assert
            Assert.That(actualId1, Is.EqualTo(1));
            Assert.That(actualId2, Is.EqualTo(2));
            Assert.That(actualId3, Is.EqualTo(3));
            Assert.That(actualId4, Is.EqualTo(4));
        }
    }
}
