/*  Мост
    Разделяет абстракцию и реализацию так, 
    чтобы они могли изменяться независимо друг от друга
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var programmer_1 = new FreelancerProgger(new CPPLang());
        programmer_1.DoWork();
        programmer_1.EarnMoney();
        var programmer_2 = new FreelancerProgger(new CSharpLang());
        programmer_2.DoWork();
        programmer_2.EarnMoney();
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Поведение языка
/// </summary>
interface ILanguage
{
    void Build();
    void Execute();
}

class CPPLang : ILanguage
{
    public void Build()
    {
        Console.WriteLine("C++ compile");
    }

    public void Execute()
    {
        Console.WriteLine("C++ Start");
    }
}

class CSharpLang : ILanguage
{
    public void Build()
    {
        Console.WriteLine("C# compile");
    }

    public void Execute()
    {
        Console.WriteLine("C# Start");
    }
}

abstract class Programmer
{
    protected ILanguage language;
    public ILanguage Language
    {
        set { language = value; }
    }

    public Programmer(ILanguage language)
    {
        Language = language;
    }

    public virtual void DoWork()
    {
        language.Build();
        language.Execute();
    }

    public abstract void EarnMoney();
}

class FreelancerProgger : Programmer
{
    public FreelancerProgger(ILanguage language) : base(language) { }

    public override void EarnMoney()
    {
        Console.WriteLine("Получаем оплату за заказ");
    }
}

class CorporateProgger : Programmer
{
    public CorporateProgger(ILanguage language) : base(language) { }

    public override void EarnMoney()
    {
        Console.WriteLine("Получаем оплату в конце месяца");
    }
}