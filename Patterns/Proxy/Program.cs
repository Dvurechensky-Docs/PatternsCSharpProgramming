using Microsoft.EntityFrameworkCore;
/*  Заместитель
    Предоставляет объект-заместитель другого объекта
    для контроля доступа к нему
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        using (IBook book = new BookStoreProxy())
        {
            //читаем первую страницу
            Page page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
            //читаем первую страницу
            Page page2 = book.GetPage(2);
            Console.WriteLine(page1.Text);
            //возвращаемся на первую страницу
            page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
        }
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// отдельная страница книги
/// </summary>
/// <param name="Id">Идентификатор</param>
/// <param name="Number">Номер</param>
/// <param name="Text">Содержимое</param>
record Page(int Id, int Number, string Text);

class PageContext : DbContext
{
    public DbSet<Page> Pages { get; set; }
}

interface IBook : IDisposable
{
    Page GetPage(int number);
}

class BookStore : IBook
{
    PageContext db;

    public BookStore()
    {
        db = new PageContext();
    }

    public void Dispose()
    {
        db.Dispose();
    }

    public Page GetPage(int number)
    {
        return db.Pages.FirstOrDefault(p => p.Number == number);
    }
}

class BookStoreProxy : IBook
{
    List<Page> Pages;
    BookStore bookStore;

    public BookStoreProxy()
    {
        Pages = new List<Page>();
    }

    public void Dispose()
    {
        if (bookStore != null)
            bookStore.Dispose();
    }

    public Page GetPage(int number)
    {
        Page page = Pages.FirstOrDefault(p => p.Number == number);
        if(page == null)
        {
            if(bookStore == null)
                bookStore = new BookStore();
            page = bookStore.GetPage(number);
            Pages.Add(page);
        }
        return page;
    }
}
