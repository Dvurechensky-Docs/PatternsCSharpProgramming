/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 ноября 2025 06:51:45
 * Version: 1.0.84
 */

namespace Strategy;

public class LogProcessor
{
    private readonly Func<List<LogEntry>> _logimporter;

    public LogProcessor(Func<List<LogEntry>> logImporter)
    {
        _logimporter = logImporter;
    }

    public void ProcessLogs()
    {
        foreach (var logEntry in _logimporter.Invoke())
        {
            Console.WriteLine(logEntry.DateTime);
            Console.WriteLine(logEntry.LogType);
            Console.WriteLine(logEntry.Message);
        }
    }
}