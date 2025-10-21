/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:27:30
 * Version: 1.0.65
 */

namespace Base.Tests;

[TestClass]
public class ExpectingExceptions
{
    /// <summary>
    /// Проверка метода на возврат исключения
    /// </summary>
    [ExpectedException(typeof(ArgumentNullException), "Exception was not throw")]
    [TestMethod]
    public void AssertMsTestExceptionTest()
    {
        var ms = new AssertMsTest();
        ms.SayHello(null);
    }

    [TestMethod]
    public void AssertMsTestReturnTest()
    {
        var name = "Hi! Nikolay";

        var ms = new AssertMsTest();
        var actual = ms.SayHello("Nikolay");
        
        Assert.AreEqual(name, actual, $"name: {name} act: {actual}");
    }
}
