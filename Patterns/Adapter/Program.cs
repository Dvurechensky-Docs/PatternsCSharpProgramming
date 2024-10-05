/*  Адаптер
    Конвенртирует интерфейс класса в другой интерфейс,
    ожидаемый клиентом. Позволяет классам 
    с разными интерфейсами работать вместе.
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var man = new Driver();
        var car = new Auto();   //машина она едет также как мотоцикл, всё отлично
        var camelTransport =    //но мы хотим добраться на пешем транспорте (на верблюде)
            new CamelToTransport(new Camel());

        man.Travel(camelTransport);
        man.Travel(car);

        Console.ReadKey();
        #endregion
    }
}

interface ITransport
{
    void Drive();
}

/// <summary>
/// Шаблон автомобиля
/// </summary>
class Auto : ITransport
{
    public void Drive()
    {
        Console.WriteLine(GetType().Name + " Move");
    }
}

/// <summary>
/// Шаблон верблюда
/// </summary>
class Camel
{
    public void Move()
    {
        Console.WriteLine(GetType().Name + " Move");
    }
}

/// <summary>
/// Шаблон движения верблюда
/// </summary>
class CamelToTransport : ITransport
{
    Camel camel;

    public CamelToTransport(Camel camel)
    {
        this.camel = camel;
    }

    public void Drive()
    {
        camel.Move();
    }
}

/// <summary>
/// Шаблон путешественника
/// </summary>
class Driver
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}