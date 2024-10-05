/*  Шаблонный метод  
    Определяет алгоритм, некоторые этапы которого
    делегируются подклассам. Позволяет подклассам
    переопределить эти этапы, не меняя структуру алгоритма.
 */
class Program
{
    public static void Main(string[] args)
    {
        #region Пример №1 - базовое
        new School().Learn();
        new University().Learn();
        Console.ReadKey();
        #endregion
    }
}

/// <summary>
/// Представление образовательного процесса
/// </summary>
abstract class Education
{
    /// <summary>
    /// Обучение
    /// </summary>
    public virtual void Learn()
    {
        Enter();
        Study();
        PassExams();
        GetDocument();
    }

    /// <summary>
    /// Получение документа об окончании образования
    /// </summary>
    protected abstract void GetDocument();
    /// <summary>
    /// Cдача экзаменов в учебном заведении
    /// </summary>
    protected abstract void PassExams();
    /// <summary>
    /// Обучение в учебном заведении
    /// </summary>
    protected abstract void Study();
    /// <summary>
    /// Поступление в учебное заведение
    /// </summary>
    protected abstract void Enter();
}

/// <summary>
/// Школа реализовывающее процесс образования со своими дополнениями
/// </summary>
class School : Education
{
    protected override void Enter()
    {
        Console.WriteLine("Поступил в школу");
    }

    protected override void GetDocument()
    {
        Console.WriteLine("Получил аттестат");
    }

    protected override void PassExams()
    {
        Console.WriteLine("Сдал ЕГЭ и ОГЭ");
    }

    public void ExtraExams()
    {
        Console.WriteLine("Ходил на олимпиады");
    }

    protected override void Study()
    {
        Console.WriteLine("Обучился 11 классов");
    }

    public override void Learn()
    {
        base.Learn();
        ExtraExams();
    }
}

/// <summary>
/// Университет реализовывающий процесса образования
/// </summary>
class University : Education
{
    protected override void Enter()
    {
        Console.WriteLine("Поступил в университет");
    }

    protected override void GetDocument()
    {
        Console.WriteLine("Получил диплом");
    }

    protected override void PassExams()
    {
        Console.WriteLine("Сдал экзамены и зачёты");
    }

    protected override void Study()
    {
        Console.WriteLine("Ходил на пары");
        Console.WriteLine("Ходил на лекции");
        Console.WriteLine("Сдавал лабораторные работы");
    }
}