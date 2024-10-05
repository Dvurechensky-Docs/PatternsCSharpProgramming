/*
 * Глава 21: Принцип инверсии зависимостей (SOLID SRP)
 * 
 *   Автор: Роберт Мартин (Дядя Боб)
 *   
 *   Сам принцип:
 *   
 *   - Модули верхних уровней не должны зависеть от модулей нижних уровней 
 *     (Оба типа должны зависеть от абстракций)
 *     
 *   - Абстракции не должны зависеть от деталей
 *    (Детали должны зависеть от абстракций)
 *   
 *   Принципы:
 *     1. Single responsibility - принцип единственной ответственности
 *     2. Open-closed - принцип открытости/закрытости
 *     3. Liskov substitution - принцип подстановки Барбары Лисков (самый сложный)
 *     4. Interface Segregation - принцип разделения интерфейса
 *     5. Dependency inversion - принцип инверсии зависисмостей
 */
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

/// <summary>
/// Поведение поиска в хранилищах информации
/// </summary>
public interface IFindStorage
{
    List<Person> FindAll(Predicate<Person> predicate);
}

/// <summary>
/// Шаблон списка пользователей
/// </summary>
public class ListStorage : IFindStorage
{
    private List<Person> storage;
    public ListStorage()
    {
        storage = new List<Person>();
    }

    public List<Person> GetPersons() => storage;

    public void Add(Person p) => storage.Add(p);

    public List<Person> FindAll(Predicate<Person> predicate)
    {
        return storage.Where(e => predicate(e)).ToList();
    }
}

/// <summary>
/// Шаблон словаря пользователей
/// </summary>
public class DictionaryStorage : IFindStorage
{
    private Dictionary<string, Person> storage;
    public DictionaryStorage()
    {
        storage = new Dictionary<string, Person>();
    }

    public Dictionary<string, Person> GetPersons() => storage;

    public void Add(string key, Person p) => storage.Add(key, p);

    public List<Person> FindAll(Predicate<Person> predicate)
    {
        return storage.Where(e => predicate(e.Value)).Select(e => e.Value).ToList();
    }
}

/// <summary>
/// Щаблон поисковика
/// </summary>
public class SearchByAge
{
    IFindStorage storage;
    public SearchByAge(IFindStorage storage) => this.storage = storage;
    public void Search()
    {
        foreach (var p in storage.FindAll(e => e.Age > 45))
        {
            Console.WriteLine($"{p.FirstName} {p.Age}");
        }
    }
}

public class Program
{
    public static void Main(string[] argv)
    {
        Console.WriteLine("DictionaryStorage: ");
        var storageDict = new DictionaryStorage();
        storageDict.Add("1", new Person() { Age = 90 });
        new SearchByAge(storageDict).Search();
        Console.WriteLine("ListStorage: ");
        var storageList = new ListStorage();
        storageList.Add(new Person() { Age = 43 });
        new SearchByAge(storageList).Search();
    }
}