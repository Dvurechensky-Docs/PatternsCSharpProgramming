/*  Посредник
    Определяет объект инкапсулирующий способ
    взаимодействия объектов. Обеспечивает слабую связь,
    избавляя их от необходимости ссылаться друг на друга
    и даёт возможность независимо изменять их взаимодействие.
 */
class Program
{
    public static void Main(string[] args)
    {
        #region Пример №1 - базовое
        ManagerMediator mediator = new ManagerMediator();
        Colleague customer = new CustomerCollegue(mediator);
        Colleague programmer = new ProgrammerCollegue(mediator);
        Colleague tester = new TesterCollegue(mediator);
        mediator.Customer = customer;
        mediator.Programmer = programmer;
        mediator.Tester = tester;
        customer.Send("Есть заказ! Нужно сделать REST API");
        programmer.Send("REST API готов, нужно протестировать swagger");
        tester.Send("Тест прошёл успешно, документация отличная!");
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Интерфейс для взаимодействия с посредником
/// </summary>
abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}

/// <summary>
/// Интерфейс для взаимодействия с коллегами
/// </summary>
abstract class Colleague
{
    Mediator Mediator { get; set; }

    public Colleague(Mediator mediator)
    {
        Mediator = mediator;
    }

    public virtual void Send(string message)
    {
        Mediator.Send(message, this);
    }

    public abstract void Notify(string message);
}

/// <summary>
/// Непосредственный заказчик
/// </summary>
class CustomerCollegue : Colleague
{
    public CustomerCollegue(Mediator mediator) : base(mediator) {}

    public override void Notify(string message)
    {
        Console.WriteLine($"Сообщение заказчику: {message}");
    }
}

/// <summary>
/// Программист
/// </summary>
class ProgrammerCollegue : Colleague
{
    public ProgrammerCollegue(Mediator mediator) : base(mediator) { }

    public override void Notify(string message)
    {
        Console.WriteLine($"Сообщение программисту: {message}");
    }
}

/// <summary>
/// Тестировщик
/// </summary>
class TesterCollegue : Colleague 
{
    public TesterCollegue(Mediator mediator) : base(mediator) { }

    public override void Notify(string message)
    {
        Console.WriteLine($"Сообщение тестировщику: {message}");
    }
}

/// <summary>
/// Посредник
/// </summary>
class ManagerMediator : Mediator
{
    public Colleague Customer { get; set; }
    public Colleague Programmer { get; set; }
    public Colleague Tester { get; set; }

    public override void Send(string message, Colleague colleague)
    {
        if(Customer == colleague)           //если отправитель заказчик значит есть новый заказ
            Programmer.Notify(message);     //отправляем сообщение программисту - сделать заказ
        else if(Programmer == colleague)    //если отправитель программист 
            Tester.Notify(message);         //отправляем сообщение тестировщику
        else if(Tester == colleague)        //если отправитель тестировщик 
            Customer.Notify(message);       //значит оповещаем заказчика
    }
}