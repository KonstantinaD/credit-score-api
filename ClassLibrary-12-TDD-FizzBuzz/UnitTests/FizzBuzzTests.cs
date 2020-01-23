using ClassLibrary_12_TDD_FizzBuzz_MainCode;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Num1Test_DoFizzBuzz_Expect1_When1IsSent()
        {
            //arrange
            string[] numbers =  new string[] { "1" } ;
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { "1" }; 

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num2Test_DoFizzBuzz_ExpectEmptyList_WhenEmptyListIsSent()
        {
            //arrange
            string[] numbers = new string[] { };
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { };

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num3Test_DoFizzBuzz_Expect1And4_When1And4IsSent()
        {
            //arrange
            string[] numbers = new string[] {"1","4"};
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { "1", "4" };

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num4Test_DoFizzBuzz_ExpectFizz_When3IsSent()
        {
            //arrange
            string[] numbers = new string[] { "3" };
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { "FIZZ" }; 

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num5Test_DoFizzBuzz_Expect2AndFizz_When2And3IsSent()
        {
            //arrange
            string[] numbers = new string[] { "2", "3" };
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { "2", "FIZZ" };

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num5Test_DoFizzBuzz_ExpectBuzz_When5IsSent()
        {
            //arrange
            string[] numbers = new string[] { "5" };
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { "BUZZ" };

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num6Test_DoFizzBuzz_ExpectBuzzAnd8_When5And8IsSent()
        {
            //arrange
            string[] numbers = new string[] { "5", "8" };
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { "BUZZ", "8" };

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num7Test_DoFizzBuzz_ExpectBuzzTwoAndFizz_WhenFiveTwoAndThreeIsSent()
        {
            //arrange
            string[] numbers = new string[] { "5", "2", "3" };
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { "BUZZ", "2", "FIZZ" };

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num8Test_DoFizzBuzz_ExpectFizzBuzz_When15IsSent()
        {
            //arrange
            string[] numbers = new string[] { "15" };
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { "FIZZ BUZZ" };

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void Num9Test_DoFizzBuzz_ExpectCorrectCombination_WhenValuesIsSent()
        {
            //arrange
            string[] numbers = new string[] { "11", "15", "9", "20", "1", "18", "45", "25" };
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            string[] actualValue = fizzBuzz.DoFizzBuzz(numbers);
            string[] expectedValue = new string[] { "11", "FIZZ BUZZ", "FIZZ", "BUZZ", "1", "FIZZ", "FIZZ BUZZ", "BUZZ" };

            //assert
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }
    }
}
