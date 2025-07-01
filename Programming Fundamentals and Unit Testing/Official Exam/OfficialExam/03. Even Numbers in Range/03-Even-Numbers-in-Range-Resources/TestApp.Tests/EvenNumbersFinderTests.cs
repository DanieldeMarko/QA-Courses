using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class EvenNumbersFinderTests
    {
        [Test]
        public void Test_FindEvenNumbers_StartGreaterThanEnd_ReturnsErrorMessage()
        {
            // Arrange
            int start = 10, end = 5;
            string expected = "Start number should not be greater than end number.";

            // Act
            string actual = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_NoEvenNumbersInRange_ReturnsEmptyString()
        {
            // Arrange
            int start = 1, end = 1; // Only contains odd numbers
            string expected = "";

            // Act
            string actual = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_SingleEvenNumberInRange_ReturnsThatNumber()
        {
            // Arrange
            int start = 2, end = 2; // Single even number
            string expected = "2";

            // Act
            string actual = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_MultipleEvenNumbersInRange_ReturnsEvenNumbers()
        {
            // Arrange
            int start = 2, end = 10;
            string expected = "2 4 6 8 10";

            // Act
            string actual = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_ZeroInRange_ReturnsZero()
        {
            // Arrange
            int start = -2, end = 2;
            string expected = "-2 0 2";

            // Act
            string actual = EvenNumbersFinder.FindEvenNumbers(start, end);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
