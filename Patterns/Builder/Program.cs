/*  Строитель
    Разделяет создание сложного объекта
    и его инициализацию так, что одинаковый 
    процесс построения может может создавать
    объекты с разным состоянием
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var rx = new Baker();
        var bread = rx.Bake(new RBuilderBread());

        Console.WriteLine(bread.ToString());
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Мука
/// </summary>
class Floor
{
    /// <summary>
    /// Сорт муки
    /// </summary>
    public string Sort { get; set; }
}

/// <summary>
/// Соль
/// </summary>
class Salt
{ 
    /// <summary>
    /// Масса
    /// </summary>
    public double Mass { get; set; }
}

/// <summary>
/// Пищевые добавки
/// </summary>
class Additives
{
    /// <summary>
    /// Список пищевых добавок
    /// </summary>
    public string[] Names { get; set; }
}

/// <summary>
/// Xлеб
/// </summary>
class Bread
{ 
    public Floor Floor { get; set; }
    public Salt Salt { get; set; }
    public Additives Additives { get; set; }

    public override string ToString()
    {
        return $"[F: {Floor.Sort}]---[S: {Salt.Mass}]---[A: {Additives.Names[0]}]";
    }
}

/// <summary>
/// Строитель хлеба
/// </summary>
abstract class BreadBuilder
{
    public Bread Bread { get; set; }
    public void CreateBread()
    {
        Bread = new Bread();
    }

    public abstract void SetFloor();
    public abstract void SetSalt();
    public abstract void SetAdditives();
}

/// <summary>
/// Пекарь
/// </summary>
class Baker
{
    public Bread Bake(BreadBuilder breadBuilder)
    {
        breadBuilder.CreateBread();
        breadBuilder.SetFloor();
        breadBuilder.SetSalt();
        breadBuilder.SetAdditives();
        return breadBuilder.Bread;
    }
}


/// <summary>
/// Для ржаного хлеба строитель
/// </summary>
class RBuilderBread : BreadBuilder
{
    public override void SetAdditives()
    {
        Bread.Additives = new Additives() { Names = new[] { "E222", "E297" } };
    }

    public override void SetFloor()
    {
        Bread.Floor = new Floor() { Sort = "R class" };
    }

    public override void SetSalt()
    {
        Bread.Salt = new Salt() { Mass = 3.44 };
    }
}
