/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 ноября 2025 08:15:53
 * Version: 1.0.94
 */

/*  Одиночка
    Гарантирует что класс имеет только
    один экземпляр и представляет глобальную
    точку доступа к нему
 */

class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        (new Thread(() => 
        {
            Console.WriteLine(GameHistory.Instance.History[1]);
        })).Start();
        Console.WriteLine(GameHistory.Instance.History[0]);
        Console.ReadKey();
        #endregion
    }
}

class GameHistory
{
    private static object syncRoot = new();
    private static GameHistory _instance;
    public static GameHistory Instance
    {
        get
        {
            lock(syncRoot)
            {
                if(_instance == null)
                    _instance = new GameHistory();
            }
            return _instance;
        }
    }
    public string[] History { get; set; }
    private GameHistory()
    {
        History = new[] { "One History",
                           "Two History"}; 
    }
}