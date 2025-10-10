/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 октября 2025 06:51:59
 * Version: 1.0.54
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