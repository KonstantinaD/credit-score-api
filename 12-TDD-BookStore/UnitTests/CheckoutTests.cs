using _12_TDD_BookStore_MainCode;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void Test_CalculateAccumulativeDiscount_Returns0_WhenNoBooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateAccumulativeDiscount_Returns0_When1BookInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBookToBasket(new Book());

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateAccumulativeDiscount_Returns0_When2BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateAccumulativeDiscount_Returns1_When3BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(1));
        }

        [Test]
        public void Test_CalculateAccumulativeDiscount_Returns1_When4BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(1));
        }

        [Test]
        public void Test_CalculateAccumulativeDiscount_Returns2_When6BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(2));
        }

        [Test]
        public void Test_CalculateAccumulativeDiscount_Returns2_When7BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            Book book7 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);
            basket.AddBookToBasket(book7);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(2));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_WhenNoBooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When1BookInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBookToBasket(new Book());
       

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When2BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When3BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When4BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When5BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When6BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When7BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            Book book7 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);
            basket.AddBookToBasket(book7);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When8BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            Book book7 = new Book();
            Book book8 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);
            basket.AddBookToBasket(book7);
            basket.AddBookToBasket(book8);


            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When9BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            Book book7 = new Book();
            Book book8 = new Book();
            Book book9 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);
            basket.AddBookToBasket(book7);
            basket.AddBookToBasket(book8);
            basket.AddBookToBasket(book9);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns10_When10BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            Book book7 = new Book();
            Book book8 = new Book();
            Book book9 = new Book();
            Book book10 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);
            basket.AddBookToBasket(book7);
            basket.AddBookToBasket(book8);
            basket.AddBookToBasket(book9);
            basket.AddBookToBasket(book10);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(10));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns10_When11BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            Book book7 = new Book();
            Book book8 = new Book();
            Book book9 = new Book();
            Book book10 = new Book();
            Book book11 = new Book();
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);
            basket.AddBookToBasket(book7);
            basket.AddBookToBasket(book8);
            basket.AddBookToBasket(book9);
            basket.AddBookToBasket(book10);
            basket.AddBookToBasket(book11);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(10));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns10_When20BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(10));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns10_When21BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());
            basket.AddBookToBasket(new Book());

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(10));
        }

        [Test]
        public void Test_CalculateSumOfPrices_Returns0_WhenNoBooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();

            //act
            decimal actualDiscount = checkout.CalculateSumOfPrices(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateSumOfPrices_ReturnsBookPrice_When1BookInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBookToBasket(new Book("", "", "", (decimal)20.25, 60));


            //act
            decimal actualValue = checkout.CalculateSumOfPrices(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualValue, Is.EqualTo(20.25));
        }

        [Test]
        public void Test_CalculateSumOfPrices_ReturnsSumOfBookPrices_When2BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book("", "", "", (decimal)10.00, 70);
            Book book2 = new Book("", "", "", (decimal)25.00, 200);
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);

            //act
            decimal actualDiscount = checkout.CalculateSumOfPrices(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(10.00 + 25.00));
        }

        [Test]
        public void Test_CalculateFinalBasketPrice_Returns0_WhenNoBooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualValue, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateFinalBasketPrice_ReturnsBookPrice_When1BookInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBookToBasket(new Book("", "", "", (decimal)20.25, 60));


            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualValue, Is.EqualTo(20.25));
        }

        [Test]
        public void Test_CalculateFinalBasketPrice_ReturnsSumOfBookPrices_When2BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book("", "", "", (decimal)10.00, 70);
            Book book2 = new Book("", "", "", (decimal)25.00, 200);
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooksInBasket());

            //assert
            Assert.That(actualValue, Is.EqualTo(10.00 + 25.00));
        }

        [Test]
        public void Test_CalculateFinalBasketPrice_RegistersCorrectDiscountAndReturnsCorrectTotalPrice_When3BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book("", "", "", (decimal)10.00, 70);
            Book book2 = new Book("", "", "", (decimal)20.00, 200);
            Book book3 = new Book("", "", "", (decimal)30.00, 100);
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooksInBasket());

            //assert
            decimal sumOfPrices = (decimal)(10.00 + 20.00 + 30.00);
            Assert.That(actualValue, Is.EqualTo(sumOfPrices - (1 / 100) * sumOfPrices));
        }

        [Test]
        public void Test_CalculateFinalBasketPrice_RegistersCorrectDiscountAndReturnsCorrectTotalPrice_When7BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book("", "", "", (decimal)10.00, 70);
            Book book2 = new Book("", "", "", (decimal)20.00, 200);
            Book book3 = new Book("", "", "", (decimal)30.00, 100);
            Book book4 = new Book("", "", "", (decimal)40.00, 70);
            Book book5 = new Book("", "", "", (decimal)50.00, 200);
            Book book6 = new Book("", "", "", (decimal)60.00, 200);
            Book book7 = new Book("", "", "", (decimal)70.00, 100);
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);
            basket.AddBookToBasket(book7);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooksInBasket());

            //assert
            decimal sumOfPrices = (decimal)(10.00 + 20.00 + 30.00 + 40.00 + 50.00 + 60.00 + 70.00);
            Assert.That(actualValue, Is.EqualTo(sumOfPrices - (2 / 100) * sumOfPrices));
        }

        [Test]
        public void Test_CalculateFinalBasketPrice_RegistersCorrectDiscountAndReturnsCorrectTotalPrice_When10BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book("", "", "", (decimal)10.00, 70);
            Book book2 = new Book("", "", "", (decimal)20.00, 200);
            Book book3 = new Book("", "", "", (decimal)30.00, 100);
            Book book4 = new Book("", "", "", (decimal)40.00, 70);
            Book book5 = new Book("", "", "", (decimal)50.00, 200);
            Book book6 = new Book("", "", "", (decimal)60.00, 200);
            Book book7 = new Book("", "", "", (decimal)70.00, 100);
            Book book8 = new Book("", "", "", (decimal)80.00, 200);
            Book book9 = new Book("", "", "", (decimal)90.00, 200);
            Book book10 = new Book("", "", "", (decimal)100.00, 100);
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);
            basket.AddBookToBasket(book7);
            basket.AddBookToBasket(book8);
            basket.AddBookToBasket(book9);
            basket.AddBookToBasket(book10);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooksInBasket());

            //assert
            decimal sumOfPrices = (decimal)(10.00 + 20.00 + 30.00 + 40.00 + 50.00 + 60.00 + 70.00 + 80.00 
                + 90.00 + 100.00);
            Assert.That(actualValue, Is.EqualTo(sumOfPrices - (3 / 100) * sumOfPrices
                - (10 / 100) * sumOfPrices));
        }

        [Test]
        public void Test_CalculateFinalBasketPrice_RegistersCorrectDiscountAndReturnsCorrectTotalPrice_When12BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            Book book1 = new Book("", "", "", (decimal)10.00, 70);
            Book book2 = new Book("", "", "", (decimal)20.00, 200);
            Book book3 = new Book("", "", "", (decimal)30.00, 100);
            Book book4 = new Book("", "", "", (decimal)40.00, 70);
            Book book5 = new Book("", "", "", (decimal)50.00, 200);
            Book book6 = new Book("", "", "", (decimal)60.00, 200);
            Book book7 = new Book("", "", "", (decimal)70.00, 100);
            Book book8 = new Book("", "", "", (decimal)80.00, 200);
            Book book9 = new Book("", "", "", (decimal)90.00, 200);
            Book book10 = new Book("", "", "", (decimal)100.00, 100);
            Book book11 = new Book("", "", "", (decimal)110.00, 200);
            Book book12 = new Book("", "", "", (decimal)120.00, 100);
            basket.AddBookToBasket(book1);
            basket.AddBookToBasket(book2);
            basket.AddBookToBasket(book3);
            basket.AddBookToBasket(book4);
            basket.AddBookToBasket(book5);
            basket.AddBookToBasket(book6);
            basket.AddBookToBasket(book7);
            basket.AddBookToBasket(book8);
            basket.AddBookToBasket(book9);
            basket.AddBookToBasket(book10);
            basket.AddBookToBasket(book11);
            basket.AddBookToBasket(book12);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooksInBasket());

            //assert
            decimal sumOfPrices = (decimal)(10.00 + 20.00 + 30.00 + 40.00 + 50.00 + 60.00 + 70.00 + 80.00
                + 90.00 + 100.00 + 110.00 + 120.00);
            Assert.That(actualValue, Is.EqualTo(sumOfPrices - (4 / 100) * sumOfPrices
                - (10 / 100) * sumOfPrices));
        }
    }
}

