/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 октября 2026 07:47:39
 * Version: 1.0.434
 */

namespace Strategy;

public class WindowsEventLogReader : ILogReader
{
    public List<LogEntry> Read()
    {
        return new List<LogEntry>()
        {
            new LogEntry()
            {
                DateTime = DateTime.Now,
                Message = GetType().Name,
                LogType = LogType.Debug
            }
        };
    }
}
