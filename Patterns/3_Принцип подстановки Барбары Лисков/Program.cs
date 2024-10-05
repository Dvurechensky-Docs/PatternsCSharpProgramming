/*
 * Глава 19: Принцип подстановки Барбары Лисков (SOLID SRP)
 * 
 *   Автор: Роберт Мартин (Дядя Боб)
 *   
 *   Сам принцип:
 *   -  Пусть Q(x) является свойством, верным относительно объектов x некоторого
 *      типа T. Тогда Q(y) также должно быть верным для объектов y типа S, где S является подтипом T.
 *      
 *      или
 *      
 *   - Функции, которые используют базовый тип, должны иметь возможность использовать подтипы базового типа, не зная об этом.
 *     Поведение классов-наследников не должно противоречить поведению, заданному базовым классом
 *   
 *   Принципы:
 *     1. Single responsibility - принцип единственной ответственности
 *     2. Open-closed - принцип открытости/закрытости
 *     3. Liskov substitution - принцип подстановки Барбары Лисков (самый сложный)
 *     4. Interface Segregation - принцип разделения интерфейса
 *     5. Dependency inversion - принцип инверсии зависисмостей
 */

public class Coordinates
{
    public int Longtitude { get; set; }
    public int Latitude { get; set; }
    public override string ToString()
    {
        return $"Широта: {Longtitude} Долгота: {Latitude}";
    }
}

/// <summary>
/// Шаблон летающей птицы
/// </summary>
public class Bird
{
    protected Random rand;
    public Coordinates Position { get; set; }
    protected int speed, spacing;
    public int Spacing { get => spacing; }

    public Bird()
    {
        Position = new Coordinates();
        rand = new Random();
    }

    protected void Mark(int x, int y) { }

    /// <summary>
    /// Полёт птицы
    /// </summary>
    private void Fly()
    {
        speed = 1;
        switch (rand.Next(2))
        {
            case 0: Position.Latitude += speed; break;
            default: Position.Longtitude += speed; break;
        }
        spacing++;
        Console.SetCursorPosition(Position.Latitude, Position.Longtitude);
        Console.WriteLine("B");
    }

    /// <summary>
    /// Движение птицы 
    /// </summary>
    public virtual void Move()
    {
        Fly();
    }
}

/// <summary>
/// Шаблон бегущей птицы
/// </summary>
public class Kiwi : Bird
{
    private void Run()
    {
        speed = 1;
        switch (rand.Next(2, 6))
        {
            case 3: Position.Latitude += speed; break;
            default: Position.Longtitude += speed; break;
        }
        spacing++;
        Console.SetCursorPosition(Position.Latitude, Position.Longtitude);
        Console.WriteLine("K");
    }

    public override void Move()
    {
        Run();
    }
}

/// <summary>
/// Шаблон отображеня движения
/// </summary>
class CalculatingDistance
{
    private int time;
    public CalculatingDistance(int time) { this.time = time; }
    public void Calculate(Bird bird)
    {
        for (int i = 0; i < time; i++)
        {
            bird.Move();
        }
        Console.Title = ($"\n\n\nРасстояние: {bird.Spacing} {bird.Position}");
    }
}

public class Program
{
    public static void Main(string[] argv)
    {
        var bird = new Bird();
        new CalculatingDistance(10).Calculate(bird);
        var kiwi = new Kiwi();
        new CalculatingDistance(10).Calculate(kiwi);
        Console.ReadLine();
    }
}