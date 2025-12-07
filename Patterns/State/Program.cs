/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 декабря 2025 12:56:49
 * Version: 1.0.112
 */

/*  Состояние
    Позволяет объекту изменять
    своё поведение в зависимости от 
    внутреннего состояния
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var contextA = new Context(new StateA());
        var contextB = new Context(new StateB());
        contextA.Request();
        contextB.Request();
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Абстракция состояния
/// </summary>
abstract class State
{
    public abstract void Handle(Context context);
}

/// <summary>
/// Реализация состояния A
/// </summary>
class StateA : State
{
    public StateA()
    {
        Console.WriteLine("State-A Create...");
    }

    public override void Handle(Context context)
    {
        context.State = new StateB();
    }
}

/// <summary>
/// Реализация состояния B
/// </summary>
class StateB : State
{
    public StateB()
    {
        Console.WriteLine("State-B Create...");
    }

    public override void Handle(Context context)
    {
        context.State = new StateA();
    }
}

/// <summary>
/// Контекст со своим состоянием
/// </summary>
class Context
{
    public State State { get; set; }

    public Context(State state)
    {
        State = state;
    }

    public void Request()
    {
        State.Handle(this);
    }
}