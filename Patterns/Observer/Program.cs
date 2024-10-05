/*  Наблюдатель
    Определяет зависимость один ко многим
    между объектами так, что когда один меняет
    своё состояние, все зависимые объекты оповещаются
    и обновляются автоматически
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var concreteObservable = new ConcreteObservable();
        concreteObservable.AddObserver(new Observer("Job"));
        concreteObservable.AddObserver(new Observer("Robin"));
        concreteObservable.AddObserver(new Observer("Jaz"));
        concreteObservable.AddObserver(new Observer("John"));
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Поведение наблюдателя
/// </summary>
interface IObservable
{
    /// <summary>
    /// Добавить наблюдаемого
    /// </summary>
    /// <param name="observer">Наблюдаемый</param>
    void AddObserver(IObserver observer);
    /// <summary>
    /// Удалить наблюдаемого
    /// </summary>
    /// <param name="observer">Наблюдаемый</param>
    void RemoveObserver(IObserver observer);
    /// <summary>
    /// Оповестить всех наблюдаемых
    /// </summary>
    void NotifyObservers();
}

/// <summary>
/// Реализация конкретного наблюдателя
/// </summary>
class ConcreteObservable : IObservable
{
    /// <summary>
    /// Список наблюдаемых
    /// </summary>
    private List<IObserver> _observers;

    public ConcreteObservable()
    {
        _observers = new List<IObserver>();
    }

    public void AddObserver(IObserver observer)
    {
        Console.WriteLine("Event Add Observer");
        NotifyObservers();
        _observers.Add(observer);
    }

    public void NotifyObservers()
    {
        if(_observers.Count == 0) Console.WriteLine("Не кого оповещать...");
        foreach (var observer in _observers)
            observer.Update();
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
        NotifyObservers();
    }
}

/// <summary>
/// Поведение наблюдаемого
/// </summary>
interface IObserver
{
    void Update();
}

/// <summary>
/// Наблюдаемый 
/// </summary>
class Observer : IObserver
{
    public string Name { get; set; }

    public Observer(string name)
    {
        Name = name;
    }

    public void Update()
    {
        Console.WriteLine($"Update {Name}");
    }
}