/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2025 17:15:30
 * Version: 1.0.37
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
