/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 октября 2026 07:37:42
 * Version: 1.0.428
 */

namespace Strategy;

public class LogFileReader : ILogReader
{
    public List<LogEntry> Read()
    {
        return new List<LogEntry>()
        {
            new LogEntry()
            {
                DateTime = DateTime.Now,
                LogType = LogType.Debug,
                Message = GetType().Name
            }
        };
    }
}