using _14_TestCase_ParametrisedTests_Grade_MainCode;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class GradeTest
    {
        [TestCase(74, "Fail")]
        [TestCase(75, "Pass")]
        [TestCase(84, "Pass")]
        [TestCase(85, "Merit")]
        public void GetGrade_GetsRightGrade_ForScore(int score, string expectedGrade)
        {
            //act
            string actualValue = Grade.GetGrade(score);

            //assert
            Assert.That(actualValue, Is.EqualTo(expectedGrade));
        }
    }
}
