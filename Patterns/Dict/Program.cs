using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Diagnostics;

class Program
{
    /// <summary>
    /// Стандартный Dictionary
    /// Быстрый поиск с помощью ключей, можно добавлять и удалять элементы
    /// </summary>
    private static readonly Dictionary<string, object> Dictionary = new();

    /// <summary>
    /// ListDictionary
    /// Он меньше и быстрее, чем Hashtable если количество элементов равно 10 или меньше
    /// </summary>
    private static readonly ListDictionary LDictionary = new()
    {
         { "key", "value"}
    };

    /// <summary>
    /// HybridDictionary
    /// Рекомендуется для случаев, когда количество элементов в словаре неизвестно.
    /// Он использует улучшенную производительность ListDictionary с небольшими коллекциями 
    /// и предлагает гибкость переключения на Hashtable , которая обрабатывает большие коллекции лучше
    /// </summary>
    private static readonly HybridDictionary HDictionary = new()
    {
         { "key", "value"}
    };

    /// <summary>
    /// OrderedDictionary 
    /// Он всегда упорядочен при выводе foreach
    /// Ключ не может быть нулевым , но значение может быть.
    /// Каждый элемент представляет собой пару ключ/значение, хранящуюся в объекте DictionaryEntry
    /// Доступ к элементам возможен либо по ключу, либо по индексу.
    /// [!]
    /// если элементов больше 20-ти быстрее при цикле for
    /// если элементов меньше 15-20 быстрее в foreach чем for
    /// </summary>
    private static readonly OrderedDictionary ODictionary = new()
    {
                {"01", "odin"},
                {"02", "dva"},
                {"03", "tri"},
                {"04", "chetiri"},
                {"06", "pyat"},
                {"07", "pyat"},
                {"08", "pyat"},
                {"09", "pyat"},
                {"10", "pyat"},
                {"11", "pyat"},
                {"12", "pyat"},
                {"13", "pyat"},
                {"14", "pyat"},
                {"15", "pyat"},
                {"16", "pyat"},
                {"17", "pyat"},
                {"18", "pyat"},
                {"19", "pyat"},
                {"20", "pyat"},
                {"21", "pyat"},
                {"22", "pyat"},
                {"23", "pyat"},
                {"24", "pyat"},
                {"25", "pyat"},
                {"26", "pyat"},
                {"27", "pyat"},
                {"28", "pyat"},
                {"29", "pyat"},
                {"30", "pyat"},
                {"31", "pyat"}
            };


    /// <summary>
    /// SortedDictionary
    /// Дерево бинарного поиска, в котором все элементы отсортированы на основе ключа
    /// Быстрее вставляет и удаляет элементы
    /// </summary>
    private static readonly SortedDictionary<int, string> SDictionary = new();

    /// <summary>
    /// ConcurrentDictionary
    /// Потокобезопасная коллекция пар "ключ-значение", доступ к которой могут одновременно получать несколько потоков.
    /// по умолчанию 4 потока на запись concurrencyLevel = 4
    /// первоначальное число элементов 31 сapacity = 31
    /// В отличие от обычного Dictionary, можно производить вставку в ConcurrentDictionary или удаление из него прямо во время перечисления
    /// </summary>
    private static readonly ConcurrentDictionary<int, string> СoncurrentDictionary = new();

    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for(int i = 0; i < ODictionary.Count; i++)
        {
            string val = (string)ODictionary[i];
            Console.WriteLine(val);
        }
        stopwatch.Stop();
        Console.WriteLine("[for][el > 20]: " + stopwatch.Elapsed);
        stopwatch.Reset();
        stopwatch.Start();
        foreach (DictionaryEntry item in ODictionary)
        {
            Console.WriteLine(item.Value);
        }
        stopwatch.Stop();
        Console.WriteLine("[foreach][el > 20]: " + stopwatch.Elapsed);
        Console.ReadKey();
    }
}