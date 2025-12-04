/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 декабря 2025 13:19:42
 * Version: 1.0.109
 */

using System.Text.RegularExpressions;

namespace Base.Tests;

[TestClass]
public class StringAssetMethods
{
    /// <summary>
    /// Проверка подстроки в строке
    /// </summary>
    [TestMethod]
    public void StringContainsTest()
    {
        StringAssert.Contains("Assert samples", "sam");
    }

    /// <summary>
    /// ПРоверка с использованием регулярного выражения
    /// </summary>
    [TestMethod]
    public void StringMathesTest()
    {
        // проверяет наличие трёх цифр подряд
        StringAssert.Matches("123", new Regex(@"\d{3}"));
    }

    /// <summary>
    /// Проверка начала строки на соответствие условию
    /// </summary>
    [TestMethod]
    public void StringStartsWithTest()
    {
        StringAssert.StartsWith("Hello London", "H");
    }

    /// <summary>
    /// Проверка конца строки на соответствие условию
    /// </summary>
    [TestMethod]
    public void StringEndWithTest()
    {
        StringAssert.EndsWith("Hello Moscow", "w");
    }
}
