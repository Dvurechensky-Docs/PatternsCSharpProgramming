/*  Компоновщик
    Компонует объекты в древовидную структуру по принципу "часть-целое",
    представляя их в виде иерархии. Позволяет
    клиенту одинаково обращаться как к отдельному,
    так и к целому поддереву
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        var paths = new Paths(new Dictionary<int, Directory>());
        paths.components.Add(1, new Directory("C"));
        paths.components[1].Add(new Folder("SYSTEM"));
        paths.components[1].Add(new Folder("DATA"));
        paths.components[1].Add(new File("test.txt"));
        paths.components.Add(0, new Directory("F"));
        paths.components[0].Add(new File("resize.cs"));
        paths.Print();
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Абстракция компонента файловой системы (дерева) - пути до файла
/// </summary>
abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }

    public virtual void Add(Component component) { }
    public abstract void Remove(Component component);
    public abstract void Print();
}

class Paths : Component
{
    public Dictionary<int,Directory> components;

    public Paths(Dictionary<int, Directory> components) : base ("")
    {
        this.components = components;
    }

    public override void Print()
    {
        foreach (var component in components)
        {
            component.Value.Print();
            Console.WriteLine();
        }
    }

    public override void Remove(Component component)
    {
        Console.WriteLine("Delete Path" + this.name);
    }
}

class Directory : Component
{
    public List<Component> components = new();

    public Directory(string name) 
        : base(name)
    {
    }

    public override void Add(Component component)
    {
        components.Add(component);
    }

    public override void Print()
    {
        Console.Write(this.name + ":");
        foreach (var component in components)
        {
            component.Print();
        }
    }

    public override void Remove(Component component)
    {
        component.Remove(component);
    }
}

class Folder : Component
{
    public Folder(string name) 
        : base(name)
    {
    }

    public override void Print()
    {
        Console.Write("\\" + this.name);
    }

    public override void Remove(Component component)
    {
        Console.WriteLine(this.name + " Delete");
    }
}

class File : Component
{
    public File(string name) 
        : base(name)
    {
    }

    public override void Print()
    {
        Console.Write("\\" + this.name);
    }

    public override void Remove(Component component)
    {
        Console.WriteLine(this.name + " Delete");
    }
}
