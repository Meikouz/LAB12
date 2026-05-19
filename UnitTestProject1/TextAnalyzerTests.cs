using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB12;

namespace UnitTestProject1
{
    [TestClass]
    public class TextAnalyzerTests
    {
        [TestMethod]
        public void CountIntegers_NullText_ReturnsZero()
        {
            string text = null;
            int expected = 0;

            int actual = TextAnalyzer.CountIntegers(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountIntegers_EmptyText_ReturnsZero()
        {
            string text = "";
            int expected = 0;

            int actual = TextAnalyzer.CountIntegers(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountIntegers_TextWithoutNumbers_ReturnsZero()
        {
            string text = "У цьому тексті немає чисел";
            int expected = 0;

            int actual = TextAnalyzer.CountIntegers(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountIntegers_TextWithOneInteger_ReturnsOne()
        {
            string text = "Є одне число 25";
            int expected = 1;

            int actual = TextAnalyzer.CountIntegers(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountIntegers_TextWithSignedIntegers_ReturnsThree()
        {
            string text = "Температура -5, завтра +7, зараз 0";
            int expected = 3;

            int actual = TextAnalyzer.CountIntegers(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountIntegers_TextWithSeveralIntegers_ReturnsFour()
        {
            string text = "1, 2, 3 і 4";
            int expected = 4;

            int actual = TextAnalyzer.CountIntegers(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountIntegers_TextWithDecimalNumber_CountsOnlyInteger()
        {
            string text = "Число 3.14 не ціле, а 10 ціле";
            int expected = 1;

            int actual = TextAnalyzer.CountIntegers(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountIntegers_DigitsInsideWords_AreNotCounted()
        {
            string text = "room42 abc123 test";
            int expected = 0;

            int actual = TextAnalyzer.CountIntegers(text);

            Assert.AreEqual(expected, actual);
        }
    }
}