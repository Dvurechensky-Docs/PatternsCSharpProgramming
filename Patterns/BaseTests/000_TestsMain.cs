/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:34:53
 * Version: 1.0.13
 */

using Base;

namespace BaseTests;

/// <summary>
/// Модульный тест
/// Конфигурирование:
/// Чтобы добавить возможность вызывать методы какого-либо проекта
/// Нажимаем правой кнопкой на зависимости в данном проекте
/// Выбираем пункт - добавить ссылку на проект
/// </summary>
[TestClass]
public class TestsMain
{
    /// <summary>
    /// Реализация тестового метода модульного теста
    /// </summary>
    [TestMethod]
    public void TestMethod1()
    {
        // arrange
        int expected = 3;

        // act 
        var classMain = new ClassMain(4, "Unit", 10);
        int actual = classMain.countBuild;

        // assert
        Assert.AreEqual(expected, actual, 0.001, "BuildCount not correctly");   //сравниваем полученное значение с требуемым
    }
}