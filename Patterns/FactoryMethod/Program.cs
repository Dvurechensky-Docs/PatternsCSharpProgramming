/*  Фабричный метод
    Определяет интерфейс для создания объекта,
    но позволяет подклассам решать, какой класс создавать.
    Позволяет делегировать создание класса
    объектам класса.
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var ltd = new WoodDeveloper();
        ltd.Create();

        var rss = new OfficeDeveloper();
        rss.Create();

        Creator<WoodDeveloper> ltdEx = new Creator<WoodDeveloper>();
        var a1 = ltdEx.FactoryMethod();
        a1.Create();
        Creator<OfficeDeveloper> rssEx = new Creator<OfficeDeveloper>();
        var a2 = rssEx.FactoryMethod();
        a2.Create();

        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// *** представления через обобщения (нельзя инициализировать через параметризированный конструктор)
/// </summary>
/// <typeparam name="T">обобщающий тип</typeparam>
class Creator<T> where T : Developer, new()
{
    public T FactoryMethod() { return new T(); }
}

/// <summary>
/// Cтроительная компания - базовая логика
/// </summary>
abstract class Developer
{
    protected string Name { get; set; }

    public Developer(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Фабричный метод
    /// </summary>
    /// <returns>House</returns>
    public abstract House Create();             
}

class WoodDeveloper : Developer
{
    public WoodDeveloper() : base("Wood Develop LTD")
    {
    }

    public override House Create()
    {
        return new PanelHouse();
    }
}

class OfficeDeveloper : Developer
{
    public OfficeDeveloper() : base("Office Develop RSS")
    {
    }

    public override House Create()
    {
        return new OfficeHouse();
    }
}

/// <summary>
/// Общая логика операций над строением
/// </summary>
abstract class House
{
    public abstract void Build();
}

/// <summary>
/// Панельный дом
/// </summary>
class PanelHouse : House
{
    public PanelHouse()
    {
        Build();
    }

    public override void Build()
    {
        Console.WriteLine("Build Panel House");
    }
}

/// <summary>
/// Офисное здание
/// </summary>
class OfficeHouse : House
{
    public OfficeHouse()
    {
        Build();
    }

    public override void Build()
    {
        Console.WriteLine("Build Office House");
    }
}