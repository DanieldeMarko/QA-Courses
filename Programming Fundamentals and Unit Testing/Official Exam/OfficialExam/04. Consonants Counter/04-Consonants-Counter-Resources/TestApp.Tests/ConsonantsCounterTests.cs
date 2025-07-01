using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class ConsonantsCounterTests
    {
        [Test]
        public void Test_CountTotalConsonants_GetEmptyList_ReturnsZero()
        {
            // Arrange
            List<string> words = new List<string>();
            int expected = 0;

            // Act
            int actual = ConsonantsCounter.CountTotalConsonants(words);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_GetListWithEmptyStringValues_ReturnsZero()
        {
            // Arrange
            List<string> words = new List<string> { "", "", "" };
            int expected = 0;

            // Act
            int actual = ConsonantsCounter.CountTotalConsonants(words);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_MultipleStrings_ReturnsConsonantsCount()
        {
            // Arrange
            List<string> words = new List<string> { "hello", "world", "test" };
            int expected = 10; // "hello" = 3, "world" = 3, "test" = 4

            // Act
            int actual = ConsonantsCounter.CountTotalConsonants(words);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_GetStringsWithNoConsonants_ReturnsZero()
        {
            // Arrange
            List<string> words = new List<string> { "aeiou", "ae", "oia" }; // Only vowels
            int expected = 0;

            // Act
            int actual = ConsonantsCounter.CountTotalConsonants(words);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_StringsWithMixedCaseConsonants_ReturnsConsonantsCount()
        {
            // Arrange
            List<string> words = new List<string> { "HeLLo", "WoRLd", "TesT" };
            int expected = 10; // Case shouldn't matter: "HeLLo" = 3, "WoRLd" = 3, "TesT" = 4

            // Act
            int actual = ConsonantsCounter.CountTotalConsonants(words);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
