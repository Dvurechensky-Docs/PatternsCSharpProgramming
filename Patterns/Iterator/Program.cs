/*  Итератор
    Предоставляет способ последовательного
    доступа к множеству, независимо от его
    внутреннего устройства
 */
class Program
{
    public static void Main(string[] args)
    {
        #region Пример №1 - базовое
        Library library = new Library();
        Reader reader = new Reader();
        reader.SetBooks(library);
        Console.ReadKey();
        #endregion
        #region Пример №2 - пример работы стека
        DataStack stack = new DataStack();
        for (int i = 0; i < 5; i++)
            stack.Push(i);

        DataStack stackCopy = new DataStack(stack);

        Console.WriteLine(stack == stackCopy);      //true

        stackCopy.Push(10);

        Console.WriteLine(stack == stackCopy);      //false
        #endregion
    }
}

/// <summary>
/// Читатель
/// </summary>
class Reader
{
    public void SetBooks(Library library)
    {
        IBookIterator iterator = library.CreateNumerator();
        while(iterator.HasNext())
        {
            Book book = iterator.Next();
            Console.WriteLine(book.Name);
        }
    }
}

/// <summary>
/// Поведение поиска библиотеки
/// </summary>
interface IBookIterator
{
    bool HasNext();
    Book Next();
}

/// <summary>
/// Поведение библиотеки
/// </summary>
interface IBookNumerable
{
    IBookIterator CreateNumerator();
    int Count { get; }
    Book this[int index] { get; }
}

/// <summary>
/// Класс книги
/// </summary>
class Book
{
    public string Name { get; set; }
}

/// <summary>
/// Класс библиотеки книг
/// </summary>
class Library : IBookNumerable
{
    private Book[] Books { get; set; }

    public Library()
    {
        Books = new Book[]
        {
            new Book(){ Name = "James"},
            new Book(){ Name = "Karl"},
            new Book(){ Name = "Rogan"}
        };
    }

    /// <summary>
    /// Вызов книги
    /// </summary>
    /// <param name="index">индекс в библиотеке</param>
    /// <returns>Book</returns>
    public Book this[int index] => Books[index];

    /// <summary>
    /// Количество книг в библиотеке
    /// </summary>
    public int Count => Books.Length;

    /// <summary>
    /// Перейти к следующей библиотеке
    /// </summary>
    /// <returns>IBookIterator(LibraryNumenator)</returns>
    public IBookIterator CreateNumerator() => new LibraryNumenator(this);
}

class LibraryNumenator : IBookIterator
{
    IBookNumerable Aggregate { get; set; }
    int index = 0;

    /// <summary>
    /// Передача коллекции книг в Library
    /// </summary>
    /// <param name="bookNumerable"></param>
    public LibraryNumenator(IBookNumerable bookNumerable)
    {
        Aggregate = bookNumerable;
    }

    public bool HasNext() => index < Aggregate.Count;

    public Book Next() => Aggregate[index++];
}

/// <summary>
/// Класс стека данных
/// </summary>
public class DataStack
{
    private int[] items = new int[10];
    /// <summary>
    /// Длинна массива данных в этом стеке
    /// </summary>
    private int lenght;

    public DataStack() => lenght = -1;

    /// <summary>
    /// Для копирования экземпляра класса
    /// </summary>
    /// <param name="myStack">Экземпляр данного класса</param>
    public DataStack(DataStack myStack)
    {
        this.items = myStack.items;
        this.lenght = myStack.lenght;
    }

    /// <summary>
    /// Свойство геттера для поля items
    /// </summary>
    public int[] Items { get => items; }

    /// <summary>
    /// Свойство геттера для поля lenght
    /// </summary>
    public int Lenght { get => lenght; }

    /// <summary>
    /// Добавление элементов в массив
    /// </summary>
    /// <param name="value">значение</param>
    public void Push(int value) => items[++lenght] = value;

    /// <summary>
    /// Получение последнего элемента
    /// </summary>
    /// <returns>значение</returns>
    public int Pop() => items[lenght--];

    /// <summary>
    /// Переопределение оператора сравнения двух экземпляров данного класса
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns>bool</returns>
    public static bool operator ==(DataStack left, DataStack right)
    {
        StackIterator it1 = new StackIterator(left),
            it2 = new StackIterator(right);

        while (it1.IsEnd() || it2.IsEnd())
        {
            if (it1.Get() != it2.Get()) break;
            it1++;
            it2++;
        }

        return !it1.IsEnd() && !it2.IsEnd();
    }

    /// <summary>
    /// Переопределение оператора сравнения двух экземпляров данного класса
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns>bool</returns>
    public static bool operator !=(DataStack left, DataStack right)
    {
        StackIterator it1 = new StackIterator(left), 
            it2 = new StackIterator(right);

        while (it1.IsEnd() || it2.IsEnd())
        {
            if (it1.Get() != it2.Get()) break;
            it1++;
            it2++;
        }

        return !it1.IsEnd() && !it2.IsEnd();
    }
}

/// <summary>
/// Перечислитель
/// </summary>
class StackIterator
{
    private DataStack stack;
    private int index;

    /// <summary>
    /// Инициализируем поля перечислителя
    /// </summary>
    /// <param name="dataStack">данные</param>
    public StackIterator(DataStack dataStack)
    {
        this.stack = dataStack;
        this.index = 0;
    }
    
    /// <summary>
    /// Переопределение опреатора инкрементирования
    /// </summary>
    /// <param name="s">новый переданный экземпляр класса</param>
    /// <returns>экземпляр класса с инкрементированым значением index</returns>
    public static StackIterator operator ++(StackIterator s)
    {
        s.index++;
        return s;
    }

    /// <summary>
    /// Возвращает значение элемента поля стека 
    /// через его свойство по текущему индексу
    /// </summary>
    /// <returns></returns>
    public int Get()
    {
        if(index < stack.Lenght) return stack.Items[index];
        return 0;
    }

    /// <summary>
    /// Возвращет true при достижении предельного размера стека
    /// </summary>
    /// <returns>bool</returns>
    public bool IsEnd() => index != stack.Lenght + 1;
}