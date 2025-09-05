/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 сентября 2025 10:10:05
 * Version: 1.0.19
 */

namespace Strategy;

public enum LogType
{
    Debug,
    Warning,
    Fatal
}

public struct LogEntry
{
    public DateTime DateTime { get; set; }
    public LogType LogType { get; set; }
    public string Message { get; set; }
}
