/*
 * Глава 17: Принцип единственной обязанности (SOLID SRP)
 * 
 * - инкапсуляция сущности с целью организации архитектуры
 *   приложения, которую будет легко поддерживать и расширять в 
 *   течении всего промежутка эксплуатации
 *   
 *   Автор: Роберт Мартин (Дядя Боб)
 *   
 *   Принципы:
 *      1. Single responsibility - принцип единственной ответственности
 *      2. Open-closed - принцип открытости/закрытости
 *      3. Liskov substitution - принцип подстановки Барбары Лисков (самый сложный)
 *      4. Interface Segregation - принцип разделения интерфейса
 *      5. Dependency inversion - принцип инверсии зависисмостей
 */


/*
 * Принцип единственной ответственности (англ. single-responsibility principle, SPR) - 
 * принцип ООП, обозначающий, что каждый объект должен иметь одну ответственность  и эта 
 * ответственность должна быть полностью инкапсулирована в класс.
 * Все его поведения должны быть направлены исключительно на обеспечение этой отвественности.
 */
/// <summary>
/// К примеру: Разработать класс который будет работать с изображениями
/// </summary>
abstract class Attach
{

}

class Image : Attach
{
    private int width;
    private int height;
    public int Width => width;
    public int Height => height;
    private Image(int width, int height) { }
    //Добавление других методов предполагающих иной функционал не рационально
    //Следуем принципу - декомпозировать - делать максимально минимальные классы под свою ответственность
    public static Image CreateImage(int width, int height) { return new Image(width, height); }
}

/// <summary>
/// EMail сервис
/// Если отваливается модуль отправки Email 
/// мы чиним только его, нам не требуется разбирать класс Image
/// </summary>
class EmailService
{
    private string email;
    private string text;
    private string subject;
    private Attach[] attach;
    public EmailService(string email,
                        string text = "",
                        string subject = "",
                        params Attach[] args)
    { }
    public void SendTo(string email, string text, string subject) { }
}


class Program
{
    public static void Main(string[] argv)
    {

    }
}