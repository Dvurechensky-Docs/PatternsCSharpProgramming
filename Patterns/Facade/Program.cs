﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 сентября 2025 10:48:30
 * Version: 1.0.21
 */

/*  Фасад
    Предоставляет единый интерфейс к группе
    интерфейсов подсистемы. Определяет высокоуровневый
    интерфейс, делая систему проще для использования.
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var facade = new Facade(new A(), new B());
        facade.Start();
        Console.ReadKey();
        #endregion
    }
}

class Facade
{
    ILogic logic1;
    ILogic logic2;
    public Facade(ILogic logic1, ILogic logic2)
    {
        this.logic1 = logic1;
        this.logic2 = logic2;
    }

    public void Start()
    {
        logic1.Process();
        logic2.Process();
    }
}

interface ILogic
{
    void Process();
}


class A : ILogic
{
    public void Process()
    {
        Console.WriteLine("Some Process " + GetType().Name);
    }
}

class B : ILogic
{
    public void Process()
    {
        Console.WriteLine("Some Process " + GetType().Name);
    }
}