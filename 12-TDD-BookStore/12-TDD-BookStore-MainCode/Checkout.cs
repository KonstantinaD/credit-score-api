using System.Collections.Generic;

namespace _12_TDD_BookStore_MainCode
{
    public class Checkout
    {
        public int CalculateAccumulativeDiscount(List<Book> booksInBasket)
        {
            int accDiscount = 0;

            int numberOfTimes3IsInNumberOfBooksInBasket = booksInBasket.Count / 3;

            if (numberOfTimes3IsInNumberOfBooksInBasket >= 1)
            {
                for (int i = 0; i < numberOfTimes3IsInNumberOfBooksInBasket; i++)
                {
                    accDiscount += 1;
                }
            }

            return accDiscount;
        }

        public int CalculateOneOffDiscount(List<Book> booksInBasket)
        {
            int oneOffDiscount = 0;

            if (booksInBasket.Count >= 10)
            {
                oneOffDiscount = 10;
            }

            return oneOffDiscount;
        }

        public decimal CalculateSumOfPrices(List<Book> booksInBasket)
        {
            decimal sumOfPrices = 0;

            foreach (Book book in booksInBasket)
            {
                sumOfPrices += book.Price;
            }

            return sumOfPrices;
        }

        public decimal CalculateFinalBasketPrice(List<Book> booksInBasket)
        {
            decimal sumOfPrices = CalculateSumOfPrices(booksInBasket);

            decimal accDiscountAmount = (CalculateAccumulativeDiscount(booksInBasket) / 100) * sumOfPrices;

            decimal oneOffDiscountAmount = (CalculateOneOffDiscount(booksInBasket) / 100) * sumOfPrices;

            return sumOfPrices - accDiscountAmount - oneOffDiscountAmount;
        }
    }
}
