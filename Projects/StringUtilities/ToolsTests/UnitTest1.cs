using StringUtilities.Tools;

namespace ToolsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseString_ShouldReturnReversedString_WhenGivenAString()
        {
            //Arrange

            // Act
            var result = Tools.ReverseString("hello");

            // Assert
            Assert.AreEqual("olleh", result);
        }

        [TestMethod]
        public void ReverseString_ShouldReturnEmptyString_WhenGivenEmptyString()
        {
            //Arrange

            // Act
            var result = Tools.ReverseString("");

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void IsPalindrome_ShouldReturnTrue_WhenGivenPalindrome()
        {
            //Arrange

            // Act
            var result = Tools.IsPalindrome("racecar");

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsPalindrome_ShouldReturnFalse_WhenNotGivenPalindrome()
        {
            //Arrange

            // Act
            var result = Tools.IsPalindrome("race");

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsPalindrome_ShouldReturnFalse_WhenGivenEmptyString()
        {
            //Arrange

            // Act
            var result = Tools.IsPalindrome("");

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CountVowels_ShouldCountVowels_WhenGivenString()
        {
            // Act
            var result = Tools.CountVowels("The English alphabet has five vowels: A, E, I, O, and U.");

            //Assert
            Assert.AreEqual(17, result);
        }

        [TestMethod]
        public void CountVowels_ShouldCountZero_WhenGivenNoVowels()
        {
            // Act
            var result = Tools.CountVowels("");

            //Assert
            Assert.AreEqual(0, result);
        }
    }
}