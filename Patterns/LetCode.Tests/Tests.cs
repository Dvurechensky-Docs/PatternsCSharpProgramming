/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 ноября 2025 09:08:19
 * Version: 1.0.103
 */

namespace LetCode.Tests
{
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Индексы чисел в массиве образующих число target
        /// </summary>
        [TestMethod]
        public void TwoSumTest()
        {
            // arrange
            int[] input = { 1, 2, 3 };
            int[] expected = { 0, 2 };

            // act
            var actual = LetCodeTasks.TwoSum(input, 4);

            // arrange
            CollectionAssert.AreEqual(expected, actual, $"actual: {string.Join(',', actual)}, expected: {string.Join(',', expected)}");
        }

        [TestMethod]
        public void IsPalindromeTest()
        {
            // arrange
            int input = 99;
            bool expected = true;

            // act
            var actual = LetCodeTasks.IsPalindrome(input);

            // arrange
            Assert.AreEqual(expected, actual, $"actual: {actual}, expected: {expected}");
        }

        [TestMethod]
        public void RomanToIntTest()
        {
            // arrange
            string input = "MCMXCIV";
            int expected = 1994;

            // act
            var actual = LetCodeTasks.RomanToInt(input);

            // arrange
            Assert.AreEqual(expected, actual, $"actual: {actual}, expected: {expected}");
        }

        [TestMethod]
        public void LongestCommonPrefixTest()
        {
            // arrange
            string[] input = { "XXVIII", "XX", "XXII" };
            string expected = "XX";

            // act
            var actual = LetCodeTasks.LongestCommonPrefix(input);

            // arrange
            Assert.AreEqual(expected, actual, $"actual: {actual}, expected: {expected}");
        }
    }
}