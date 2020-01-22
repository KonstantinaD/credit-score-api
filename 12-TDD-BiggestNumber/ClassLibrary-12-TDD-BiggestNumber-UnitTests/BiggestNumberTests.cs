using ClassLibrary_12_TDD_BiggestNumber_MainCode;
using NUnit.Framework;
using System;

namespace ClassLibrary_12_TDD_BiggestNumber_UnitTests
{
    [TestFixture]
    public class BiggestNumberTests
    {
        [Test]
        public void Num1Test_GetBiggestNumber_ExpectZero_WhenOnlyZeroIsSent()
        {
            //arrange
            int num1 = 0;
            BiggestNumber biggestNumber = new BiggestNumber();

            //act           
            int actualVal = biggestNumber.GetBiggestNumber(num1);
            int expected = 0;

            //assert
            Assert.AreEqual(expected, actualVal);
        }

        [Test]
        public void Num2Test_GetBiggestNumber_ExpectZero_WhenOnlyOneIsSent()
        {
            //arrange
            int num1 = 1;
            BiggestNumber biggestNumber = new BiggestNumber();

            //act           
            int actualVal = biggestNumber.GetBiggestNumber(num1);
            int expected = 1;

            //assert
            Assert.AreEqual(expected, actualVal);
        }

        [Test]
        public void Num3Test_GetBiggestNumber_Expect0_WhenEmptyIsSent()
        {
            //arrange
            int[] num1 = new int[] { };

            BiggestNumber biggestNumber = new BiggestNumber();

            //act           
            int actualVal = biggestNumber.GetBiggestNumber(num1);
            int expected = 0;

            //assert
            Assert.AreEqual(expected, actualVal);
        }

        [Test]
        public void Num4Test_GetBiggestNumber_Expect5_When1and5IsSent()
        {
            //arrange
            int[] num1 = new int[] { 1, 5 };
            BiggestNumber biggestNumber = new BiggestNumber();

            //act           
            int actualVal = biggestNumber.GetBiggestNumber(num1);
            int expected = 5;

            //assert
            Assert.AreEqual(expected, actualVal);
        }

        [Test]
        public void Num5Test_GetBiggestNumber_Expect209_WhenalistOfNumWith209AsTheHighestIsSent()
        {
            //arrange
            int[] num1 = new int[] { 1, 5, 33, 59, 100, 209, 2, -1, -44, -1, 88, 200 };
            BiggestNumber biggestNumber = new BiggestNumber();

            //act           
            int actualVal = biggestNumber.GetBiggestNumber(num1);
            int expected = 209;

            //assert
            Assert.AreEqual(expected, actualVal);
        }
    }
}
