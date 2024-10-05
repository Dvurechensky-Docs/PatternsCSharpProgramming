using Newtonsoft.Json;
using static Base.Records;

namespace Base;

/// <summary>
/// Важно: ссылочные типы лежат в куче, значимые - ссылка в куче, значение в стеке
/// ***
/// Шаблон, по которому определяется форма объекта
/// Определение:
/// Класс - это ссылочный тип данных, шаблон по которому определяется объект, информацию о себе хранит в куче.
/// </summary>
class Program
{
    static void Main()
    {
        var person = new Person()                    //реализация record сборки разборки
        {
            Id = 1,
            Name = "john"
        };
        Console.WriteLine(person.ToString());
        var job = new Job()
        {
            Ida = 786897980,
            Names = "Address"
        };
        Console.WriteLine(job.ToString());
        var gl = new GlobalInfo();
        person.Deconstruct(out gl.Name, out gl.Id);
        job.Deconstruct(out gl.Names, out gl.Ida);
        Console.WriteLine($"{gl.Name}/{gl.Names}/{gl.Id}/{gl.Ida}");

        IInterTest interTest = new ClassMain();
        interTest.ResizeExt();                      //методы static
        interTest.Relocate();                       //метод объявлен и реализован в самом интерфейсе
        var Records = new Records(1, "rec1");       //экзмепляр Records (аналог class)
        var (NameS, idS) = Records;                 //можно разложить record на переменные
        var RecNew = Records with { Name = "rec2" };//можно инициализировать другой класс на основе данных первого
        Console.WriteLine($"{NameS} {idS}");
        var (NameS2, idS2) = RecNew;                //можно разложить record на переменные
        Console.WriteLine($"{NameS2} {idS2}");
        Console.WriteLine(Records == RecNew);       //можно сравнить record обычными операторами сравнения
        Console.WriteLine();
        Console.WriteLine(RecNew);                  //можно напечать JSON представление содержимого record по умолчанию
        Console.WriteLine(Records);                 //можно напечать JSON представление содержимого record по умолчанию
        var json = JsonConvert.SerializeObject(Records, Formatting.Indented);
        Console.WriteLine(json);
        var otherSideRecord = JsonConvert.DeserializeObject<Records>(json);
        Console.WriteLine(otherSideRecord);
        Records = Records with { Id = 10 };
        Console.WriteLine(Records);
        Console.ReadKey();
    }
}


/// <summary>
/// Абстракция которая отвечает за контракт взаимодействия для различных типов
/// Определение:
/// Интерфейс - это ссылочный тип данных, представляющий контракт взаимодействия (поведение). 
/// Этот контракт гласит о том что должен содержать class или struct.
/// Формирует общий признак для разнородных объектов
/// </summary>
public interface IInterTest
{
    /// <summary>
    /// Декларация - метод без реализации по умолчанию
    /// </summary>
    /// <param name="build"></param>
    void Build(int build = 0);     
    /// <summary>
    /// После C# 8.0 можно указывать реализацию метода в интерфейсе
    /// </summary>
    void Relocate()                 
    {
        Console.WriteLine("-> IInterTest: Relocate");
    }
    /// <summary>
    /// Cигнатура - операция без реализации - абстрактный метод
    /// </summary>
    abstract void Reload();
    /// <summary>
    /// Делегат - ссылочный тип
    /// </summary>
    delegate void Destiny();       
    /// <summary>
    /// Cвойство - ссылочный тип
    /// </summary>
    string Name { get; set; }       
    /// <summary>
    /// Cвойство - ссылочный тип
    /// </summary>
    object ID { get; set; }      

}

/// <summary>
/// Абстрактный класс
/// Определение:
/// Абстрактный класс - это ссылочный тип данных, для описания общности сущностей, которые не имеют конкретного воплощения
/// </summary>
public abstract class AbstrTest
{
    /// <summary>
    /// Поле
    /// </summary>
    public int key = 100;
    /// <summary>
    /// Свойство
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Конструктор без параметров
    /// </summary>
    public AbstrTest()
    {
        key = 110;
        Name = "Fire";
        Console.WriteLine($"->AbstrTest {Name} {key}");
    }

    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="key">ключ</param>
    public AbstrTest(int key)
    {
        this.key = key;
        Name = "Fire";
        Console.WriteLine($"->AbstrTest {Name} {key}");
    }

    /// <summary>
    /// Метод - это фиксированная операция с реализацией по умолчанию
    /// </summary>
    public void Move()
    {
        Console.WriteLine("Move Abstr");
    }

    /// <summary>
    /// Виртуальный метод - операция с реализацией по умолчанию
    /// </summary>
    public virtual void Resize()
    {
        Console.WriteLine("Resize Abstr");
    }

    /// <summary>
    /// Абстрактный метод - сигнатура - операция без реализации
    /// </summary>
    public abstract void Open();
}

/// <summary>
/// Определение:
/// Структура - это значимый тип данных, ссылка на структуру хранится в куче, значение в стеке
/// Тот же класс, меняется тип данных 
/// </summary>
public struct TestStruct : IInterTest
{
    /// <summary>
    /// Свойство имени
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Свойство идентификатора
    /// </summary>
    public object ID { get; set; }

    /// <summary>
    /// Конструктор без параметров
    /// </summary>
    public TestStruct()
    {
        Name = "Base";
        ID = (object)0;
    }

    /// <summary>
    /// Метод с реализацией с параметрами
    /// </summary>
    /// <param name="build">#</param>
    public void Build(int build = 0)
    {
        Console.WriteLine($"Build TestStruct {build}");
    }

    /// <summary>
    /// Метод с реализацией без параметров
    /// </summary>
    public void Reload()
    {
        Console.WriteLine("Reload TestStruct");
    }
}

/// <summary>
/// Реализация поведения класса
/// </summary>
public class ClassMain : AbstrTest, IInterTest
{
    /// <summary>
    /// Свойство
    /// </summary>
    public int countBuild { get; set; }
    /// <summary>
    /// Свойство от интерфейса
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Свойство от интерфейса
    /// </summary>
    public object ID { get; set; }

    /// <summary>
    /// Конструтор + реализация поведения конструктора абстрактного класса
    /// </summary>
    public ClassMain() : base (0)
    {
        TestStruct testStruct = new TestStruct();
        Console.WriteLine($"TestStruct: {testStruct.Name}, {testStruct.ID}");
        Name = "Base";
        ID = (object)0;
        Move();
        Build();
        Reload();
        Resize();
        Open();
    }

    /// <summary>
    /// Конструтор c параметрами + реализация поведения конструктора абстрактного класса
    /// </summary>
    /// <param name="build">#</param>
    /// <param name="name">#</param>
    /// <param name="id">#</param>
    public ClassMain(int build, string name, object id) : base(build)
    {
        countBuild = build;
        Name = name;
        ID = id;
        Move();
        Build(build);
        Reload();
        Resize();
        Open();
    }

    /// <summary>
    /// Виртуальный метод
    /// </summary>
    public virtual void GG()
    {
        Console.WriteLine("GG Virtual Method Class");
    }

    /// <summary>
    /// Метод с параметрами
    /// </summary>
    /// <param name="build">#</param>
    public void Build(int build = 0)
    {
        Console.WriteLine($"Build Interface Class {build}");
    }

    /// <summary>
    /// Метод без параметров обязательный к реализации от интерфейса
    /// </summary>
    public void Reload()
    {
        Console.WriteLine("Reload Interface Abstract Method Class");
    }

    /// <summary>
    /// Реализация virtual метода абстрактного класса 
    /// </summary>
    public override void Resize()
    {
        base.Resize();
        countBuild--;
        Console.WriteLine("Resize Class");
    }

    /// <summary>
    /// Переопределение сигнатуры абстрактного класса
    /// </summary>
    public override void Open()
    {
        Console.WriteLine("Open Abstract Method Class");
    }

    /// <summary>
    /// Реализация деструктора класса
    /// </summary>
    ~ClassMain()
    {
        Console.WriteLine("###Destroy ClassMain");
    }
}

/// <summary>
/// Реализация наследования (3 принцип ООП)
/// Определение:
/// Наследование - это возможность создания новых абстракций на основе существующих.
/// Наследование является ключевой функцией объектно-ориентированных языков программирования. 
/// Оно позволяет определить базовый класс для определенных функций (доступа к данным или действий), 
/// а затем создавать производные классы, которые наследуют или переопределяют функции базового класса.
/// </summary>
public class Nasled : ClassMain
{
    /// <summary>
    /// Необязательное перепределение виртуального метода главного класса 
    /// </summary>
    public override void GG()
    {
        base.GG();
    }
}


/// <summary>
/// Определение:
/// Records - это ссылочный тип, некая модификация возможностей классов
/// Ключевая особенность - может представлять неизменяемый тип данных (immutable)
/// Также имеет особенность в виде встроенного JSON представления при выводе в строку
/// Имеет возможность управлять своим деконструктором
/// </summary>
public record class Records
{
    /// <summary>
    /// Свойство идентификатора
    /// </summary>
    public int Id { get; init; }        
    
    /// <summary>
    /// Свойство имени
    /// </summary>
    public string Name { get; init; }   
    
    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="id">идентификатор</param>
    /// <param name="name">имя</param>
    public Records(int id, string name) 
    {
        Id = id;
        Name = name;
        Console.WriteLine("Construct");
    }

    public class GlobalInfo
    {
        public int Id;
        public string Name;
        public int Ida;
        public string Names;
    }

    /// <summary>
    /// Деконструктор
    /// </summary>
    /// <param name="name">имя</param>
    /// <param name="id">идентификатор</param>
    public void Deconstruct(out string name, out int id)
    {
        name = Name;
        id = Id;
        Console.WriteLine("Destruct");
    }
}

public record class Person
{
    public int Id { get; init; }
    public string Name { get; init; }

    /// <summary>
    /// Деконструктор
    /// </summary>
    /// <param name="name">имя</param>
    /// <param name="id">идентификатор</param>
    public void Deconstruct(out string name, out int id)
    {
        name = Name;
        id = Id;
        Console.WriteLine("Destruct Person");
    }
}

public record class Job
{
    public int Ida { get; init; }
    public string Names { get; init; }

    /// <summary>
    /// Деконструктор
    /// </summary>
    /// <param name="name">имя</param>
    /// <param name="id">идентификатор</param>
    public void Deconstruct(out string name, out int id)
    {
        name = Names;
        id = Ida;
        Console.WriteLine("Destruct Job");
    }
}