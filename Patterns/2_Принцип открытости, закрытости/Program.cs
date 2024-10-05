/*
 * Глава 18: Принцип открытости/закрытости (SOLID SRP)
 * 
 *   Автор: Роберт Мартин (Дядя Боб)
 *   
 *   Постулаты:
 *   - если какая-то сущность описана, то она уже 
 *     полностью закрыта для каких либо изменений;
 *   - сущность открыта для модификаций;
 *   
 *   Принципы:
 *     1. Single responsibility - принцип единственной ответственности
 *     2. Open-closed - принцип открытости/закрытости
 *     3. Liskov substitution - принцип подстановки Барбары Лисков (самый сложный)
 *     4. Interface Segregation - принцип разделения интерфейса
 *     5. Dependency inversion - принцип инверсии зависисмостей
 */
public abstract class Attach
{

}

public class Image : Attach
{
    private int width;
    private int height;
    public int Width => width;
    public int Height => height;
    private Image(int width, int height) { }
    private Image(int width, int height, ISave save) { }
    public static Image CreateImage(int width, int height) { return new Image(width, height); }
    public static Image CreateImage(int width, int height, ISave save) { return new Image(width, height, save); }
    public void SaveToFile(string path) { }
}

public interface ISave
{
    ISave SaveTo(string path);
}

public class SaveToBmp : ISave
{
    public ISave SaveTo(string path)
    {
        return this;
    }
}

public class Program
{
    public static void Main(string[] argv)
    {
        Image.CreateImage(100, 100, new SaveToBmp().SaveTo(""));
    }
}