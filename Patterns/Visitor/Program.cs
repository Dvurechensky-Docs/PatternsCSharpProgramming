/*  Посетитель  
    Представляет собой операцию, которая
    будет выполнена над объектами группы классов.
    Даёт возможность определить новую операцию
    без изменения кода классов, над которыми
    эта операция производитcя.
 */
class Program
{
    public static void Main(string[] args)
    {
        #region Пример №1 - базовое
        var bank = new Bank();
        bank.Add(new Person(Name: "Joshua", Number: 1997));
        bank.Add(new Company(Name: "Microsoft", Number: 1904));
        bank.Accept(new HtmlVisitor());
        bank.Accept(new XmlVisitor());
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Поведение посетителя
/// отделяет логику сериализации от классов в которых она применима
/// </summary>
interface IVisitor
{
    void VisitPersonAcc(Person person);
    void VisitCompanyAcc(Company company);
}

/// <summary>
/// Поведение аккаунта
/// </summary>
interface IAccaunt
{
    void Accept(IVisitor visitor);
}

/// <summary>
/// Шаблон банка
/// </summary>
class Bank
{
    List<IAccaunt> Accaunts;

    public Bank()
    {
        Accaunts = new List<IAccaunt>();
    }

    /// <summary>
    /// Добавить аккаунт
    /// </summary>
    /// <param name="accaunt">аккаунт</param>
    public void Add(IAccaunt accaunt)
    {
        Accaunts.Add(accaunt);
    }

    /// <summary>
    /// Удаллить аккаунт
    /// </summary>
    /// <param name="accaunt">аккаунт</param>
    public void Remove(IAccaunt accaunt)
    {
        Accaunts.Remove(accaunt);
    }

    /// <summary>
    /// Получить доступ к своему аккаунту
    /// </summary>
    /// <param name="visitor">пользователь</param>
    public void Accept(IVisitor visitor)
    {
        foreach (var accaunt in Accaunts)
            accaunt.Accept(visitor);
    }
}

/// <summary>
/// Пользователь
/// </summary>
/// <param name="Name">Имя</param>
/// <param name="Number">Номер</param>
record Person(string Name, int Number) : IAccaunt
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitPersonAcc(this);
    }
}

/// <summary>
/// Компания
/// </summary>
/// <param name="Name">Имя</param>
/// <param name="Number">Номер</param>
record Company(string Name, int Number) : IAccaunt
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitCompanyAcc(this);
    }
}

/// <summary>
/// HTML сериализатор
/// </summary>
class HtmlVisitor : IVisitor
{
    public void VisitCompanyAcc(Company company)
    {
        Console.WriteLine($"[HTML] {company}");
    }

    public void VisitPersonAcc(Person person)
    {
        Console.WriteLine($"[HTML] {person}");
    }
}

/// <summary>
/// XML сериализатор
/// </summary>
class XmlVisitor : IVisitor
{
    public void VisitCompanyAcc(Company company)
    {
        Console.WriteLine($"[XML] {company}");
    }

    public void VisitPersonAcc(Person person)
    {
        Console.WriteLine($"[XML] {person}");
    }
}