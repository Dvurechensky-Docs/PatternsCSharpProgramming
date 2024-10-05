/*  Прототип
    Определяет несколько видов объектов,
    чтобы при создании использовать объект-прототип
    и создаёт новые объекты, копируя прототип
    (техника клонирования объектов)
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        IFigure cube = new Cube(10, 10);
        IFigure cloneCube = cube.Clone();
        IFigure cloneMemberCube = cube.CloneMember();
        cube.GetInfo();
        cloneCube.GetInfo();
        cloneMemberCube.GetInfo();
        #endregion

        #region Пример №2
        IEntity entity = new Predator(10, 1000);
        var clone = entity.CloneEntity();
        entity.GetInfo();
        clone.GetInfo();
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Поведение фигуры
/// </summary>
interface IFigure
{
    IFigure Clone();
    IFigure? CloneMember();
    void GetInfo();
}

/// <summary>
/// Шаблон куба
/// </summary>
class Cube : IFigure
{
    int Width { get; set; }
    int Height { get; set; }

    public Cube(int width, int heght)
    {
        Width = width;
        Height = heght;
    }

    public IFigure Clone()
    {
        return new Cube(Width, Height);
    }

    public IFigure? CloneMember()
    {
        return this.MemberwiseClone() as IFigure;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Cube {Width}/{Height}");
    }
}

/// <summary>
/// Треугольник
/// </summary>
class Rect : IFigure
{
    int Width { get; set; }
    int Height { get; set; }

    public Rect(int width, int heght)
    {
        Width = width;
        Height = heght;
    }

    public IFigure Clone()
    {
        return new Rect(Width, Height);
    }

    public IFigure? CloneMember()
    {
        return this.MemberwiseClone() as IFigure;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Rect {Width}/{Height}");
    }
}

/// <summary>
/// Поведение сущности
/// </summary>
interface IEntity
{
    IEntity CloneEntity();
    void GetInfo();
}

abstract record Animal(int Paws, int Weight) : IEntity
{
    public abstract IEntity CloneEntity();
    public abstract void GetInfo();
}

record Predator(int Paws, int Weight) : Animal(Paws, Weight)
{
    public override IEntity CloneEntity()
        => this with { };

    public override void GetInfo()
        => Console.WriteLine($"Predator w={Weight} p={Paws}");
}

record Person(int IQ) : IEntity
{
    public IEntity CloneEntity()
        => this with { };

    public void GetInfo()
        => Console.WriteLine($"Peaple with IQ={IQ}");
}

