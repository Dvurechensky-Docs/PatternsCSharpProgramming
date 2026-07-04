/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 июля 2026 08:04:56
 * Version: 1.0.323
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