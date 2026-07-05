/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 июля 2026 10:55:42
 * Version: 1.0.325
 */


using System.Diagnostics;
using System.Xml.Linq;

namespace Base.Tests;

[TestClass]
public class ClassInitAndCleanUp
{
    private static ClassMain main;

    /// <summary>
    /// Запускается один раз перед тем как запустится один Unit Test
    /// Метод должен быть открытым, статическим и принимать параметр типа контекста
    /// </summary>
    /// <param name="context"></param>
    [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
        main = new ClassMain();
        main.Name = "Test";
    }

    /// <summary>
    /// Запускается после последнего тестируемого метода
    /// Метод должен быть открытым, статическим и возвращать void
    /// </summary>
    [ClassCleanup]
    public static void MainCleanUp()
    {
        Debug.WriteLine("Test CleanUp");
        main.Name = string.Empty;
    }

    [TestMethod]
    public void AddName()
    {
        var Name = "Test";
        Assert.AreEqual(Name, main.Name);
    }
}
