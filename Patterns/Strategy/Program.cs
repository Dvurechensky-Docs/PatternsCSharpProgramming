/*  Стратегия  
    Определяет группу алгоритмов,
    инкапсулирует их и делает взаимозаменяемыми.
    Позволяет изменять алгоритм независимо от клиентов,
    его использующих.
 */
/*
    * На чем строилось:
    * СЕРГЕЙ ТЕПЛЯКОВ - Паттерны проектирования на платформе .Net
    * ШЕВЧУК, АХРИМЕНКО, КАСЬЯНОВ - Приемы объектно-ориентированного проектирования
    * 
    * ПАТТЕРНЫ ПОВЕДЕНИЯ
    * Паттерн №1: Стратегия
    * 
    * - является более контекстно зависимой операцией
    * 
    * Причины применения:
    * 1.необходимость инкапсуляции поведения или алгоритма
    * 2.необходимость замены поведения или алгоритма во время исполнения
    * 
    * Другими словами, стратегия обеспечивает точку расширения системы 
    * в определенной плоскости: класс-контекст (LogProcessor) принимает экземпляр стратегии (LogFileReader) 
    * и не знает, какой вариант стратегии он собирается использовать.
    * 
    * Особенность:
    * Передача интерфейса ILogReader классу LogProcessor увеличивает гибкость,
    * но в то же время повышает сложность. 
    * Теперь клиентам класса LogProcessor нужно решить, какую реализацию использовать, 
    * или переложить эту ответственность на вызывающий код.
    */

/*
 * ВМЕСТО
 * классической стратегии на основе наследования
 * можно использовать стратегию на основе делегатов
 * 
 * ПРИМЕР: Стратегия сортировки
 */

/*
 * ВАЖНО: Гибкость не бывает бесплатной, поэтому выделять стратегии стоит тогда, 
 * когда действительно нужна замена поведения во время исполнения.
 */
using Strategy;

class Program
{
    #region Пример №3 - Сomparer
    public static void SortListId(List<Employee> list)
    {
        list.Sort(new EmployeeByIdComparer());          //используем функтор
    }

    public static void SortListName(List<Employee> list)
    {
        list.Sort((x, y) => x.Name.CompareTo(y.Name));  //используем делегат
    }
    #endregion

    public static void Main(string[] args)
    {
        #region Пример №1 - базовое
        var car = new Car(new PetrolMove());
        car.Move();
        car.Movable = new ElectronicMove();
        car.Move();
        Console.ReadKey();
        #endregion
        #region Пример №2 - ILogReader
        LogFileReader logFileReader = new LogFileReader();
        //создали делегат который принимает в себя метод,
        //в результате выполнения которого возвращается List<LogEntry>
        Func<List<LogEntry>> _import = () => logFileReader.Read();
        LogProcessor processor = new LogProcessor(_import);
        processor.ProcessLogs();
        #endregion
        #region Пример №3 - Сomparer
        List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 8,
                Name = "asmus"
            },
            new Employee
            {
                Id = 1,
                Name = "robin"
            },
            new Employee
            {
                Id = 2,
                Name = "satan"
            },
            new Employee
            {
                Id = 5,
                Name = "dastin"
            }
        };
        SortListId(employees);      //отсортировали по id через функтор
        SortListName(employees);    //отсортировали по Name через делегат
        Console.WriteLine();
        var comparer = new EmployeeByIdComparer();
        var set = new SortedSet<Employee>(comparer);    //конструктор принимает IComparable
        //нет конструктора, принимающего делегат Comparison<T>
        //можно создать небольшой адаптерный фабричный класс
        var comparer_factory = ComparerFactory.Create<Employee>((x, y) => x.Id.CompareTo(y.Id));
        //он помещает сюда фабрику
        var set_factory = new SortedSet<Employee>(comparer_factory);
        #endregion
    }
}

/// <summary>
/// Поведение движения
/// </summary>
interface IMovable
{
    void Move();
}

/// <summary>
/// Бензиновый двигатель
/// </summary>
class PetrolMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Движение на бензине");
    }
}

/// <summary>
/// Электродвигатель
/// </summary>
class ElectronicMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Движение на электричестве");
    }
}

/// <summary>
/// Автомобиль
/// </summary>
class Car
{
    /// <summary>
    /// Cпособ передвижения автомобиля
    /// </summary>
    public IMovable Movable { private get; set; }

    public Car(IMovable movable)
    {
        Movable = movable;
    }

    public void Move()
    {
        Movable.Move();
    }
}


class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public override string ToString()
    {
        return string.Format($"ID={Id}, Name={Name}");
    }
}

/// <summary>
/// Реализует интерфейс сортировки
/// Добавлет возможность сортировки по ID по возрастающей
/// </summary>
class EmployeeByIdComparer : IComparer<Employee>
{
    int IComparer<Employee>.Compare(Employee? x, Employee? y)
    {
        if (x is Employee xx && y is Employee yy)
            return xx.Id.CompareTo(yy.Id);
        else
            return 0;
    }
}

/// <summary>
/// Фабричный шаблон для создания экземпляров IComparer
/// </summary>
class ComparerFactory
{
    public static IComparer<T> Create<T>(Comparison<T> comparer)
    {
        return new DelegateComparer<T>(comparer);
    }

    private class DelegateComparer<T> : IComparer<T>
    {
        private readonly Comparison<T> _comparer;

        public DelegateComparer(Comparison<T> comparer)
        {
            _comparer = comparer;
        }

        public int Compare(T? x, T? y)
        {
            if (x == null || y == null)
                return 0;
            return _comparer(x, y);
        }
    }
}