/*  Цепочка обязанностей
    Избегает связывание отправителя запроса
    с его получателем, давая возможность обработать
    запрос более чем одному объекту. Связывает
    объекты-получатели и передаёт запрос по цепочке
    пока объект не обработает его.
 */
class Program
{
    public static void GiveCommand(IWorker worker, string command)
    {
        var str = worker.Execute(command);
        if(string.IsNullOrEmpty(str)) Console.WriteLine(command + " - никто не выполнил команду");
        else Console.WriteLine(str);
    }

    static void Main()
    {
        #region Пример №1 - базовое
        Handler h1 = new ConcreateHandler1();
        Handler h2 = new ConcreateHandler2();
        h1.Successor = h2;
        h1.HandleRequest(2); //От первого до второго объекта обработка
        Console.WriteLine("Please press Enter...");
        Console.ReadKey();
        #endregion
        #region Пример №2 - этапы строительства дома
        var designer = new Designer();
        var programmer = new Programmer();
        var finishworker = new FinishWorker();
        designer.SetNetWorker(finishworker).SetNetWorker(programmer);

        GiveCommand(designer, "Спроектировать веранду");
        GiveCommand(designer, "Сделать машину времени");
        GiveCommand(designer, "Уволить работников");
        GiveCommand(designer, "Курить");
        #endregion
    }
}

/// <summary>
/// Передатчик
/// </summary>
abstract class Handler
{
    public Handler Successor { get; set; }
    public abstract void HandleRequest(int condition);
}

/// <summary>
/// Обработчик запроса №1
/// </summary>
class ConcreateHandler1 : Handler
{
    /// <summary>
    /// Обработка запроса
    /// </summary>
    /// <param name="condition">состояние</param>
    public override void HandleRequest(int condition)
    {   
        Console.WriteLine("1");
        if(condition == 1) return;              //завершаем выполнение
        else if(Successor != null)              
            Successor.HandleRequest(condition); //передача запроса дальше по цепи
    }
}

/// <summary>
/// Обработчик запроса №2
/// </summary>
class ConcreateHandler2 : Handler
{
    /// <summary>
    /// Обработка запроса
    /// </summary>
    /// <param name="condition">состояние</param>
    public override void HandleRequest(int condition)
    {   
        Console.WriteLine("2");
        if (condition == 2) return;             //завершаем выполнение
        else if (Successor != null)             //передача запроса дальше по цепи
            Successor.HandleRequest(condition);
    }
}

/// <summary>
/// Поведение рабочего
/// </summary>
interface IWorker
{
    /// <summary>
    /// Передача обязанностей следующему рабочему
    /// </summary>
    /// <param name="worker">следующий рабочий</param >
    IWorker SetNetWorker(IWorker worker);

    /// <summary>
    /// Рабочий принимает команду на исполнение
    /// </summary>
    /// <param name="command">команда</param>
    /// <returns>Резульат принятия</returns>
    string Execute(string command);
}

/// <summary>
/// Абстрактный рабочий, базовое описание структуры каждого
/// </summary>
abstract class AbsWorker : IWorker
{
    private IWorker nextWorker;
    public AbsWorker() => nextWorker = null;

    /// <summary>
    /// Изменяемый процесс обработки команды в классах наследниках
    /// У каждого рабочего свой процесс выполнени
    /// </summary>
    /// <param name="command">команда</param>
    /// <returns>Результат</returns>
    public virtual string Execute(string command)
    {
        if (nextWorker == null) return string.Empty;
        return nextWorker.Execute(command);
    }

    /// <summary>
    /// Передача обязанностей другому рабочему
    /// </summary>
    /// <param name="worker">Другой рабочий</param>
    /// <returns>Другой рабочий</returns>
    public IWorker SetNetWorker(IWorker worker)
    { 
        nextWorker = worker;
        return worker; 
    }
}

class Designer : AbsWorker
{
    public override string Execute(string command)
    {
        if (command == "Спроектировать веранду")
            return "Проектировщик выполнил команду: " + command;
        else return base.Execute(command);                       //если не может выполнить передаёт следующему в цепочке
    }
}

class Programmer: AbsWorker
{
    public override string Execute(string command)
    {
        if(command == "Сделать машину времени")
            return "Программист выполнил команду: " + command;
        else return base.Execute(command);
    }
}

class FinishWorker : AbsWorker
{
    public override string Execute(string command)
    {
        if (command == "Уволить работников")
            return "Начальник выполнил команду: " + command;
        else return base.Execute(command);
    }
}