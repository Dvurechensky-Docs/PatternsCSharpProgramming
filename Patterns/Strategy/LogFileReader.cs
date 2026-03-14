/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 марта 2026 06:52:02
 * Version: 1.0.209
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