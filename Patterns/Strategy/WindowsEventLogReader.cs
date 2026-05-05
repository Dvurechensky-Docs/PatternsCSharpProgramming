/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 мая 2026 07:00:41
 * Version: 1.0.263
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
