namespace Base.Tests;

/// <summary>
/// Проверяет результат работы с коллекциями
/// </summary>
[TestClass]
public class CollectionAssertMethods
{
    public static List<string> employees;

    [ClassInitialize]
    public static void InitializeCurrentTest(TestContext context)
    {
        employees = new List<string>();

        employees.Add("Nikolay");
        employees.Add("Oleg");
    }

    /// <summary>
    /// Проверка значений коллекции на наличие в ней
    /// </summary>
    [TestMethod]
    public void AllItemAreNotNullTest()
    {
        CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
    }

    /// <summary>
    /// Проверка значения коллекции на уникальность
    /// </summary>
    [TestMethod]
    public void AllItemsAreUniqueTest()
    {
        CollectionAssert.AllItemsAreUnique(employees, "Uniqueness failed");
    }

    /// <summary>
    /// Проверяет каждый элемент списка на равенство с входящим списком
    /// </summary>
    [TestMethod]
    public void AreEqualTest()
    {
        var currList = new List<string>();

        currList.Add("Nikolay");
        currList.Add("Oleg");

        CollectionAssert.AreEqual(currList, employees);
    }

    /// <summary>
    /// Проверяем наличии одного List в другом
    /// </summary>
    [TestMethod]
    public void SubsetTest()
    {
        var subsetList = new List<string>();

        subsetList.Add(employees[1]);
        //subsetList.Add("Mig"); //ошибка так как этот элемент не входит в employees

        CollectionAssert.IsSubsetOf(subsetList, employees, "not elements subsetList to employees");
    }
}
