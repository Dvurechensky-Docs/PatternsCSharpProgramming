/*  Команда
    Инкапсулирует запрос в виде объекта
    позволяя передавать их клиентам в
    качестве параметров, ставить в очередь,
    логировать, а также поддерживать отмену
    операций
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var initCommand = new Invoker(new ConcreteCommand(new Receiver()));
        initCommand.Run();
        initCommand.Cancel();
        Console.WriteLine("Please press Enter...");
        Console.ReadKey();
        #endregion
        #region Пример №2 - пульт управления конвеерной установкой
        var conveyor = new Conveyor();   // создаём конвеер
        var multipult = new Multipult(); // создаём пульт управления конвеером
        multipult.SetCommand(0, new ConveyorWorkCommand(conveyor));
        multipult.SetCommand(1, new ConveyorAjustCommand(conveyor));

        multipult.PressOn(0);
        multipult.PressOn(1);
        multipult.PressCansel();
        multipult.PressCansel();
        #endregion
    }
}

/// <summary>
/// Описания общего поведения объекта
/// </summary>
abstract class Command
{
    public abstract void Execute();
    public abstract void Undo();
}

/// <summary>
/// Описание процесса создания команды
/// </summary>
class ConcreteCommand : Command
{
    Receiver receiver;

    public ConcreteCommand(Receiver receiver)
    {
        this.receiver = receiver;
    }

    /// <summary>
    /// Инициализация команды
    /// *вызывает его получателя
    /// </summary>
    public override void Execute()
    {
        receiver.Operation();
    }

    /// <summary>
    /// Остановка команды
    /// </summary>
    public override void Undo()
    {
        Console.WriteLine("Stop");
    }
}

/// <summary>
/// Описание возможностей получателя команды
/// </summary>
class Receiver
{
    /// <summary>
    /// Обработка получателем команды
    /// </summary>
    public void Operation()
    {
        Console.WriteLine("Processing...");
    }
}

/// <summary>
/// Описание инициатора команды
/// </summary>
class Invoker
{
    Command command;

    /// <summary>
    /// Принимает в себя команду
    /// </summary>
    /// <param name="command">#</param>
    public Invoker(Command command)
    {
        this.command = command;
    }
    
    /// <summary>
    /// Запускает команду
    /// </summary>
    public void Run()
    {
        command.Execute();
    }

    /// <summary>
    /// Отменяет выполнение команды
    /// </summary>
    public void Cancel()
    {
        command.Undo();
    }
}

/// <summary>
/// Поведение команды
/// </summary>
interface ICommand
{
    void Positive();
    void Negative();
}

/// <summary>
/// Класс конвеера
/// </summary>
class Conveyor
{
    public void On() => Console.WriteLine("Включение конвеера");

    public void Off() => Console.WriteLine("Выключение конвеера");

    public void SpeedIncrease() => Console.WriteLine("Скорость конвеера увеличена");

    public void SpeedDecrease() => Console.WriteLine("Скорость конвеера снижена");
}

/// <summary>
/// Класс управления работой конвеера
/// </summary>
class ConveyorWorkCommand : ICommand
{
    public Conveyor conveer;

    /// <summary>
    /// Передача типа конвеера в конструторе
    /// </summary>
    /// <param name="conveer">тип</param>
    public ConveyorWorkCommand(Conveyor conveer) => this.conveer = conveer;

    public void Negative() => conveer.Off();

    public void Positive() => conveer.On();
}

/// <summary>
/// Класс регулировки конвеера
/// </summary>
class ConveyorAjustCommand : ICommand
{
    public Conveyor conveer;

    /// <summary>
    /// Передача типа конвеера в конструторе
    /// </summary>
    /// <param name="conveer">тип</param>
    public ConveyorAjustCommand(Conveyor conveer) => this.conveer = conveer;

    public void Negative() => conveer.SpeedDecrease();

    public void Positive() => conveer.SpeedIncrease();
}


/// <summary>
/// Пульт управления конвеером
/// </summary>
class Multipult
{
    /// <summary>
    /// Все возможные команды
    /// </summary>
    private List<ICommand> commands;
    
    /// <summary>
    /// История выполненных команд для возможной их отмены
    /// </summary>
    private Stack<ICommand> history;

    public Multipult()
    {
        commands = new List<ICommand>() { null, null };
        history = new Stack<ICommand>();
    }

    /// <summary>
    /// Устанавлием список команд по индексу кнопки
    /// </summary>
    public void SetCommand(int btn, ICommand command) => commands[btn] = command;

    /// <summary>
    /// Вызывает команду из списка по указанному индексу
    /// и запишет в историю команд выполненную команду
    /// </summary>
    /// <param name="btn">идекс кнопки</param>
    public void PressOn(int btn)
    {
        commands[btn].Positive();
        history.Push(commands[btn]);
    }

    /// <summary>
    /// Извлекает команду из истории и отменяет её
    /// </summary>
    public void PressCansel() 
    {
        if(history.Count == 0) return;
        var oldC = history.Pop();
        oldC.Negative();
    }
}