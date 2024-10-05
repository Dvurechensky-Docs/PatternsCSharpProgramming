/* Гибкий(плавный, текучий) строитель (интерфейс)
    Позволяет упростить процесс создания сложных 
    объектов с помощью методов-цепочек, которые 
    наделяют объект каким-то определенным качеством
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        User user = new User().Create().SetName("Alex").SetPassword("admin");
        Console.WriteLine(user);
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Шаблон пользователя
/// </summary>
class User
{
    public string Name { get; set; }
    public string Password { get; set; }

    public UserBuilder Create()
    {
        return new UserBuilder();
    }

    public override string ToString()
    {
        return $"Name {Name}, Password {Password}";
    }
}

/// <summary>
/// Шаблон гибкого строителя конфигурации пользователя
/// </summary>
class UserBuilder
{
    private User CurrentUser { get; set; } 
    public UserBuilder()
    {
        CurrentUser = new User();
    }

    public UserBuilder SetName(string name)
    {
        CurrentUser.Name = name;
        return this;
    }

    public UserBuilder SetPassword(string password)
    {
        CurrentUser.Password = password;
        return this;
    }

    /// <summary>
    /// преобразуем тип Builder в тип User для которого он использовался
    /// </summary>
    /// <param name="builder">строитель</param>
    public static implicit operator User(UserBuilder builder)
    {
        return builder.CurrentUser;
    }
}