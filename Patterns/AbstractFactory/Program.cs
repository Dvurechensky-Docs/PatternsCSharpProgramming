/*  Абстрактная фабрика
    Предоставляет интерфейс для создания 
    групп связанных или зависимых объектов,
    не указывая их конкретный класс
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var soldier = new Hero(new SoldierFactory());
        soldier.Run();
        soldier.Hit();

        var elf = new Hero(new ElfFactory());
        elf.Run();
        elf.Hit();

        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Оружие базовая логика
/// </summary>
abstract class Weapon
{
    public abstract void Hit();
}

/// <summary>
/// Движение базовая логика
/// </summary>
abstract class Movement
{
    public abstract void Move();
}

/// <summary>
/// Огнестрел
/// </summary>
class Gun : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Hit Gun");
    }
}

/// <summary>
/// Арбалет
/// </summary>
class Arbalet : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Hit Arbalet");
    }
}

/// <summary>
/// Герой летает
/// </summary>
class Fly : Movement
{
    public override void Move()
    {
        Console.WriteLine("Hero Fly");
    }
}

/// <summary>
/// Герой бежит
/// </summary>
class Run : Movement
{
    public override void Move()
    {
        Console.WriteLine("Hero Run");
    }
}

/// <summary>
/// Супергерой
/// </summary>
class Hero
{
    private Weapon Weapon { get; set; }
    private Movement Movement { get; set; }

    public Hero(HeroFactory factory)
    {
        Weapon = factory.CreateWeapon();
        Movement = factory.CreateMovement();
    }

    public void Run()
    {
        Movement.Move();
    }

    public void Hit()
    {
        Weapon.Hit();
    }
}

/// <summary>
/// Абстракция фабрика героев
/// </summary>
abstract class HeroFactory
{ 
    public abstract Weapon CreateWeapon();
    public abstract Movement CreateMovement();
}

/// <summary>
/// Эльфы
/// </summary>
class ElfFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new Fly();
    }

    public override Weapon CreateWeapon()
    {
        return new Arbalet();
    }
}

/// <summary>
/// Солдаты
/// </summary>
class SoldierFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new Run();
    }

    public override Weapon CreateWeapon()
    {
        return new Gun();
    }
}
