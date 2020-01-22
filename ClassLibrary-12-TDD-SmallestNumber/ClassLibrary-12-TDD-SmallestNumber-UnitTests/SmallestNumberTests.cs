using ClassLibrary_12_TDD_SmallestNumber_MainCode;
using NUnit.Framework;

namespace ClassLibrary_12_TDD_SmallestNumber_UnitTests
{
    public class SmallestNumberTests
    {
        [Test]
        public void Num1Test_GetSmallestNumber_ExpectZero_WhenOnlyZeroIsSent()
        {
            //arrange
            int num = 0;
            SmallestNumber smallestNumber = new SmallestNumber();

            //act
            int actualValue = smallestNumber.GetSmallestNumber(num);
            int expectedValue = 0;

            //arrange
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num2Test_GetSmallestNumber_ExpectOne_WhenOnlyOneIsSent()
        {
            //arrange
            int num = 1;
            SmallestNumber smallestNumber = new SmallestNumber();

            //act
            int actualValue = smallestNumber.GetSmallestNumber(num);
            int expectedValue = 1;

            //arrange
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num3Test_GetSmallestNumber_ExpectZero_WhenEmptyListIsSent()
        {
            //arrange
            int[] num = new int[] { };
            SmallestNumber smallestNumber = new SmallestNumber();

            //act
            int actualValue = smallestNumber.GetSmallestNumber(num);
            int expectedValue = 0;

            //arrange
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num4Test_GetSmallestNumber_Expect1_When1And5IsSent()
        {
            //arrange
            int[] num = new int[] {5, 1};
            SmallestNumber smallestNumber = new SmallestNumber();

            //act
            int actualValue = smallestNumber.GetSmallestNumber(num);
            int expectedValue = 1;

            //arrange
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num5Test_GetSmallestNumber_ExpectMinus2_WhenListOfNumbersWithMinus2AsTheLowestIsSent()
        {
            //arrange
            int[] num = new int[] { 7, -2, 0, 1, -1 };
            SmallestNumber smallestNumber = new SmallestNumber();

            //act
            int actualValue = smallestNumber.GetSmallestNumber(num);
            int expectedValue = -2;

            //arrange
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }
    }
}
