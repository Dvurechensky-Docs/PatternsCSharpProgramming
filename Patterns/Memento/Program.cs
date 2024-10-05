/*  Хранитель + Одиночка
    Не нарушая инкапсуляцию, определяет
    и сохраняет внутреннее состояние объекта и
    позволяет позже восстановить объект в этом
    состоянии
 */
class Program
{
    public static void Main(string[] args)
    {
        #region Пример №1 - базовое
        using (var hero = new Hero())
        {
            hero.Shoot();
        }
        using (var heroMan = new Hero())
        {
            heroMan.RestoreState(GameHistory.Instance.History.Pop());
            heroMan.Shoot();
        }
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Класс героя
/// </summary>
class Hero : IDisposable
{
    /// <summary>
    /// Количество патронов
    /// </summary>
    private int patrons = 10;           

    /// <summary>
    /// Выстрел
    /// </summary>
    public void Shoot()
    {
        if(patrons > 0)
        {
            patrons--;
            Console.WriteLine($"Осталось {patrons} патронов...");
        }
        else
            Console.WriteLine("Нет патронов");
    }

    /// <summary>
    /// Сохранение состояния
    /// </summary>
    /// <returns></returns>
    public HeroMemento SaveState()
    {
        Console.WriteLine($"Сохранено - {patrons}");
        return new HeroMemento(patrons);
    }

    /// <summary>
    /// Восстановление состояния
    /// </summary>
    /// <param name="memento">Хранитель состояния</param>
    public void RestoreState(HeroMemento memento)
    {
        patrons = memento.Patrons;
        Console.WriteLine($"Загружено - {patrons}");
    }

    /// <summary>
    /// Удаление из памяти + сохранение в истории последнего состояния
    /// </summary>
    public void Dispose()
    {
        GameHistory.Instance.History.Push(SaveState());
    }
}

/// <summary>
/// Memento - Хранитель состояния
/// </summary>
class HeroMemento
{
    public int Patrons { get; private set; }

    public HeroMemento(int patrons)
    {
        Patrons = patrons;
    }
}

/// <summary>
/// Caretaker - смотритель состояния
/// </summary>
class GameHistory 
{
    private static GameHistory instance;
    public Stack<HeroMemento> History { get; set; }

    private GameHistory()
    {
        History = new Stack<HeroMemento>();
    }

    public static GameHistory Instance
    {
        get
        {
            if(instance == null)
                instance = new GameHistory();
            return instance;
        }
    }

    public void Clear()
    {
        History.Clear();
    }
}