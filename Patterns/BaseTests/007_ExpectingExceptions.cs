/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 июля 2026 07:26:25
 * Version: 1.0.328
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
