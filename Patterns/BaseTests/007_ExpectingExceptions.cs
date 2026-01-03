/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 января 2026 14:59:52
 * Version: 1.0.139
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
