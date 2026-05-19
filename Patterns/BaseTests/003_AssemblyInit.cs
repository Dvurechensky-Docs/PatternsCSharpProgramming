/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 мая 2026 10:14:56
 * Version: 1.0.277
 */

namespace Base.Tests;

[TestClass]
public class AssemblyInit
{
    /// <summary>
    /// Код выполняется один раз на всю сборку
    /// Используется во всех Unit тестах во всех тестовых вкладках
    /// </summary>
    /// <param name="testContext"></param>
    [AssemblyInitialize]
    public static void TestMethodInit(TestContext testContext)
    {
        Console.WriteLine("Test AssemblyInitialize: " + testContext.TestName);
    }

    /// <summary>
    /// Код выполняется один раз на всю сборку
    /// Используется во всех Unit тестах во всех тестовых вкладках
    /// </summary>
    [AssemblyCleanup]
    public static void TestMethodGlobalCleanUp()
    {
        Console.WriteLine("Test AssemblyCleanup");
    }
}
