/*  Интерпретатор
    Получая формальный язык, определяет
    представление его грамматики и интерпретатор,
    использующий это представление для обработки
    выражений языка (Применяется для часто повторяющихся операций)
 */
class Program
{
    public static void Main(string[] args)
    {
        #region Пример №1 - базовое
        var context = new Context();
        //создаём переменные
        int x = 5;
        int y = 8;
        int z = 2;
        int k = 10;
        //задаём переменные в контекст
        context.SetVariable("x", x);
        context.SetVariable("y", y);
        context.SetVariable("z", z);
        context.SetVariable("k", k);
        //(x + y - z) * k
        var expressionAdd = new AddExpression(new NumberExpression("x"), 
                                              new NumberExpression("y"));
        var expressionSub = new SubstructExpression(expressionAdd, 
                                                    new NumberExpression("z"));
        var expressionPow = new PowExpression(expressionSub, new NumberExpression("k"));
        Console.WriteLine(expressionPow.Interpret(context));
        Console.WriteLine("Please press Enter...");
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Агрегатор выражений
/// </summary>
class Context
{
    Dictionary<string, int> variables;

    public Context()
    {
        variables = new Dictionary<string, int>();
    }

    public int GetVariable(string name)
    {
        if(variables.ContainsKey(name))
            return variables[name];
        else
            return -1;
    }

    public void SetVariable(string name, int value)
    {
        if(variables.ContainsKey(name))
            variables[name] = value;
        else
            variables.Add(name, value);
    }
}

/// <summary>
/// Поведение интерпретатора
/// </summary>
interface IExpression
{
    int Interpret(Context context);
}

/// <summary>
/// Терминальное выражение
/// </summary>
class NumberExpression : IExpression
{
    string Name { get; set; }
    public NumberExpression(string name)
    {
        Name = name;
    }

    public int Interpret(Context context)
    {
        return context.GetVariable(Name);
    }
}

/// <summary>
/// Нетерминальное выражение для сложения
/// </summary>
class AddExpression : IExpression
{
    IExpression LeftExpression { get; set; }
    IExpression RightExpression { get; set; }

    public AddExpression(IExpression left, IExpression right)
    {
        LeftExpression = left;
        RightExpression = right;
    }

    public int Interpret(Context context)
    {
        return LeftExpression.Interpret(context) + RightExpression.Interpret(context);
    }
}

/// <summary>
/// Нетерминальное выражение для умножения
/// </summary>
class PowExpression : IExpression
{
    IExpression LeftExpression { get; set; }
    IExpression RightExpression { get; set; }

    public PowExpression(IExpression left, IExpression right)
    {
        LeftExpression = left;
        RightExpression = right;
    }

    public int Interpret(Context context)
    {
        return LeftExpression.Interpret(context) * RightExpression.Interpret(context);
    }
}

/// <summary>
/// Нетерминальное выражение для вычитания
/// </summary>
class SubstructExpression : IExpression 
{
    IExpression LeftExpression { get; set; }
    IExpression RightExpression { get; set; }

    public SubstructExpression(IExpression left, IExpression right)
    {
        LeftExpression = left;
        RightExpression = right;
    }

    public int Interpret(Context context)
    {
        return LeftExpression.Interpret(context) - RightExpression.Interpret(context);
    }
}