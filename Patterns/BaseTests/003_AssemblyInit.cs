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
