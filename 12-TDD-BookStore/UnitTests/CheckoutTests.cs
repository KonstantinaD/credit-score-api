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
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooks());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateAccumulativeDiscount_Returns0_When1BookInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBook(new Book());

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);
            basket.AddBook(book7);

            //act
            decimal actualDiscount = checkout.CalculateAccumulativeDiscount(basket.FindAllBooks());

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
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns0_When1BookInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBook(new Book());
       

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);
            basket.AddBook(book7);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);
            basket.AddBook(book7);
            basket.AddBook(book8);


            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);
            basket.AddBook(book7);
            basket.AddBook(book8);
            basket.AddBook(book9);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);
            basket.AddBook(book7);
            basket.AddBook(book8);
            basket.AddBook(book9);
            basket.AddBook(book10);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);
            basket.AddBook(book7);
            basket.AddBook(book8);
            basket.AddBook(book9);
            basket.AddBook(book10);
            basket.AddBook(book11);

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(10));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns10_When20BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(10));
        }

        [Test]
        public void Test_CalculateOneOffDiscount_Returns10_When21BooksInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());
            basket.AddBook(new Book());

            //act
            decimal actualDiscount = checkout.CalculateOneOffDiscount(basket.FindAllBooks());

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
            decimal actualDiscount = checkout.CalculateSumOfPrices(basket.FindAllBooks());

            //assert
            Assert.That(actualDiscount, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateSumOfPrices_ReturnsBookPrice_When1BookInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBook(new Book("", "", "", (decimal)20.25, 60));


            //act
            decimal actualValue = checkout.CalculateSumOfPrices(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);

            //act
            decimal actualDiscount = checkout.CalculateSumOfPrices(basket.FindAllBooks());

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
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooks());

            //assert
            Assert.That(actualValue, Is.EqualTo(0));
        }

        [Test]
        public void Test_CalculateFinalBasketPrice_ReturnsBookPrice_When1BookInBasket()
        {
            //arrange
            Checkout checkout = new Checkout();
            Basket basket = new Basket();
            basket.AddBook(new Book("", "", "", (decimal)20.25, 60));


            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);
            basket.AddBook(book7);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);
            basket.AddBook(book7);
            basket.AddBook(book8);
            basket.AddBook(book9);
            basket.AddBook(book10);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooks());

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
            basket.AddBook(book1);
            basket.AddBook(book2);
            basket.AddBook(book3);
            basket.AddBook(book4);
            basket.AddBook(book5);
            basket.AddBook(book6);
            basket.AddBook(book7);
            basket.AddBook(book8);
            basket.AddBook(book9);
            basket.AddBook(book10);
            basket.AddBook(book11);
            basket.AddBook(book12);

            //act
            decimal actualValue = checkout.CalculateFinalBasketPrice(basket.FindAllBooks());

            //assert
            decimal sumOfPrices = (decimal)(10.00 + 20.00 + 30.00 + 40.00 + 50.00 + 60.00 + 70.00 + 80.00
                + 90.00 + 100.00 + 110.00 + 120.00);
            Assert.That(actualValue, Is.EqualTo(sumOfPrices - (4 / 100) * sumOfPrices
                - (10 / 100) * sumOfPrices));
        }
    }
}

