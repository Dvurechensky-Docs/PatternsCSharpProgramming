﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:27:30
 * Version: 1.0.65
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