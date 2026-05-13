/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 мая 2026 06:51:40
 * Version: 1.0.271
 */

using System.Diagnostics;

namespace Base.Tests;

[TestClass]
public class TestInitAndCleanUp
{
    private ClassMain main;
    private string Name;

    /// <summary>
    /// Запускается перед каждым тестируемым методом
    /// </summary>
    [TestInitialize]
    public void TestInitialize()
    {
        Debug.WriteLine("Test Initialize");
        main = new ClassMain();
        main.Name = "Nikolay";
    }

    /// <summary>
    /// Запускается после каждого завершения тестирования метода
    /// </summary>
    [TestCleanup]
    public void MainCleanUp()
    {
        Debug.WriteLine("Test CleanUp");
        Name = string.Empty;
    }

    [TestMethod]
    public void AddName()
    {
        Name = "Nikolay";
        Assert.AreEqual(Name, main.Name);
    }
}
