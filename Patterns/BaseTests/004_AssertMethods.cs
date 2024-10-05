namespace Base.Tests;

[TestClass]
public class AssertMethods
{
    [TestMethod]
    public void IsSqrtTest()
    {
        // arrange
        const double input = 4;
        const double expected = 2;

        // act
        var actual = AssertMsTest.GetSqrt(input);

        // assert - сравнивает два значения
        Assert.AreEqual(expected, actual, $"Sqrt of {input} should have been {expected}");
    }

    [TestMethod]
    public void DeltaTest()
    {
        const double expected = 3.1;
        const double delta = 0.07;

        // 3.1622776601683795
        // 0.062..
        double actual = AssertMsTest.GetSqrt(10);

        // Проверка значений на равенство с учётом прогрешлоости delta
        Assert.AreEqual(expected, actual, delta, $"Sqrt of {actual} should have been {expected}");
    }

    [TestMethod]
    public void StringAreEqualTest()
    {
        // arrange
        const string expected = "hello";
        const string input = "HELLO";

        // act and assert
        // третий параметр игнорирование регистра
        Assert.AreEqual(expected, input, true);
    }

    [TestMethod]
    public void StringAreSameTest() 
    {
        string a = "Hello";
        string b = "Hello";
    
        // проверка равенства ссылок
        Assert.AreSame(a, b);
    }

    [TestMethod]
    public void IntegerAreSameTest()
    {
        int a = 10;
        int b = 10;

        // проверка равенства ссылок
        Assert.AreSame(a, b);
    }
}
